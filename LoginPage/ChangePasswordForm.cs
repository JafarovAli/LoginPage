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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=dbUsers;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select Username,Password from Users Where Username ='"+textBox_Username.Text+"'",connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Success...");
                    panel_Change_Password.Visible = true;
                }
                else
                {
                    MessageBox.Show("Not Match");
                }
            }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            if (textBox_NewPassword.Text==textBox_ConfirmPassword.Text)
            {
                using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=dbUsers;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update Users set Password= '"+textBox_NewPassword.Text+"' Where Username='"+textBox_Username.Text+"'",connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password Changed!");
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                }

            }
            else
            {
                MessageBox.Show("Not Match");
            }
        }
    }
}
