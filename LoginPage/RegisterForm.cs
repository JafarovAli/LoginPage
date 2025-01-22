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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void button_Register_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=dbUsers;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"exec spRegisterUser @FirstName,@LastName,@BirhtDate,@Username,@Password,@Email,@Phone,@Role" ;
                command.Parameters.Add(new SqlParameter("@FirstName", textBox_FirstName.Text));
                command.Parameters.Add(new SqlParameter("@LastName",textBox_LastName.Text));
                command.Parameters.Add(new SqlParameter("@BirhtDate",textBox_BirthDate.Text));
                command.Parameters.Add(new SqlParameter("@Username", textBox_Username.Text));
                command.Parameters.Add(new SqlParameter("@Password", textBox_Password.Text));
                command.Parameters.Add(new SqlParameter("@Email", textBox_Email.Text));
                command.Parameters.Add(new SqlParameter("@Phone", textBox_Phone.Text));
                command.Parameters.Add(new SqlParameter("@Role", comboBox_Role.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("Added Sucsessfully.");
            }
        }
        private void label_GoBackLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

    }
}
