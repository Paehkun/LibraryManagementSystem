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
    public partial class EditMemberForm : Form
    {
        private int _memberId;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        public EditMemberForm(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
        }
        public EditMemberForm()
        {
            InitializeComponent();
        }


        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            if (_memberId > 0)
            {
                LoadMemberData(_memberId);
                txtMemberID.ReadOnly = false; // prevent editing ID
            }
        }
        private void lblMembershipDate_Click(object sender, EventArgs e)
        {

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberID.Text.Trim(), out int memberid))
            {
                MessageBox.Show("Please enter a valid Member ID.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT memberid, name, email, phone, address, membershipdate FROM member 
                                     WHERE memberid = @memberid";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberid", memberid);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMemberID.Text = reader["memberid"].ToString();
                                txtName.Text = reader["name"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhone.Text = reader["phone"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                DateTime membershipDate = Convert.ToDateTime(reader["membershipdate"]);
                                dtpMembershipDate.Text = membershipDate.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                MessageBox.Show("No member found with this ID.");
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
            if (!int.TryParse(txtMemberID.Text.Trim(), out int memberid) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE member 
                                           SET name = @name, 
                                               email = @email, 
                                               phone = @phone, 
                                               address = @address 
                                           WHERE memberid = @memberid";
                    using (var cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@memberid", memberid);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Member data updated successfully!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No member found with this ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadMemberData(int memberid)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT memberid, name, email, phone, address, membershipdate 
                                 FROM member 
                                 WHERE memberid = @memberid";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberid", memberid);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMemberID.Text = reader["memberid"].ToString();
                                txtName.Text = reader["name"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPhone.Text = reader["phone"].ToString();
                                txtAddress.Text = reader["address"].ToString();
                                dtpMembershipDate.Value = Convert.ToDateTime(reader["membershipdate"]);
                            }
                            else
                            {
                                MessageBox.Show("No member found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member: {ex.Message}");
            }
        }
    }
}
