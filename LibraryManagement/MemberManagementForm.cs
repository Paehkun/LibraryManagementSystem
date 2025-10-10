using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace LibraryManagementSystem
{
    public partial class MemberManagementForm : Form
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public MemberManagementForm()
        {
            InitializeComponent();
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        // 🧭 Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ➕ Add Member
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string address = txtAddress.Text.Trim();
                DateTime membershipDate = dtpMembershipDate.Value;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter member name.");
                    return;
                }

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"INSERT INTO member (name, email, phone, address, membershipdate)
                                     VALUES (@n, @e, @p, @a, @d)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@p", phone);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.Parameters.AddWithValue("@d", membershipDate);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Member added successfully!");
                ClearInputs();
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}");
            }
        }

        // ✏️ Edit Member
        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to edit.");
                return;
            }

            var row = dgvMembers.SelectedRows[0];
            int memberId = Convert.ToInt32(row.Cells["Member ID"].Value);

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime membershipDate = dtpMembershipDate.Value;

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"UPDATE member SET name=@n, email=@e, phone=@p, address=@a, membershipdate=@d WHERE memberid=@memberid";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@p", phone);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.Parameters.AddWithValue("@d", membershipDate);
                        cmd.Parameters.AddWithValue("@memberid", memberId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Member updated successfully!");
                ClearInputs();
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing member: {ex.Message}");
            }
        }

        // ❌ Delete Member
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            int memberId = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["Member ID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM member WHERE memberid = @memberid";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberid", memberId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Member deleted successfully!");
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}");
            }
        }

        // 🔍 Search Members
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text.Trim();

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                        SELECT memberid AS ""Member ID"", name AS ""Name"", email AS ""Email"", 
                               phone AS ""Phone"", address AS ""Address"", membershipdate AS ""Membership Date""
                        FROM member
                        WHERE CAST(memberid AS TEXT) ILIKE @q OR name ILIKE @q OR email ILIKE @q
                        ORDER BY memberid";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@q", "%" + s + "%");
                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            var table = new DataTable();
                            da.Fill(table);
                            dgvMembers.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
            }
        }

        // 📋 Load All Members
        private void LoadMembers()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string q = @"SELECT memberid AS ""Member ID"", name AS ""Name"", email AS ""Email"",
                                        phone AS ""Phone"", address AS ""Address"", membershipdate AS ""Membership Date""
                                 FROM member ORDER BY memberid";
                    using (var cmd = new NpgsqlCommand(q, conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvMembers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}");
            }
        }

        // 🧼 Helper - Clear Inputs
        private void ClearInputs()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpMembershipDate.Value = DateTime.Now;
        }
    }
}
