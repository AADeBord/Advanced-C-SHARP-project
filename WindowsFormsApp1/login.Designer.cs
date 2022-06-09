namespace ScheduleApp

{
    partial class login
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
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameTitle = new System.Windows.Forms.TextBox();
            this.passwordTitle = new System.Windows.Forms.TextBox();
            this.cancleButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(175, 46);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(202, 20);
            this.userNameText.TabIndex = 0;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(175, 96);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(202, 20);
            this.passwordText.TabIndex = 1;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // userNameTitle
            // 
            this.userNameTitle.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTitle.Location = new System.Drawing.Point(69, 49);
            this.userNameTitle.Name = "userNameTitle";
            this.userNameTitle.ReadOnly = true;
            this.userNameTitle.Size = new System.Drawing.Size(100, 13);
            this.userNameTitle.TabIndex = 2;
            this.userNameTitle.Text = "User Name:";
            this.userNameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // passwordTitle
            // 
            this.passwordTitle.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTitle.Location = new System.Drawing.Point(69, 99);
            this.passwordTitle.Name = "passwordTitle";
            this.passwordTitle.ReadOnly = true;
            this.passwordTitle.Size = new System.Drawing.Size(100, 13);
            this.passwordTitle.TabIndex = 3;
            this.passwordTitle.Text = "Password:";
            this.passwordTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(263, 137);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(75, 23);
            this.cancleButton.TabIndex = 5;
            this.cancleButton.Text = "Cancel";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(175, 137);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.passwordTitle);
            this.Controls.Add(this.userNameTitle);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userNameTitle;
        private System.Windows.Forms.TextBox passwordTitle;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button submitButton;
    }
}