using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ScheduleApp
    // this class is full of all of the functions that deal with interaction with the SQL database.
{
    
    class DBInterface
    {

        public static int UserId;
        public static string UserName;
        private static readonly string conString = "server=127.0.0.1;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";
        // convert DateTime to a string in the format MySql will accept
        //  aspect F. 2nd Lambda expression to convert local DateTime to UTC Time then convert to string MySQL can use. Chose Lambda because it could still be easily understood as a lambda for future developers to maintain.
        // aspect E. converts all outgoing datetimes to UTC time based on the clients selected timezone.
        public static Func<DateTime, string> convertUTC = time => TimeZone.CurrentTimeZone.ToUniversalTime(time).ToString("yyy-MM-dd HH:mm:ss");
        public static string SqlTimeFormat(DateTime date)
        {
            string result = date.ToString("yyyy-MM-dd HH:mm:ss");
            return result;
        }
        public static bool Login(string username, string password)
        {
            try
            {
                DataTable temp = new DataTable();
                MySqlConnection conn = new MySqlConnection(conString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT userId, userName FROM user WHERE userName = '{username}' AND password = '{password}'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    temp.Load(reader);
                    UserId = Convert.ToInt32(temp.Rows[0]["userId"]);
                    UserName = username;
                    
                    conn.Close();
                    return true;
                }
                else
                {
                   
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; } 
        }
        public static DataTable allCustData()
        {
            DataTable result = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            try
            {
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName, active, addressId FROM customer", conn);
                result.Load(cmd.ExecuteReader());
                conn.Close();
                return result;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return result;
            }
            
        }
        public static DataTable AllAppointments()
        {
            DataTable result = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT appointment.appointmentId, " +
                    "customer.customerName, " +
                    "appointment.customerId, " +
                    "appointment.type, " +
                    "appointment.start, " +
                    "appointment.end " +
                    "FROM appointment " +
                    "INNER JOIN customer " +
                    "ON appointment.customerId=customer.customerId;", conn);
                result.Load(cmd.ExecuteReader());
                conn.Close();
                foreach (DataRow row in result.Rows)
                {
                    DateTime utcStart = Convert.ToDateTime(row["start"]);
                    DateTime utcEnd = Convert.ToDateTime(row["end"]);
                    // aspect E. converts from UTC to client timezone
                    row["start"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                    row["end"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return result;
            }
        }
        public static DataTable RangeAppointments(DateTime start, DateTime end)
        {
            DataTable result = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            DateTime utcStart = TimeZone.CurrentTimeZone.ToUniversalTime(start);
            DateTime utcEnd = TimeZone.CurrentTimeZone.ToUniversalTime(end);
            
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT appointment.appointmentId, " +
                    "customer.customerName, " +
                    "appointment.customerId, " +
                    "appointment.type, " +
                    "appointment.start, " +
                    "appointment.end " +
                    "FROM appointment " +
                    "INNER JOIN customer " +
                    "ON appointment.customerId=customer.customerId "+
                    $"WHERE appointment.start >= '{SqlTimeFormat(utcStart)}' AND appointment.start <= '{SqlTimeFormat(utcEnd)}';", conn);
                
                result.Load(cmd.ExecuteReader());
                conn.Close();
                foreach (DataRow row in result.Rows)
                {
                    utcStart = Convert.ToDateTime(row["start"]);
                    utcEnd = Convert.ToDateTime(row["end"]);
                    row["start"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                    row["end"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return result;
            }
        }
        public static DataTable updateAppData(int appId)
        {
            DataTable result = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                    ("SELECT appointment.customerId, " +
                    "customer.customerName, " +
                    "appointment.type, " +
                    "appointment.start, " +
                    "appointment.end " +
                    "FROM appointment " +
                    "INNER JOIN customer " +
                    "ON appointment.customerId=customer.customerId " +
                    $"WHERE appointment.appointmentId = {appId};",conn);
                result.Load(cmd.ExecuteReader());
                conn.Close();
                result.Rows[0]["start"] = TimeZone.CurrentTimeZone.ToLocalTime(Convert.ToDateTime(result.Rows[0]["start"]));
                result.Rows[0]["end"] = TimeZone.CurrentTimeZone.ToLocalTime(Convert.ToDateTime(result.Rows[0]["end"]));
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return result;
            }

        }
        
        //F. check conflict for new appointments
        public static bool checkConflict(DateTime start, DateTime end, int userId, int customerId)
        {
            DataTable temp = new DataTable();
            bool result = true;
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            try
            {
                // check conflicting start and end times within the database against all current records
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT appointment.appointmentId, " +
                    "appointment.customerId," +
                    "appointment.userId, " +
                    "appointment.start, " +
                    "appointment.end " +
                    "FROM appointment " +
                    $"WHERE" +
                    $" ((('{convertUTC(start)}' >= appointment.start) AND ('{convertUTC(start)}' <= appointment.end)) " +
                    $"OR (('{convertUTC(end)}' >= appointment.start) AND ('{convertUTC(end)}' <= appointment.end)));", conn);
                temp.Load(cmd.ExecuteReader());
                int rows = temp.Rows.Count;
                if (rows > 0)
                {
                    // a conflict has been detected. Now to check if that conflict is related to either the user or customer.
                    //temp.Load(cmd.ExecuteReader());
                    foreach (DataRow row in temp.Rows)
                    {
                        if (Convert.ToInt32(row["userId"]) == userId)
                        {
                            result = true;
                        }
                        if (Convert.ToInt32(row["customerId"]) == customerId)
                        {
                            result = true;
                        }
                    }
                }
                else
                {
                    // the conflict was not related to either the user or the customer so not really a conflict.
                    result = false;
                }
                if (result == true)
                {
                    MessageBox.Show("A scheduling conflict has been detected with either the customer or user please adjust accordingly and try again");
                }
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            finally
            {
                conn.Close();

            }
            conn.Close();
        }
        //F. check conflict for modifying appointments which includes the appointment ID. Calculated using the Sql database and UTC time to ensure conflicts are not missed due to conversion.
        public static bool checkConflict(DateTime start, DateTime end, int userId, int customerId, int appId)
        {
            DataTable temp = new DataTable();
            bool result = true;
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            try
            {
                // check conflicting start and end times within the database excluding the current appointmentId because this is modifying a current record.
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT appointment.appointmentId, " +
                    "appointment.customerId," +
                    "appointment.userId, " +
                    "appointment.start, " +
                    "appointment.end " +
                    "FROM appointment " +
                    $"WHERE(appointment.appointmentId != '{appId}') " +
                    $"AND ((('{convertUTC(start)}' >= appointment.start) AND ('{convertUTC(start)}' <= appointment.end)) " +
                    $"OR (('{convertUTC(end)}' >= appointment.start) AND ('{convertUTC(end)}' <= appointment.end)));", conn);
                temp.Load(cmd.ExecuteReader());
                int rows = temp.Rows.Count;
                // output cmd string for debug MessageBox.Show(cmd.CommandText);
                if (rows > 0)
                {
                    // a conflict has been detected. Now to check if that conflict is related to either the user or customer.
                    temp.Load(cmd.ExecuteReader());
                    foreach (DataRow row in temp.Rows)
                    {
                        if (Convert.ToInt32(row["userId"]) == userId)
                        {
                            result = true;
                        }
                        if (Convert.ToInt32(row["customerId"]) == customerId)
                        {
                            result = true;
                        }
                    }
                }
                else
                {
                    // the conflict was not related to either the user or the customer so not really a conflict.
                    result = false;
                }
                if (result == true)
                {
                    MessageBox.Show("A scheduling conflict has been detected with either the customer or user please adjust accordingly and try again");
                }
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            finally
            {
                conn.Close();
                
            }
            conn.Close();
        }
        public static bool saveUpdateAppointment(int appId, int custId, string type, DateTime start, DateTime end)
        {
            if ((checkConflict(start, end, UserId, custId, appId)) == false)
            {


                DateTime updateTime = DateTime.Now;
                MySqlConnection conn = new MySqlConnection(conString);
                conn.Open();
                try
                {
                    MySqlTransaction transaction = conn.BeginTransaction();
                    MySqlCommand cmd = new MySqlCommand(
                        "UPDATE appointment " +
                        $"SET appointment.type = '{type}', " +
                        $"appointment.start = '{convertUTC(start)}', " +
                        $"appointment.end = '{convertUTC(end)}', " +
                        $"appointment.lastUpdate = '{convertUTC(updateTime)}', " +
                        $"appointment.lastUpdateBy = '{UserName}' " +
                        $"WHERE appointment.appointmentId = '{appId.ToString()}';", conn);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally { conn.Close(); }

            }
            else
            {
                return false;
            }
            
        }
        public static bool saveAddAppointmnet(int appId, int custId, string type, DateTime start, DateTime end)
        {
            DateTime updateTime = DateTime.Now;
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            if ((checkConflict(start, end, UserId, custId)) == false)
            {
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO appointment " +
                    "(appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    "VALUES " +
                    $"('{appId.ToString()}', " +
                    $"'{custId.ToString()}', " +
                    $"'{UserId.ToString()}', " +
                    "'not needed', " +
                    "'not needed', " +
                    "'not needed', " +
                    "'not needed', " +
                    $"'{type}', " +
                    "'not needed', " +
                    $"'{convertUTC(start)}', " +
                    $"'{convertUTC(end)}', " +
                    $"'{convertUTC(DateTime.Now)}', " +
                    $"'{UserName}', " +
                    $"'{convertUTC(DateTime.Now)}', " +
                    $"'{UserName}');", conn);
                try
                {
                    MySqlTransaction transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
                
            }
            else { return false; }
            conn.Close();
        }
        public static int getUniqueAppointment()
        {
            int result = 0;
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(appointmentId) FROM appointment;", conn);
            DataTable temp = new DataTable();
            try
            {
                temp.Load(cmd.ExecuteReader());
                result = Convert.ToInt32(temp.Rows[0]["MAX(appointmentId)"]);
                result = result + 1;
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable customerData(int customerId)
        {
            DataTable result = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM customer WHERE customerId = '{customerId}';", conn);
            try
            {
                result.Load(cmd.ExecuteReader());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool deleteAppointment(int appId)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = '{appId.ToString()}';", conn);
            conn.Open();
            try
            {
                MySqlTransaction transaction = conn.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getCityList()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT cityId, city, countryId FROM city;", conn);
            DataTable temp = new DataTable();
            try
            {
                conn.Open();
                temp.Load(cmd.ExecuteReader());
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }

        }
        public static string getCountryName(int countryId)
        {
            string result = "";
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"SELECT country FROM country WHERE countryId = '{countryId.ToString()}';", conn);

            try
            {
                conn.Open();
                temp.Load(cmd.ExecuteReader());
                result = temp.Rows[0]["country"].ToString();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;

            }
            finally
            {
                conn.Close();
            }
        }
        public static int getNewCustId()
        {
            int result = 0;
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(customerId) FROM customer;", conn);
            try
            {
                conn.Open();
                temp.Load(cmd.ExecuteReader());
                result = Convert.ToInt32(temp.Rows[0]["Max(customerId)"]);
                result ++;
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
        public static int getNewAddressId()
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT MAX(addressId) FROM address;", conn);
            int result = 0;
            try
            {
                conn.Open();
                temp.Load(cmd.ExecuteReader());
                result = Convert.ToInt32(temp.Rows[0]["Max(addressId)"]);
                result++;
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return result;

            }
            finally
            {
                conn.Close();
            }
        }
        public static bool addNewCustomer(int custId, string customerName, string address1, string address2, int cityId, string postalCode, string phoneNumber)
        {
            
            int newAddressId = getNewAddressId();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO address " +
                "(addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES " +
                $"('{newAddressId.ToString()}', " +
                $"'{address1}', " +
                $"'{address2}', " +
                $"'{cityId.ToString()}', " +
                $"'{postalCode}', " +
                $"'{phoneNumber}', " +
                $"'{convertUTC(DateTime.Now)}', " +
                $"'{UserName}', " +
                $"'{convertUTC(DateTime.Now)}', " +
                $"'{UserName}'); "+
            
                "INSERT INTO customer " +
                "(customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                "VALUES " +
                $"('{custId.ToString()}', " +
                $"'{customerName}', " +
                $"'{newAddressId.ToString()}', " +
                $"1, " +
                $"'{convertUTC(DateTime.Now)}', " +
                $"'{UserName}', " +
                $"'{convertUTC(DateTime.Now)}', " +
                $"'{UserName}');", conn);

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                
                
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool modifyCustomer(int custId, string customerName, string address1, string address2, int cityId, string postalCode, string phoneNumber, int addressId)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand
                ("UPDATE address " +
                $"SET address.address = '{address1}', " +
                $"address.address2 = '{address2}', " +
                $"address.cityId = '{cityId.ToString()}', " +
                $"address.postalCode = '{postalCode.ToString()}', " +
                $"address.phone = '{phoneNumber}', " +
                $"address.lastUpdate = '{convertUTC(DateTime.Now)}', " +
                $"address.lastUpdateBy = '{UserName}' " +
                $"WHERE address.addressId = '{addressId.ToString()}'; " +
                "UPDATE customer " +
                $"SET customer.customerName = '{customerName}', " +
                $"customer.lastUpdate = '{convertUTC(DateTime.Now)}', " +
                $"customer.lastUpdateBy = '{UserName}' " +
                $"WHERE customer.customerId = '{custId.ToString()}';", conn);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {

                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool deleteCustomer(int custId, int addressId)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM customer WHERE customerId = '{custId.ToString()}'; DELETE FROM address WHERE address.addressId = '{addressId.ToString()}';", conn);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getAddressData(int addressId) 
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"SELECT address, address2, cityId, postalCode, phone FROM address WHERE addressId = '{addressId.ToString()}';", conn);
            conn.Open();
            try
            {
                temp.Load(cmd.ExecuteReader());
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getAppointmentType()
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT type FROM appointment;", conn);
            conn.Open();
            try
            {
                temp.Load(cmd.ExecuteReader());
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }
            
        }
        public static DataTable getConsultant()
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT userId, userName FROM user;", conn);
            conn.Open();
            try
            {
                temp.Load(cmd.ExecuteReader());
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getTypeMonth(string type, DateTime start)
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(
                $"SELECT appointmentId, type FROM appointment " +
                $"WHERE year(appointment.start) = {start.Year.ToString()} AND" +
                $" month(appointment.start) = {start.Month.ToString()} " +
                $"AND appointment.type = '{type}';", conn);
            conn.Open();
            try
            {
                temp.Load(cmd.ExecuteReader());
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getClientSchedule(int userId)
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"SELECT type, start, end FROM appointment WHERE userId = '{userId.ToString()}';", conn);
            conn.Open();
            try
            {
                temp.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp.Rows)
                {
                    DateTime utcStart = Convert.ToDateTime(row["start"]);
                    DateTime utcEnd = Convert.ToDateTime(row["end"]);
                    row["start"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                    row["end"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
                }
                return temp;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getCustomerCount(int cityId)
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"SELECT addressId FROM address WHERE cityId ='{cityId.ToString()}';", conn);
            conn.Open();
            try
            {
                temp.Load(cmd.ExecuteReader());
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable getUpcomingAppointment()
        {
            DateTime add15 = DateTime.Now.AddMinutes(15);
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand($"SELECT appointment.appointmentId, " +
                $"appointment.type, " +
                $"customer.customerName, " +
                $"appointment.start, " +
                $"appointment.end " +
                $"FROM appointment " +
                $"INNER JOIN customer " +
                $"ON appointment.customerId=customer.customerId " +
                $"WHERE ((appointment.userId = '{UserId.ToString()}') " +
                $"AND (appointment.start >= '{convertUTC(DateTime.Now)}' AND " +
                $"appointment.start <= '{convertUTC(add15)}')); ", conn);
               
                
            conn.Open();
            try
            {
                
                temp.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp.Rows)
                {
                    DateTime utcStart = Convert.ToDateTime(row["start"]);
                    DateTime utcEnd = Convert.ToDateTime(row["end"]);
                    row["start"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                    row["end"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
                }
                
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return temp;
            }
            finally
            {
                conn.Close();
            }

        }
        public static DataTable getSearchAppointment(string customerName)
        {
            DataTable temp = new DataTable();
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(
                    "SELECT appointment.appointmentId, " +
                    "customer.customerName, " +
                    "appointment.customerId, " +
                    "appointment.type, " +
                    "appointment.start, " +
                    "appointment.end " +
                    "FROM customer " +
                    "JOIN appointment " +
                    "ON appointment.customerId = customer.customerId " +
                    "" +
                    $"WHERE customer.customerName = '{customerName}';", conn);
            conn.Open();
            temp.Load(cmd.ExecuteReader());
            conn.Close();
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    DateTime utcStart = Convert.ToDateTime(row["start"]);
                    DateTime utcEnd = Convert.ToDateTime(row["end"]);
                    // aspect E. converts from UTC to client timezone
                    row["start"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                    row["end"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
                }
            }
            else
            {
                MessageBox.Show($"Sorry {customerName} was not found please retry");
            }
            return temp;
        }
       

    }
}
