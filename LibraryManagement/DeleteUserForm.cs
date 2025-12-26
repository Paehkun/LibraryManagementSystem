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
    public partial class DeleteUserForm : Form
    {
        private UserRepository _userRepo;
        public DeleteUserForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _userRepo = new UserRepository(db);
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmember.Text.Trim(), out int ID))
            {
                MessageBox.Show("Invalid User ID. Please enter a number.");
                return;
            }

            try
            {
                if (!_userRepo.UserExists(ID))
                {
                    MessageBox.Show("User with this ID does not exist or is already deleted.");
                    return;
                }

                if (MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                _userRepo.SoftDeleteUser(ID);

                MessageBox.Show("User deleted successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmember_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
