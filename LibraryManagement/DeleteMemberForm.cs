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
    public partial class DeleteMemberForm : Form
    {
        public DeleteMemberForm()
        {
            InitializeComponent();
        }

        private void DeleteMemberForm_Load(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmember.Text.Trim(), out int memberID))
            {
                MessageBox.Show("Invalid Member ID. Please enter a number.");
                return;
            }

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Check if member exists
                    string checkQuery = "SELECT COUNT(*) FROM member WHERE memberid = @member";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@member", memberID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Member with this ID does not exist.");
                            return;
                        }
                    }

                    // Confirm delete
                    if (MessageBox.Show("Are you sure you want to delete this member?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }

                    // Soft delete: update is_deleted column
                    string deleteQuery = "UPDATE member SET is_deleted = TRUE WHERE memberid = @member";
                    using (var deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@member", memberID);
                        deleteCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Member deleted successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}");
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
