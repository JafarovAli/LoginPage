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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SqlDatabase
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void button_GetPassword_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=dbUsers;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select Email, Password from Users Where Email = '"+textBox_Email.Text+"'",connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox_Password.Text = reader[1].ToString();

                }
                else
                {
                    MessageBox.Show("User not available");
                    textBox_Password.Text = "";
                }
            }
        }
    }
}
