﻿using LibraryManagement;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        // PostgreSQL connection string
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT role FROM users WHERE username = @user AND password = @pass";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        var roleObj = cmd.ExecuteScalar();

                        if (roleObj == null)
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string userRole = roleObj.ToString().ToLower();

                        this.Hide(); // Hide login form

                        Form nextForm;

                        if (userRole == "admin")
                        {
                            nextForm = new AdminHomeForm(username);
                        }
                        else if (userRole == "librarian")
                        {
                            nextForm = new LibrarianHomeForm(username);
                        }
                        else
                        {
                            MessageBox.Show("Unknown role: " + userRole);
                            return;
                        }

                        // When the next form closes, close the login form too
                        nextForm.FormClosed += (s, args) => this.Close();
                        nextForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: Initialize UI, placeholder text, etc.
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
