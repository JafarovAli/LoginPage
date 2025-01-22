namespace SqlDatabase
{
    partial class ForgetPasswordForm
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
            this.label_ForgetPassword = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_GetPassword = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ForgetPassword
            // 
            this.label_ForgetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ForgetPassword.AutoSize = true;
            this.label_ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ForgetPassword.Location = new System.Drawing.Point(87, 9);
            this.label_ForgetPassword.Name = "label_ForgetPassword";
            this.label_ForgetPassword.Size = new System.Drawing.Size(393, 54);
            this.label_ForgetPassword.TabIndex = 0;
            this.label_ForgetPassword.Text = "Forget Password";
            // 
            // label_Email
            // 
            this.label_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(101, 162);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(80, 29);
            this.label_Email.TabIndex = 1;
            this.label_Email.Text = "Email:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(209, 159);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(271, 34);
            this.textBox_Email.TabIndex = 2;
            // 
            // button_GetPassword
            // 
            this.button_GetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_GetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetPassword.Location = new System.Drawing.Point(275, 214);
            this.button_GetPassword.Name = "button_GetPassword";
            this.button_GetPassword.Size = new System.Drawing.Size(205, 45);
            this.button_GetPassword.TabIndex = 3;
            this.button_GetPassword.Text = "Get Password";
            this.button_GetPassword.UseVisualStyleBackColor = true;
            this.button_GetPassword.Click += new System.EventHandler(this.button_GetPassword_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Password.Enabled = false;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(209, 283);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(271, 34);
            this.textBox_Password.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(55, 288);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(126, 29);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password:";
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 470);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.button_GetPassword);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_ForgetPassword);
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ForgetPassword;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_GetPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
    }
}