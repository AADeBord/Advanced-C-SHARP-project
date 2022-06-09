using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class addUpdateAppointment : Form
    {
        //constructor for adding a new appointment
        public addUpdateAppointment(int customerId, string customerName)
        {
            InitializeComponent();
            appointmentIdText.Text = DBInterface.getUniqueAppointment().ToString();
            customerIdText.Text = customerId.ToString();
            nameText.Text = customerName;
        }
        
        // constructor for updating an appointment
        public addUpdateAppointment(int appId, DataTable popData)
        {
            InitializeComponent();
            DataTable data = popData;
            this.Text = "Modify Appointment";
            int ID = appId;
            appointmentIdText.Text = ID.ToString();
            customerIdText.Text = popData.Rows[0]["customerId"].ToString();
            nameText.Text = popData.Rows[0]["customerName"].ToString();
            appTypeText.Text = popData.Rows[0]["type"].ToString();
            DateTime start = Convert.ToDateTime(popData.Rows[0]["start"]);
            DateTime end = Convert.ToDateTime(popData.Rows[0]["end"]);
            monthCalander.SetDate(start);
            startTimePicker.Value = start;
            endTimePicker.Value = end;

        }
        public bool checkTypeNull()
        {
            if (string.IsNullOrEmpty(appTypeText.Text))
            {
                MessageBox.Show("The type field must be filled out please ensure you specify an appointment type.");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Part F. Exception control for appointment outside of business hours. Calculated in local time. Scheduling conflict handled in DBInterface.checkConflict
            if (businessHoursCheck(startTimePicker.Value, endTimePicker.Value) == true && checkTypeNull() == true ) 
            {


                if (this.Text == "Modify Appointment")
                {
                    if (DBInterface.saveUpdateAppointment(
                        Convert.ToInt32(appointmentIdText.Text),
                        Convert.ToInt32(customerIdText.Text),
                        appTypeText.Text,
                        startTimePicker.Value,
                        endTimePicker.Value) == true)
                    {
                        MessageBox.Show("Appointed data saved successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There was a problem saving the appointment data please check your dates and times");
                    }
                }
                else
                {
                    if (DBInterface.saveAddAppointmnet(
                        Convert.ToInt32(appointmentIdText.Text),
                        Convert.ToInt32(customerIdText.Text),
                        appTypeText.Text,
                        startTimePicker.Value,
                        endTimePicker.Value) == true)
                    {
                        MessageBox.Show("Appointment data saved Successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There was a problem saving the appointment data please check your dates and times");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please correct the necessary information and try again.");
            }
            
            
        }
        public bool businessHoursCheck(DateTime start, DateTime end)
        {
            TimeSpan open = new TimeSpan(9, 0, 0);
            TimeSpan close = new TimeSpan(17, 0, 0);
            TimeSpan startTime = start.TimeOfDay;
            TimeSpan endTime = end.TimeOfDay;
            string message = "The appointment times you have chosen are outside of our normal business hours of 9:00AM to 5:00PM Monday - Friday. Please adjust your times and try again.";

            // check to see if either start time or end time land on a weekend. 
            if (start.DayOfWeek != DayOfWeek.Sunday && start.DayOfWeek != DayOfWeek.Saturday && end.DayOfWeek != DayOfWeek.Sunday && end.DayOfWeek != DayOfWeek.Saturday)
            {
                if ((startTime < open || startTime > close) || (endTime < open || endTime > close))
                {
                    MessageBox.Show(message);
                    return false;

                }
                else { return true; }
            }
            else
            {
                MessageBox.Show(message);
                return false;
            }

        }

        private void monthCalander_DateChanged(object sender, DateRangeEventArgs e)
        {
            startTimePicker.Value = e.Start;
            endTimePicker.Value = e.Start;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to cancel? All unsaved data will be lost.", this.Text, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
    }
}
