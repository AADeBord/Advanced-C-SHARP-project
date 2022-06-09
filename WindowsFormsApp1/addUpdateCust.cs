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
    public partial class addUpdateCust : Form
    {
        int countryId;
        int cityId;
        int addressId;

        public addUpdateCust()
        {
            InitializeComponent();
            this.Text = "Add Customer";
            customerIdText.Text = DBInterface.getNewCustId().ToString();
            cityComboBox.DataSource = DBInterface.getCityList();
            cityComboBox.DisplayMember = "city";
            cityComboBox.ValueMember = "countryId";
            setComboValues();
            
            

            

        }
        // constructor for updating a customer
        public addUpdateCust(int customerId, string customerName, int addressID)
        {
            InitializeComponent();
            cityComboBox.DataSource = DBInterface.getCityList();
            cityComboBox.DisplayMember = "city";
            cityComboBox.ValueMember = "cityId";
            DataTable popData = DBInterface.getAddressData(customerId);
            this.Text = "Modify Customer";
            customerIdText.Text = customerId.ToString();
            customerNameText.Text = customerName;
            cityComboBox.SelectedValue = Convert.ToInt32(popData.Rows[0]["cityId"]);
            setComboValues();
            customerPhoneText.Text = popData.Rows[0]["phone"].ToString();
            customerStreetText.Text = popData.Rows[0]["address"].ToString();
            customerAddress2Text.Text = popData.Rows[0]["address2"].ToString();
            postalCodeText.Text = popData.Rows[0]["postalCode"].ToString();
            addressId = addressID;


        }
        public void setComboValues()
        {
            cityComboBox.ValueMember = "countryId";
            countryId = Convert.ToInt32(cityComboBox.SelectedValue);
            countryText.Text = DBInterface.getCountryName(countryId);
            cityComboBox.ValueMember = "cityId";
            cityId = Convert.ToInt32(cityComboBox.SelectedValue);
        }

        private void cityComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            setComboValues();
            

        }
        //F. check to make sure the customer data is not null. 
        public bool validateCustomerData()
        {
            if(string.IsNullOrEmpty(customerNameText.Text) ||
               string.IsNullOrEmpty(customerPhoneText.Text) ||
               string.IsNullOrEmpty(customerStreetText.Text) ||
               string.IsNullOrEmpty(postalCodeText.Text))
            {
                MessageBox.Show("Please make sure all required fields are filled out before saving the customer information to the database.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.Text == "Add Customer")
            {
                if (validateCustomerData())
                {
                    if(DBInterface.addNewCustomer(Convert.ToInt32(customerIdText.Text), customerNameText.Text, customerStreetText.Text, customerAddress2Text.Text, cityId, postalCodeText.Text, customerPhoneText.Text))
                    {
                        MessageBox.Show($"New customer #{customerIdText.Text}, {customerNameText.Text} saved to the database.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There was an issue saving the new customer to database please check you data and try again.");
                    }
                }
            }
            else
            {
                if (validateCustomerData())
                {
                    if(DBInterface.modifyCustomer(Convert.ToInt32(customerIdText.Text), customerNameText.Text, customerStreetText.Text, customerAddress2Text.Text, cityId, postalCodeText.Text, customerPhoneText.Text, addressId))
                    {
                        MessageBox.Show($"Successfully updated customer #{customerIdText.Text}, {customerNameText.Text}.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("There was an issue saving the modified information. Please check to make sure all required fields are filled out.");
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you sure you wish to cancel? All unsaved data will be lost.", this.Text, MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
