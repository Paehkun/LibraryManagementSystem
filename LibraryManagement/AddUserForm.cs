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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = comboBox1.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
        string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
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
                    string query = @"INSERT INTO users (name, username, password, role, email, phone)
                                     VALUES (@name, @username, @password, @role, @Email, @Phone)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
