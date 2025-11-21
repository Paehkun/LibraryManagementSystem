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
    public partial class EditUserForm : Form
    {
        private int _Id;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        public EditUserForm(int Id)
        {
            InitializeComponent();
            _Id = Id;
        }
        public EditUserForm()
        {
            InitializeComponent();
        }


        private void EditUserForm_Load(object sender, EventArgs e)
        {
            if (_Id > 0)
            {
                LoadMemberData(_Id);
                txtID.ReadOnly = false; // prevent editing ID
            }
        }

        //private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT id, name, username, password, role, email, phone FROM users 
                                     WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtID.Text = reader["id"].ToString();
                                txtName.Text = reader["name"].ToString();
                                txtUsername.Text = reader["username"].ToString();
                                txtPassword.Text = reader["password"].ToString();
                                CMRole.Text = reader["role"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhone.Text = reader["phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No user found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text.Trim(), out int id) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(CMRole.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE users 
                                           SET name = @name, 
                                               username = @username, 
                                               password = @password, 
                                               role = @role,
                                               email = @email,
                                               phone = @phone
                                           WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", CMRole.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("User data updated successfully!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No user found with this ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadMemberData(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT id, name, username, password, role, email, phone
                                 FROM users 
                                 WHERE id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtID.Text = reader["id"].ToString();
                                txtName.Text = reader["name"].ToString();
                                txtUsername.Text = reader["username"].ToString();
                                txtPassword.Text = reader["password"].ToString();
                                CMRole.Text = reader["role"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhone.Text = reader["phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No user found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user: {ex.Message}");
            }
        }
    }
}
