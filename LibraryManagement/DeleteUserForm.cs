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
        public DeleteUserForm()
        {
            InitializeComponent();
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

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Check if user exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE id = @id AND is_deleted = FALSE";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", ID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("User with this ID does not exist or is already deleted.");
                            return;
                        }
                    }

                    // Confirm deletion
                    if (MessageBox.Show("Are you sure you want to delete this user?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }

                    // Mark user as deleted
                    string updateQuery = "UPDATE users SET is_deleted = TRUE WHERE id = @id";
                    using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@id", ID);
                        updateCmd.ExecuteNonQuery();
                    }
                }

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
