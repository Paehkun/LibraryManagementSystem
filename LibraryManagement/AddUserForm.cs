using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void lblMembershipDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string username = txtEmail.Text.Trim();
            string password = txtPhone.Text.Trim();
            string role = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
        string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"INSERT INTO users (name, username, password, role)
                                     VALUES (@n, @u, @p, @r)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@r", role);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
