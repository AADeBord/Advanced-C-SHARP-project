using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace ScheduleApp

{
    public partial class MainPage : Form
    {
        // constructor for the MainPage form.       
        public MainPage(string userName)
        {
            InitializeComponent();
            userNameText.Text = userName;
            weekRad.Checked = true;
            customersDGV.DataSource = DBInterface.allCustData();
            customersDGV.Columns["addressId"].Visible = false;
            monthPicker.CustomFormat = "MM/yyyy";
            appTypeCombo.DataSource = DBInterface.getAppointmentType();
            appTypeCombo.DisplayMember = "type";
            appTypeCombo.ValueMember = "type";
            consultantCombo.DataSource = DBInterface.getConsultant();
            consultantCombo.DisplayMember = "userName";
            consultantCombo.ValueMember = "userId";
            cityCombo.DataSource = DBInterface.getCityList();
            cityCombo.DisplayMember = "city";
            cityCombo.ValueMember = "cityId";
            // Call to function fulfilling aspect H. alert of meetings in the next 15min.
            checkUpcomingAppointmets();
            allRad.Checked = true;
        }
        // Exit button functionality calls exit function at the top of the stack.
        private void exitButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to exit the program?", this.Text, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void checkUpcomingAppointmets()
        {
            DataTable temp = DBInterface.getUpcomingAppointment();
            string appointmentList = "";
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    string tempString = $"You have a {row["type"]} appointment with {row["customerName"]} starting at {row["start"].ToString()} and ending at {row["end"].ToString()}\n";
                    appointmentList = appointmentList + tempString;
                }
                MessageBox.Show(appointmentList);
            }
            else
            {
                MessageBox.Show("You do not have any appointments within the next 15 minutes");
            }
        }
        

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            if (monthRad.Checked == true)
            {
                popMonth(selectedDate);
            }
            if (weekRad.Checked == true)
            {
                popWeek(selectedDate);
            }
            if (allRad.Checked == true)
            {
                popAll();
            }
        }
        public void popMonth(DateTime date)
        {
            monthCalendar.RemoveAllBoldedDates();
            int month = date.Month;
            int daysInMonth = 0;
            string startDate = date.Month.ToString() + "/01/" + date.Year.ToString();
            // set each months days
            switch (month)
            {
                case 1:
                    daysInMonth = 31;
                    break;
                // make sure a leap year doesn't mess things up  
                case 2:
                    if ( date.Year % 4 == 0)
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;
                case 3:
                    daysInMonth = 31;
                    break;
                case 4:
                    daysInMonth = 30;
                    break;
                case 5:
                    daysInMonth = 31;
                    break;
                case 6:
                    daysInMonth = 30;
                    break;
                case 7:
                    daysInMonth = 31;
                    break;
                case 8:
                    daysInMonth = 31;
                    break;
                case 9:
                    daysInMonth = 30;
                    break;
                case 10:
                    daysInMonth = 31;
                    break;
                case 11:
                    daysInMonth = 30;
                    break;
                case 12:
                    daysInMonth = 31;
                    break;
            }
            DateTime tempStart = Convert.ToDateTime(startDate);
            for (int i = 0; i < daysInMonth; i++)
            {
                monthCalendar.AddBoldedDate(tempStart.AddDays(i));
            }
            monthCalendar.UpdateBoldedDates();
            // first submission was rejected because it only queried to the begging to the last day of the month this will add 23 hrs 59 min and 59 sec to the day.
            TimeSpan fullday = new TimeSpan(0, 23, 59, 59);
            
            DateTime tempEnd = tempStart.AddDays(daysInMonth - 1);
            tempEnd = tempEnd + fullday;
            //string endDate = date.Month.ToString() + "/" + daysInMonth.ToString() + "/" + date.Year.ToString();
            scheduleDGV.DataSource = DBInterface.RangeAppointments(tempStart, tempEnd);
            

        }
        public void popWeek(DateTime date)
        {
            monthCalendar.RemoveAllBoldedDates();
            int SpotInWeek = (int)date.DayOfWeek;
            DateTime startDate = date.AddDays(-(int)date.DayOfWeek);
            DateTime endDate = startDate.AddDays(+7);
            TimeSpan almostDay = new TimeSpan(0, 23, 59, 59);
            endDate = endDate + almostDay;
            for (int i = 0; i < 7; i++)
            {
                monthCalendar.AddBoldedDate(startDate.AddDays(i));
            }
            monthCalendar.UpdateBoldedDates();
            scheduleDGV.DataSource = DBInterface.RangeAppointments(startDate, endDate);

        }
        public void popAll()
        {
            scheduleDGV.DataSource = DBInterface.AllAppointments();
        }
        // event to repopulate the appointment data grid view when the filter is changed.
        private void allRad_CheckedChanged(object sender, EventArgs e)
        {
            if (allRad.Checked == true)
            {
                popAll();
            }
        }
        // update appointment button. launches add/modify form with appointment data to be modified.
        private void updateAppButton_Click(object sender, EventArgs e)
        {
            int appId = Convert.ToInt32(scheduleDGV.CurrentRow.Cells[0].Value);
            DataTable modAppInfo = DBInterface.updateAppData(appId);
            addUpdateAppointment updateApp = new addUpdateAppointment(appId, modAppInfo);
            updateApp.ShowDialog();
            this.Show();
            //string temp = modAppInfo.Rows[0]["customerName"].ToString();
            //MessageBox.Show(temp);


        }
        // refresh the appointmentDGV when returning to main page.
        private void MainPage_Activated(object sender, EventArgs e)
        {
            DateTime selected = monthCalendar.SelectionStart;
            if (monthRad.Checked == true)
            {
                popMonth(selected);
            }
            if (weekRad.Checked == true)
            {
                popWeek(selected);
            }
            if (allRad.Checked == true)
            {
                popAll();
            }
            customersDGV.DataSource = DBInterface.allCustData();
            consultantCombo.DataSource = DBInterface.getConsultant();
            appTypeCombo.DataSource = DBInterface.getAppointmentType();
        }
        //add a new appointment using customer information selected from the customersDGV
        private void addAppButton_Click(object sender, EventArgs e)
        {
            
            int customerId = Convert.ToInt32(customersDGV.CurrentRow.Cells[0].Value);
            DataTable temp = DBInterface.customerData(customerId);
            string name = temp.Rows[0]["customerName"].ToString();
            addUpdateAppointment addAppointment = new addUpdateAppointment(customerId, name);
            addAppointment.ShowDialog();
            this.Show();


        }
        // delete appointment button. Deletes the selected appointment
        private void deleteAppButton_Click(object sender, EventArgs e)
        {
            int appId = Convert.ToInt32(scheduleDGV.CurrentRow.Cells[0].Value);
            var confirm = MessageBox.Show($"Are you sure you want to delete #{appId}? Doing so will permanently remove it.", this.Text, MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            if (DBInterface.deleteAppointment(appId) == true)
            {
                MessageBox.Show($"Appointment #{appId.ToString()} deleted successfully.");
            }
            else
            {
                MessageBox.Show($"There was an error while deleting #{appId} appointment.");
            }
        }
        // add customer button. launches add/modify form
        private void addCustButton_Click(object sender, EventArgs e)
        {
            addUpdateCust add = new addUpdateCust();
            add.ShowDialog();
            this.Show();
        }
        // update customer button. launches add / update customer form with customer data.
        private void updateCustButton_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customersDGV.CurrentRow.Cells[0].Value);
            string customerName = customersDGV.CurrentRow.Cells[1].Value.ToString();
            int addressId = Convert.ToInt32(customersDGV.CurrentRow.Cells[3].Value);

            addUpdateCust update = new addUpdateCust(customerId, customerName, addressId);
            update.ShowDialog();
            this.Show();
        }
        // delete customer button. Deletes selected customer from database.
        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(customersDGV.CurrentRow.Cells[0].Value);
            string customerName = customersDGV.CurrentRow.Cells[1].Value.ToString();
            int addressId = Convert.ToInt32(customersDGV.CurrentRow.Cells[3].Value);
            var answer = MessageBox.Show($"Are you sure you want to delete customer #{customerId.ToString()}, {customerName}?", this.Text, MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                if(DBInterface.deleteCustomer(customerId, addressId))
                    {
                    MessageBox.Show($"Customer #{customerId.ToString()}, {customerName} successfully removed from the database.");
                    }
                else
                {
                    MessageBox.Show("Something has gone wrong. Customer record was not successfully removed.");
                }
            }
        }
        // aspect I. generates report of number of appointments by type in selected month
        private void appTypeCountButton_Click(object sender, EventArgs e)
        {
            string type = appTypeCombo.SelectedValue.ToString();
            DateTime month = monthPicker.Value;
            DataTable temp = DBInterface.getTypeMonth(type, month);
            string count = temp.Rows.Count.ToString();
            MessageBox.Show($"There are {count} {type} appointments in the month of {month.Month}/{month.Year}.");
        }
        // aspect I. generates report of a selected consultant / user entire schedule.
        private void consultantScheduleButton_Click(object sender, EventArgs e)
        {
            string report = "";
            int userId = Convert.ToInt32(consultantCombo.SelectedValue);
            DataTable temp = DBInterface.getClientSchedule(userId);
            Schedule schedule = new Schedule(temp);
            schedule.ShowDialog();
        }
        // aspect I. generates a report of the count of customers per selected city.
        private void customerCountButton_Click(object sender, EventArgs e)
        {
            int cityId = Convert.ToInt32(cityCombo.SelectedValue);
            DataTable temp = DBInterface.getCustomerCount(cityId);
            cityCombo.ValueMember = "city";
            string city = cityCombo.SelectedValue.ToString();
            cityCombo.ValueMember = "cityId";
            string count = temp.Rows.Count.ToString();
            MessageBox.Show($"There are {count} customers located in {city}.");
        }

        private void searchAppointment_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(appointmentSearchText.Text))
            {
                scheduleDGV.DataSource = DBInterface.getSearchAppointment(appointmentSearchText.Text);
            }
        }
    }
}
