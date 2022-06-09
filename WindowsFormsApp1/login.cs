using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data;
using System.IO;

namespace ScheduleApp

{
    public partial class login : Form
    {
        public string exitText = "Are you sure you want to exit?";
        public string loginError = "The user name and password information are invalid.";
        public string connectSuccess = "Connection established.";
        public string userName;
        // test int for culture check public int lcid = 1031;
        public login()
        {
            InitializeComponent();

            MessageBox.Show(RegionInfo.CurrentRegion.ToString());
            cultureCheck();

        }
        //  aspect A function to check and set the language to German if the German LCID is detected.
        private void cultureCheck()
        
        {
            // covering all of the option for how the evaluator emulates the German region information.
            if (CultureInfo.CurrentUICulture.LCID == 1031 || CultureInfo.CurrentCulture.ToString() == "de-DE" || CultureInfo.CurrentCulture.ToString() == "en-DE" || RegionInfo.CurrentRegion.ToString() == "DE")
            {
                exitText = "Sie sind sicher, dass Sie beenden wollen?";
                loginError = "Der Benutzername und das Kennwort sind ungültig.";
                this.Text = "Anmeldung";
                userNameTitle.Text = "Nutzername:";
                passwordTitle.Text = "Passwort:";
                submitButton.Text = "Einreichen";
                cancleButton.Text = "Abbrechen";
                connectSuccess = "Verbindung hergestellt";

            }
        }
        // aspect J. write to a log file. If the file does not exist it creates a new one. 
        public void loginLog(string logEvent)
        {
            string path = Directory.GetCurrentDirectory()+@"\LogFile.txt";
            MessageBox.Show(path+"\n \n This message is in place to help locate the LogFile.txt for part J");
            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(logEvent);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(logEvent);
                }
            }
        }
        
        private void cancleButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(exitText, this.Text, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        // This button click function fulfills aspect A. log in exception handling and error messages. Contains aspect F. Lambda expression to close the login form when the mainPage is closed. 
        private void submitButton_Click(object sender, EventArgs e)
        {
            if ((DBInterface.Login(userNameText.Text, passwordText.Text)) == true)
            {
                MessageBox.Show(connectSuccess);
                userName = userNameText.Text;
                string success = $"User: {userName} logged into the database at {DateTime.Now.ToString()}.";
                loginLog(success);

                MainPage mainP = new MainPage(userName);
                this.Hide();
                mainP.Closed += (s, args) => this.Close(); // Lambda expression used to close login page when main page event Closed is fired. Lambda used because its more efficient and still easy to understand. 
                mainP.Show();
            }
            else
            {
                MessageBox.Show(loginError);
                userName = userNameText.Text;
                string fail = $"Unsuccessful login attempt by User: {userName} at {DateTime.Now.ToString()}.";
                loginLog(fail);
            }
        }
    }
}
