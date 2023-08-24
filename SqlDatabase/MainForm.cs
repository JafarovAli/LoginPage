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
using static SqlDatabase.MainForm;

namespace SqlDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGetAllUser_Click(object sender, EventArgs e)
        {
            List<User> list = new List<User>();
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=IWebSite;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users";
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var user = new User();
                    user.Id = dr.GetInt32(0);
                    user.Name = dr.GetString(1);
                    user.Surname = dr.GetString(2);
                    user.Email = dr.GetString(3);

                    list.Add(user);
                }
            }

            dataGridView.DataSource = list;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=IWebSite;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"exec spAddPerson @Name,@Surname,@Email";
                command.Parameters.Add(new SqlParameter("@Name", textBoxName.Text));
                command.Parameters.Add(new SqlParameter("@Surname", textBoxSurname.Text));
                command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));

                command.ExecuteNonQuery();
                MessageBox.Show("Added Sucsessfully.");
                buttonGetAllUser_Click(this, default);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this row?", "Update Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=IWebSite;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = @"Update Users set Name =@Name,Surname= @Surname,Email=@Email Where id = @id";
                    command.Parameters.Add(new SqlParameter("@Name", textBoxName.Text));
                    command.Parameters.Add(new SqlParameter("@Surname", textBoxSurname.Text));
                    command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
                    command.Parameters.Add(new SqlParameter("@id", textBoxId.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Sucsessfully.");
                }
            }
            else
            {
                MessageBox.Show("Row not Updated", "Update row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonGetAllUser_Click(this, default);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=IWebSite;Trusted_Connection=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = @"Delete from Users Where id=@id";
                    command.Parameters.Add(new SqlParameter("@Name", textBoxName.Text));
                    command.Parameters.Add(new SqlParameter("@Surname", textBoxSurname.Text));
                    command.Parameters.Add(new SqlParameter("@Email", textBoxEmail.Text));
                    command.Parameters.Add(new SqlParameter("@id", textBoxId.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete Sucsessfully.");
                }
            }
            else
            {
                MessageBox.Show("Row not deleted","Delete row",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonGetAllUser_Click(this, default);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectUser = dataGridView.SelectedRows[0].DataBoundItem as User;
            textBoxId.Text = selectUser.Id.ToString();
            textBoxName.Text = selectUser.Name.ToString();
            textBoxSurname.Text = selectUser.Surname.ToString();
            textBoxEmail.Text = selectUser.Email.ToString();
        }
    }
}
