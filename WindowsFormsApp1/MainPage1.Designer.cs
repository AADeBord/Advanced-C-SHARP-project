namespace MainPage
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
            this.scheduleDGV = new System.Windows.Forms.DataGridView();
            this.appointmentTitle = new System.Windows.Forms.TextBox();
            this.monthRad = new System.Windows.Forms.RadioButton();
            this.weekRad = new System.Windows.Forms.RadioButton();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.addAppButton = new System.Windows.Forms.Button();
            this.updateAppButton = new System.Windows.Forms.Button();
            this.deleteAppButton = new System.Windows.Forms.Button();
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.findCustomerButton = new System.Windows.Forms.Button();
            this.customerTitle = new System.Windows.Forms.TextBox();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.addCustButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleDGV
            // 
            this.scheduleDGV.AllowUserToAddRows = false;
            this.scheduleDGV.AllowUserToDeleteRows = false;
            this.scheduleDGV.AllowUserToResizeRows = false;
            this.scheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDGV.Location = new System.Drawing.Point(267, 33);
            this.scheduleDGV.Name = "scheduleDGV";
            this.scheduleDGV.ReadOnly = true;
            this.scheduleDGV.Size = new System.Drawing.Size(860, 249);
            this.scheduleDGV.TabIndex = 0;
            // 
            // appointmentTitle
            // 
            this.appointmentTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.appointmentTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTitle.Location = new System.Drawing.Point(267, 12);
            this.appointmentTitle.Name = "appointmentTitle";
            this.appointmentTitle.Size = new System.Drawing.Size(860, 15);
            this.appointmentTitle.TabIndex = 1;
            this.appointmentTitle.Text = "Appointments";
            this.appointmentTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthRad
            // 
            this.monthRad.AutoSize = true;
            this.monthRad.Location = new System.Drawing.Point(267, 10);
            this.monthRad.Name = "monthRad";
            this.monthRad.Size = new System.Drawing.Size(55, 17);
            this.monthRad.TabIndex = 2;
            this.monthRad.TabStop = true;
            this.monthRad.Text = "Month";
            this.monthRad.UseVisualStyleBackColor = true;
            // 
            // weekRad
            // 
            this.weekRad.AutoSize = true;
            this.weekRad.Location = new System.Drawing.Point(358, 10);
            this.weekRad.Name = "weekRad";
            this.weekRad.Size = new System.Drawing.Size(54, 17);
            this.weekRad.TabIndex = 3;
            this.weekRad.TabStop = true;
            this.weekRad.Text = "Week";
            this.weekRad.UseVisualStyleBackColor = true;
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.SystemColors.Menu;
            this.userNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameText.Enabled = false;
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.Location = new System.Drawing.Point(1170, 13);
            this.userNameText.Name = "userNameText";
            this.userNameText.ReadOnly = true;
            this.userNameText.Size = new System.Drawing.Size(168, 15);
            this.userNameText.TabIndex = 4;
            this.userNameText.Text = "user name text";
            // 
            // addAppButton
            // 
            this.addAppButton.Location = new System.Drawing.Point(923, 288);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(64, 26);
            this.addAppButton.TabIndex = 5;
            this.addAppButton.Text = "Add";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateAppButton
            // 
            this.updateAppButton.Location = new System.Drawing.Point(993, 288);
            this.updateAppButton.Name = "updateAppButton";
            this.updateAppButton.Size = new System.Drawing.Size(64, 26);
            this.updateAppButton.TabIndex = 6;
            this.updateAppButton.Text = "Update";
            this.updateAppButton.UseVisualStyleBackColor = true;
            this.updateAppButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteAppButton
            // 
            this.deleteAppButton.Location = new System.Drawing.Point(1063, 288);
            this.deleteAppButton.Name = "deleteAppButton";
            this.deleteAppButton.Size = new System.Drawing.Size(64, 26);
            this.deleteAppButton.TabIndex = 7;
            this.deleteAppButton.Text = "Delete";
            this.deleteAppButton.UseVisualStyleBackColor = true;
            this.deleteAppButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToAddRows = false;
            this.customersDGV.AllowUserToDeleteRows = false;
            this.customersDGV.AllowUserToResizeRows = false;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.Location = new System.Drawing.Point(267, 337);
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.ReadOnly = true;
            this.customersDGV.Size = new System.Drawing.Size(860, 249);
            this.customersDGV.TabIndex = 8;
            // 
            // findCustomerButton
            // 
            this.findCustomerButton.Location = new System.Drawing.Point(267, 288);
            this.findCustomerButton.Name = "findCustomerButton";
            this.findCustomerButton.Size = new System.Drawing.Size(87, 26);
            this.findCustomerButton.TabIndex = 9;
            this.findCustomerButton.Text = "Find Customer";
            this.findCustomerButton.UseVisualStyleBackColor = true;
            // 
            // customerTitle
            // 
            this.customerTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.customerTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTitle.CausesValidation = false;
            this.customerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTitle.Location = new System.Drawing.Point(267, 316);
            this.customerTitle.Name = "customerTitle";
            this.customerTitle.Size = new System.Drawing.Size(860, 15);
            this.customerTitle.TabIndex = 10;
            this.customerTitle.Text = "Customers";
            this.customerTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.Location = new System.Drawing.Point(1063, 592);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(64, 26);
            this.deleteCustButton.TabIndex = 13;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = true;
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(993, 592);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(64, 26);
            this.updateCustButton.TabIndex = 12;
            this.updateCustButton.Text = "Update";
            this.updateCustButton.UseVisualStyleBackColor = true;
            // 
            // addCustButton
            // 
            this.addCustButton.Location = new System.Drawing.Point(923, 592);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(64, 26);
            this.addCustButton.TabIndex = 11;
            this.addCustButton.Text = "Add";
            this.addCustButton.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 120);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1238, 691);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 26);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.deleteCustButton);
            this.Controls.Add(this.updateCustButton);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.customerTitle);
            this.Controls.Add(this.findCustomerButton);
            this.Controls.Add(this.customersDGV);
            this.Controls.Add(this.deleteAppButton);
            this.Controls.Add(this.updateAppButton);
            this.Controls.Add(this.addAppButton);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.weekRad);
            this.Controls.Add(this.monthRad);
            this.Controls.Add(this.appointmentTitle);
            this.Controls.Add(this.scheduleDGV);
            this.Name = "Main";
            this.Text = "Global Co. Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleDGV;
        private System.Windows.Forms.TextBox appointmentTitle;
        private System.Windows.Forms.RadioButton monthRad;
        private System.Windows.Forms.RadioButton weekRad;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.Button updateAppButton;
        private System.Windows.Forms.Button deleteAppButton;
        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Button findCustomerButton;
        private System.Windows.Forms.TextBox customerTitle;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button exitButton;
    }
}

