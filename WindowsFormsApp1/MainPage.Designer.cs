using System;

namespace ScheduleApp
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.addCustButton = new System.Windows.Forms.Button();
            this.customerTitle = new System.Windows.Forms.TextBox();
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.deleteAppButton = new System.Windows.Forms.Button();
            this.updateAppButton = new System.Windows.Forms.Button();
            this.addAppButton = new System.Windows.Forms.Button();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.weekRad = new System.Windows.Forms.RadioButton();
            this.monthRad = new System.Windows.Forms.RadioButton();
            this.appointmentTitle = new System.Windows.Forms.TextBox();
            this.scheduleDGV = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.userNameTitle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allRad = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.appTypeCountButton = new System.Windows.Forms.Button();
            this.consultantScheduleButton = new System.Windows.Forms.Button();
            this.customerCountButton = new System.Windows.Forms.Button();
            this.consultantCombo = new System.Windows.Forms.ComboBox();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.appTypeCombo = new System.Windows.Forms.ComboBox();
            this.monthPicker = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.searchAppointment = new System.Windows.Forms.Button();
            this.appointmentSearchText = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(53, 111);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 29;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.Location = new System.Drawing.Point(1136, 670);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(64, 26);
            this.deleteCustButton.TabIndex = 28;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = true;
            this.deleteCustButton.Click += new System.EventHandler(this.deleteCustButton_Click);
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(1066, 670);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(64, 26);
            this.updateCustButton.TabIndex = 27;
            this.updateCustButton.Text = "Update";
            this.updateCustButton.UseVisualStyleBackColor = true;
            this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
            // 
            // addCustButton
            // 
            this.addCustButton.Location = new System.Drawing.Point(996, 670);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(64, 26);
            this.addCustButton.TabIndex = 26;
            this.addCustButton.Text = "Add";
            this.addCustButton.UseVisualStyleBackColor = true;
            this.addCustButton.Click += new System.EventHandler(this.addCustButton_Click);
            // 
            // customerTitle
            // 
            this.customerTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.customerTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTitle.CausesValidation = false;
            this.customerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTitle.Location = new System.Drawing.Point(340, 394);
            this.customerTitle.Name = "customerTitle";
            this.customerTitle.ReadOnly = true;
            this.customerTitle.Size = new System.Drawing.Size(860, 15);
            this.customerTitle.TabIndex = 25;
            this.customerTitle.Text = "Customers";
            this.customerTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.AllowUserToResizeRows = false;
            this.customersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.Location = new System.Drawing.Point(340, 415);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.ReadOnly = true;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(860, 249);
            this.customersDGV.TabIndex = 23;
            // 
            // deleteAppButton
            // 
            this.deleteAppButton.Location = new System.Drawing.Point(1136, 366);
            this.deleteAppButton.Name = "deleteAppButton";
            this.deleteAppButton.Size = new System.Drawing.Size(64, 26);
            this.deleteAppButton.TabIndex = 22;
            this.deleteAppButton.Text = "Delete";
            this.deleteAppButton.UseVisualStyleBackColor = true;
            this.deleteAppButton.Click += new System.EventHandler(this.deleteAppButton_Click);
            // 
            // updateAppButton
            // 
            this.updateAppButton.Location = new System.Drawing.Point(1066, 366);
            this.updateAppButton.Name = "updateAppButton";
            this.updateAppButton.Size = new System.Drawing.Size(64, 26);
            this.updateAppButton.TabIndex = 21;
            this.updateAppButton.Text = "Update";
            this.updateAppButton.UseVisualStyleBackColor = true;
            this.updateAppButton.Click += new System.EventHandler(this.updateAppButton_Click);
            // 
            // addAppButton
            // 
            this.addAppButton.Location = new System.Drawing.Point(996, 366);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(64, 26);
            this.addAppButton.TabIndex = 20;
            this.addAppButton.Text = "Add";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addAppButton_Click);
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.SystemColors.Menu;
            this.userNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameText.Enabled = false;
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.Location = new System.Drawing.Point(1206, 22);
            this.userNameText.Name = "userNameText";
            this.userNameText.ReadOnly = true;
            this.userNameText.Size = new System.Drawing.Size(132, 15);
            this.userNameText.TabIndex = 19;
            this.userNameText.Text = "user name text";
            // 
            // weekRad
            // 
            this.weekRad.AutoSize = true;
            this.weekRad.Location = new System.Drawing.Point(144, 82);
            this.weekRad.Name = "weekRad";
            this.weekRad.Size = new System.Drawing.Size(54, 17);
            this.weekRad.TabIndex = 18;
            this.weekRad.TabStop = true;
            this.weekRad.Text = "Week";
            this.weekRad.UseVisualStyleBackColor = true;
            // 
            // monthRad
            // 
            this.monthRad.AutoSize = true;
            this.monthRad.Location = new System.Drawing.Point(83, 82);
            this.monthRad.Name = "monthRad";
            this.monthRad.Size = new System.Drawing.Size(55, 17);
            this.monthRad.TabIndex = 17;
            this.monthRad.TabStop = true;
            this.monthRad.Text = "Month";
            this.monthRad.UseVisualStyleBackColor = true;
            // 
            // appointmentTitle
            // 
            this.appointmentTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.appointmentTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTitle.Location = new System.Drawing.Point(340, 90);
            this.appointmentTitle.Name = "appointmentTitle";
            this.appointmentTitle.ReadOnly = true;
            this.appointmentTitle.Size = new System.Drawing.Size(860, 15);
            this.appointmentTitle.TabIndex = 16;
            this.appointmentTitle.Text = "Appointments";
            this.appointmentTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scheduleDGV
            // 
            this.scheduleDGV.AllowUserToAddRows = false;
            this.scheduleDGV.AllowUserToDeleteRows = false;
            this.scheduleDGV.AllowUserToResizeRows = false;
            this.scheduleDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDGV.Location = new System.Drawing.Point(340, 111);
            this.scheduleDGV.Name = "scheduleDGV";
            this.scheduleDGV.ReadOnly = true;
            this.scheduleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleDGV.Size = new System.Drawing.Size(860, 249);
            this.scheduleDGV.TabIndex = 15;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1274, 691);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 26);
            this.exitButton.TabIndex = 30;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userNameTitle
            // 
            this.userNameTitle.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTitle.Location = new System.Drawing.Point(1131, 24);
            this.userNameTitle.Name = "userNameTitle";
            this.userNameTitle.ReadOnly = true;
            this.userNameTitle.Size = new System.Drawing.Size(69, 13);
            this.userNameTitle.TabIndex = 31;
            this.userNameTitle.Text = "User Name:";
            this.userNameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // allRad
            // 
            this.allRad.AutoSize = true;
            this.allRad.Location = new System.Drawing.Point(204, 82);
            this.allRad.Name = "allRad";
            this.allRad.Size = new System.Drawing.Size(36, 17);
            this.allRad.TabIndex = 33;
            this.allRad.TabStop = true;
            this.allRad.Text = "All";
            this.allRad.UseVisualStyleBackColor = true;
            this.allRad.CheckedChanged += new System.EventHandler(this.allRad_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(112, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Select Range";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(112, 349);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "Reports";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // appTypeCountButton
            // 
            this.appTypeCountButton.Location = new System.Drawing.Point(53, 411);
            this.appTypeCountButton.Name = "appTypeCountButton";
            this.appTypeCountButton.Size = new System.Drawing.Size(227, 26);
            this.appTypeCountButton.TabIndex = 36;
            this.appTypeCountButton.Text = "View appointment type by month";
            this.appTypeCountButton.UseVisualStyleBackColor = true;
            this.appTypeCountButton.Click += new System.EventHandler(this.appTypeCountButton_Click);
            // 
            // consultantScheduleButton
            // 
            this.consultantScheduleButton.Location = new System.Drawing.Point(53, 494);
            this.consultantScheduleButton.Name = "consultantScheduleButton";
            this.consultantScheduleButton.Size = new System.Drawing.Size(227, 26);
            this.consultantScheduleButton.TabIndex = 37;
            this.consultantScheduleButton.Text = "View consultants schedule";
            this.consultantScheduleButton.UseVisualStyleBackColor = true;
            this.consultantScheduleButton.Click += new System.EventHandler(this.consultantScheduleButton_Click);
            // 
            // customerCountButton
            // 
            this.customerCountButton.Location = new System.Drawing.Point(53, 572);
            this.customerCountButton.Name = "customerCountButton";
            this.customerCountButton.Size = new System.Drawing.Size(227, 26);
            this.customerCountButton.TabIndex = 38;
            this.customerCountButton.Text = "Customer count by city";
            this.customerCountButton.UseVisualStyleBackColor = true;
            this.customerCountButton.Click += new System.EventHandler(this.customerCountButton_Click);
            // 
            // consultantCombo
            // 
            this.consultantCombo.FormattingEnabled = true;
            this.consultantCombo.Location = new System.Drawing.Point(53, 467);
            this.consultantCombo.Name = "consultantCombo";
            this.consultantCombo.Size = new System.Drawing.Size(227, 21);
            this.consultantCombo.TabIndex = 39;
            // 
            // cityCombo
            // 
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(53, 545);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(227, 21);
            this.cityCombo.TabIndex = 40;
            // 
            // appTypeCombo
            // 
            this.appTypeCombo.FormattingEnabled = true;
            this.appTypeCombo.Location = new System.Drawing.Point(172, 384);
            this.appTypeCombo.Name = "appTypeCombo";
            this.appTypeCombo.Size = new System.Drawing.Size(108, 21);
            this.appTypeCombo.TabIndex = 41;
            // 
            // monthPicker
            // 
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicker.Location = new System.Drawing.Point(53, 384);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(100, 20);
            this.monthPicker.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(53, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 43;
            this.textBox3.Text = "Select month";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(172, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(108, 13);
            this.textBox4.TabIndex = 44;
            this.textBox4.Text = "Appointment type";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(112, 448);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 45;
            this.textBox5.Text = "Consultant list";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(112, 526);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 46;
            this.textBox6.Text = "City list";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(634, 373);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(356, 13);
            this.textBox7.TabIndex = 47;
            this.textBox7.Text = "To add appointment select a customer first.";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchAppointment
            // 
            this.searchAppointment.Location = new System.Drawing.Point(939, 79);
            this.searchAppointment.Name = "searchAppointment";
            this.searchAppointment.Size = new System.Drawing.Size(64, 26);
            this.searchAppointment.TabIndex = 48;
            this.searchAppointment.Text = "Search";
            this.searchAppointment.UseVisualStyleBackColor = true;
            this.searchAppointment.Click += new System.EventHandler(this.searchAppointment_Click);
            // 
            // appointmentSearchText
            // 
            this.appointmentSearchText.Location = new System.Drawing.Point(1009, 83);
            this.appointmentSearchText.Name = "appointmentSearchText";
            this.appointmentSearchText.Size = new System.Drawing.Size(212, 20);
            this.appointmentSearchText.TabIndex = 49;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(1009, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(150, 13);
            this.textBox8.TabIndex = 50;
            this.textBox8.Text = "Enter customer name to search for.";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.appointmentSearchText);
            this.Controls.Add(this.searchAppointment);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.monthPicker);
            this.Controls.Add(this.appTypeCombo);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.consultantCombo);
            this.Controls.Add(this.customerCountButton);
            this.Controls.Add(this.consultantScheduleButton);
            this.Controls.Add(this.appTypeCountButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.allRad);
            this.Controls.Add(this.userNameTitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.deleteCustButton);
            this.Controls.Add(this.updateCustButton);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.customerTitle);
            this.Controls.Add(this.customersDGV);
            this.Controls.Add(this.deleteAppButton);
            this.Controls.Add(this.updateAppButton);
            this.Controls.Add(this.addAppButton);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.weekRad);
            this.Controls.Add(this.monthRad);
            this.Controls.Add(this.appointmentTitle);
            this.Controls.Add(this.scheduleDGV);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Activated += new System.EventHandler(this.MainPage_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.TextBox customerTitle;
        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Button deleteAppButton;
        private System.Windows.Forms.Button updateAppButton;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.RadioButton weekRad;
        private System.Windows.Forms.RadioButton monthRad;
        private System.Windows.Forms.TextBox appointmentTitle;
        private System.Windows.Forms.DataGridView scheduleDGV;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox userNameTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton allRad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button appTypeCountButton;
        private System.Windows.Forms.Button consultantScheduleButton;
        private System.Windows.Forms.Button customerCountButton;
        private System.Windows.Forms.ComboBox consultantCombo;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.ComboBox appTypeCombo;
        private System.Windows.Forms.DateTimePicker monthPicker;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button searchAppointment;
        private System.Windows.Forms.TextBox appointmentSearchText;
        private System.Windows.Forms.TextBox textBox8;
    }
}