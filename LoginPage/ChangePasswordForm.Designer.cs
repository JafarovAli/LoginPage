namespace SqlDatabase
{
    partial class ChangePasswordForm
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
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_OldPassword = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.panel_Change_Password = new System.Windows.Forms.Panel();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.panel_Change_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangePassword.Location = new System.Drawing.Point(93, 9);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(421, 54);
            this.labelChangePassword.TabIndex = 0;
            this.labelChangePassword.Text = "Change Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(119, 112);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(108, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPassword.Location = new System.Drawing.Point(87, 154);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(140, 25);
            this.labelOldPassword.TabIndex = 2;
            this.labelOldPassword.Text = "Old Password:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(233, 109);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(181, 30);
            this.textBox_Username.TabIndex = 3;
            // 
            // textBox_OldPassword
            // 
            this.textBox_OldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OldPassword.Location = new System.Drawing.Point(233, 154);
            this.textBox_OldPassword.Name = "textBox_OldPassword";
            this.textBox_OldPassword.Size = new System.Drawing.Size(181, 30);
            this.textBox_OldPassword.TabIndex = 4;
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(275, 82);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(171, 30);
            this.textBox_ConfirmPassword.TabIndex = 5;
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPassword.Location = new System.Drawing.Point(275, 32);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(171, 30);
            this.textBox_NewPassword.TabIndex = 6;
            // 
            // panel_Change_Password
            // 
            this.panel_Change_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Change_Password.Controls.Add(this.labelNewPassword);
            this.panel_Change_Password.Controls.Add(this.labelConfirmPassword);
            this.panel_Change_Password.Controls.Add(this.button_Change);
            this.panel_Change_Password.Controls.Add(this.textBox_NewPassword);
            this.panel_Change_Password.Controls.Add(this.textBox_ConfirmPassword);
            this.panel_Change_Password.Location = new System.Drawing.Point(14, 307);
            this.panel_Change_Password.Name = "panel_Change_Password";
            this.panel_Change_Password.Size = new System.Drawing.Size(567, 200);
            this.panel_Change_Password.TabIndex = 7;
            this.panel_Change_Password.Visible = false;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(109, 36);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(148, 25);
            this.labelNewPassword.TabIndex = 8;
            this.labelNewPassword.Text = "New Password:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(83, 81);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(177, 25);
            this.labelConfirmPassword.TabIndex = 9;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // button_Change
            // 
            this.button_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Change.Location = new System.Drawing.Point(281, 140);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(165, 39);
            this.button_Change.TabIndex = 8;
            this.button_Change.Text = "Change Now";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Check
            // 
            this.button_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.Location = new System.Drawing.Point(251, 215);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(122, 42);
            this.button_Check.TabIndex = 7;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 534);
            this.Controls.Add(this.panel_Change_Password);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.textBox_OldPassword);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelChangePassword);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.panel_Change_Password.ResumeLayout(false);
            this.panel_Change_Password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_OldPassword;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Panel panel_Change_Password;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
    }
}