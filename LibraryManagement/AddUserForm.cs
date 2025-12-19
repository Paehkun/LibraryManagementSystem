using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Repository;
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
        private UserRepository _userRepo;
        public AddUserForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _userRepo = new UserRepository(db);
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
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            try
            {
                var userRepository = new UserRepository(new DBConnection());
                var newUser = new Users
                {
                    Name = name,
                    Username = username,
                    Password = password,
                    Role = role,
                    Email = email,
                    Phone = phone
                };

                userRepository.AddUser(newUser);
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
