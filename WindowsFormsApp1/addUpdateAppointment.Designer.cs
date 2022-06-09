namespace ScheduleApp
{
    partial class addUpdateAppointment
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
            this.custNameTitle = new System.Windows.Forms.TextBox();
            this.custIdTitle = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.customerIdText = new System.Windows.Forms.TextBox();
            this.appTypeTitle = new System.Windows.Forms.TextBox();
            this.monthCalander = new System.Windows.Forms.MonthCalendar();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.appointmentIdText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.appTypeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // custNameTitle
            // 
            this.custNameTitle.BackColor = System.Drawing.SystemColors.Control;
            this.custNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custNameTitle.Location = new System.Drawing.Point(85, 90);
            this.custNameTitle.Name = "custNameTitle";
            this.custNameTitle.ReadOnly = true;
            this.custNameTitle.Size = new System.Drawing.Size(100, 13);
            this.custNameTitle.TabIndex = 17;
            this.custNameTitle.Text = "Name";
            this.custNameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // custIdTitle
            // 
            this.custIdTitle.BackColor = System.Drawing.SystemColors.Control;
            this.custIdTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custIdTitle.Location = new System.Drawing.Point(85, 64);
            this.custIdTitle.Name = "custIdTitle";
            this.custIdTitle.ReadOnly = true;
            this.custIdTitle.Size = new System.Drawing.Size(100, 13);
            this.custIdTitle.TabIndex = 16;
            this.custIdTitle.Text = "Customer ID";
            this.custIdTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(292, 368);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 34);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(36, 368);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 34);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // customerIdText
            // 
            this.customerIdText.Enabled = false;
            this.customerIdText.Location = new System.Drawing.Point(191, 61);
            this.customerIdText.Name = "customerIdText";
            this.customerIdText.Size = new System.Drawing.Size(100, 20);
            this.customerIdText.TabIndex = 34;
            // 
            // appTypeTitle
            // 
            this.appTypeTitle.BackColor = System.Drawing.SystemColors.Control;
            this.appTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appTypeTitle.Location = new System.Drawing.Point(85, 119);
            this.appTypeTitle.Name = "appTypeTitle";
            this.appTypeTitle.ReadOnly = true;
            this.appTypeTitle.Size = new System.Drawing.Size(100, 13);
            this.appTypeTitle.TabIndex = 36;
            this.appTypeTitle.Text = "Appointment Type";
            this.appTypeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthCalander
            // 
            this.monthCalander.Location = new System.Drawing.Point(10, 152);
            this.monthCalander.Name = "monthCalander";
            this.monthCalander.TabIndex = 38;
            this.monthCalander.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalander_DateChanged);
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(249, 170);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(172, 20);
            this.startTimePicker.TabIndex = 39;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(249, 240);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(172, 20);
            this.endTimePicker.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(249, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "Start Time";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(249, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 42;
            this.textBox2.Text = "End Time";
            // 
            // nameText
            // 
            this.nameText.Enabled = false;
            this.nameText.Location = new System.Drawing.Point(191, 87);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(145, 20);
            this.nameText.TabIndex = 43;
            // 
            // appointmentIdText
            // 
            this.appointmentIdText.Enabled = false;
            this.appointmentIdText.Location = new System.Drawing.Point(191, 35);
            this.appointmentIdText.Name = "appointmentIdText";
            this.appointmentIdText.Size = new System.Drawing.Size(100, 20);
            this.appointmentIdText.TabIndex = 45;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(85, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 13);
            this.textBox4.TabIndex = 44;
            this.textBox4.Text = "Appointment ID";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // appTypeText
            // 
            this.appTypeText.Location = new System.Drawing.Point(191, 116);
            this.appTypeText.Name = "appTypeText";
            this.appTypeText.Size = new System.Drawing.Size(145, 20);
            this.appTypeText.TabIndex = 46;
            // 
            // addUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 445);
            this.Controls.Add(this.appTypeText);
            this.Controls.Add(this.appointmentIdText);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.monthCalander);
            this.Controls.Add(this.appTypeTitle);
            this.Controls.Add(this.customerIdText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.custNameTitle);
            this.Controls.Add(this.custIdTitle);
            this.Name = "addUpdateAppointment";
            this.Text = "addUpdateAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox custNameTitle;
        private System.Windows.Forms.TextBox custIdTitle;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox customerIdText;
        private System.Windows.Forms.TextBox appTypeTitle;
        private System.Windows.Forms.MonthCalendar monthCalander;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox appointmentIdText;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox appTypeText;
    }
}