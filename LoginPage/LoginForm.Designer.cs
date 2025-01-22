namespace SqlDatabase
{
    partial class LoginForm
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
            this.panel_Login = new System.Windows.Forms.Panel();
            this.label_SignUp = new System.Windows.Forms.Label();
            this.label_ChangePassword = new System.Windows.Forms.Label();
            this.label_ForgetPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBox_Password_Login = new System.Windows.Forms.TextBox();
            this.textBox_Username_Login = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Login.Controls.Add(this.label_SignUp);
            this.panel_Login.Controls.Add(this.label_ChangePassword);
            this.panel_Login.Controls.Add(this.label_ForgetPassword);
            this.panel_Login.Controls.Add(this.buttonLogin);
            this.panel_Login.Controls.Add(this.textBox_Password_Login);
            this.panel_Login.Controls.Add(this.textBox_Username_Login);
            this.panel_Login.Controls.Add(this.labelPassword);
            this.panel_Login.Controls.Add(this.labelUsername);
            this.panel_Login.Location = new System.Drawing.Point(4, 98);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(596, 521);
            this.panel_Login.TabIndex = 3;
            // 
            // label_SignUp
            // 
            this.label_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_SignUp.AutoSize = true;
            this.label_SignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_SignUp.Location = new System.Drawing.Point(188, 493);
            this.label_SignUp.Name = "label_SignUp";
            this.label_SignUp.Size = new System.Drawing.Size(200, 16);
            this.label_SignUp.TabIndex = 25;
            this.label_SignUp.Text = "Don\'t Have an account? Sign Up";
            this.label_SignUp.Click += new System.EventHandler(this.label_SignUp_Click);
            // 
            // label_ChangePassword
            // 
            this.label_ChangePassword.AutoSize = true;
            this.label_ChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ChangePassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ChangePassword.Location = new System.Drawing.Point(21, 422);
            this.label_ChangePassword.Name = "label_ChangePassword";
            this.label_ChangePassword.Size = new System.Drawing.Size(147, 22);
            this.label_ChangePassword.TabIndex = 6;
            this.label_ChangePassword.Text = "Change Password";
            this.label_ChangePassword.Click += new System.EventHandler(this.label_ChangePassword_Click);
            // 
            // label_ForgetPassword
            // 
            this.label_ForgetPassword.AutoSize = true;
            this.label_ForgetPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ForgetPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ForgetPassword.Location = new System.Drawing.Point(427, 422);
            this.label_ForgetPassword.Name = "label_ForgetPassword";
            this.label_ForgetPassword.Size = new System.Drawing.Size(138, 22);
            this.label_ForgetPassword.TabIndex = 5;
            this.label_ForgetPassword.Text = "Forget Password";
            this.label_ForgetPassword.Click += new System.EventHandler(this.label_ForgetPassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.Location = new System.Drawing.Point(21, 321);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(544, 61);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBox_Password_Login
            // 
            this.textBox_Password_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password_Login.Location = new System.Drawing.Point(191, 157);
            this.textBox_Password_Login.Name = "textBox_Password_Login";
            this.textBox_Password_Login.Size = new System.Drawing.Size(374, 38);
            this.textBox_Password_Login.TabIndex = 3;
            this.textBox_Password_Login.UseSystemPasswordChar = true;
            // 
            // textBox_Username_Login
            // 
            this.textBox_Username_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username_Login.Location = new System.Drawing.Point(191, 79);
            this.textBox_Username_Login.Name = "textBox_Username_Login";
            this.textBox_Username_Login.Size = new System.Drawing.Size(374, 38);
            this.textBox_Username_Login.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(42, 163);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 29);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(38, 79);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 29);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.ImageLocation = "../../Images/x.png";
            this.pictureBox_Close.Location = new System.Drawing.Point(571, 5);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 4;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(207, 14);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(221, 70);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(604, 626);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.panel_Login);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBox_Password_Login;
        private System.Windows.Forms.TextBox textBox_Username_Login;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label_ChangePassword;
        private System.Windows.Forms.Label label_ForgetPassword;
        private System.Windows.Forms.Label label_SignUp;
    }
}