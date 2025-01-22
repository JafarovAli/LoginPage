using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlDatabase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


         private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = textBox_Username_Login.Text;
            password = textBox_Password_Login.Text;

            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=dbUsers;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                connection.Open();
                String querry= "SELECT * FROM Users Where Username = '"+textBox_Username_Login.Text+ "' AND Password = '"+textBox_Password_Login.Text+ "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry,connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count>0)
                {
                    username = textBox_Username_Login.Text;
                    password = textBox_Password_Login.Text;

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox_Username_Login.Focus();
                }
            }
        }

        private void label_ForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            this.Hide();
            forgetPasswordForm.Show();
        }

        private void label_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            this.Hide();
            changePasswordForm.Show();
        }

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
    }
}
