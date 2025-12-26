using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Entities;
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
    public partial class EditUserForm : Form
    {
        private int _Id;
        private UserRepository _userRepo;
        public EditUserForm(int Id)
        {
            InitializeComponent();
            _Id = Id;
            DBConnection db = new DBConnection();
            _userRepo = new UserRepository(db);
        }
        public EditUserForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _userRepo = new UserRepository(db);
        }


        private void EditUserForm_Load(object sender, EventArgs e)
        {
            if (_Id > 0)
            {
                LoadMemberData(_Id);
                txtID.ReadOnly = false; // prevent editing ID
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }

            LoadMemberData(id);
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
                Users user = new Users
                {
                    Id = id,
                    Name = txtName.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = CMRole.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim()
                };

                if (_userRepo.UserExists(id))
                {
                    _userRepo.EditUser(user); // Call repository to update user
                    MessageBox.Show("User data updated successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No user found with this ID.");
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
                Users? user = _userRepo.GetUserById(id); // Get user from repository

                if (user != null)
                {
                    txtID.Text = user.Id.ToString();
                    txtName.Text = user.Name;
                    txtUsername.Text = user.Username;
                    txtPassword.Text = user.Password;
                    CMRole.Text = user.Role;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.Phone;
                }
                else
                {
                    MessageBox.Show("No user found with this ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user: {ex.Message}");
            }
        }
    }
}
