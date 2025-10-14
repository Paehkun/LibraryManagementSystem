using LibraryManagement;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

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
            this.Hide();
            LibrarianHomeForm librarianHome = new LibrarianHomeForm("Librarian");
            librarianHome.Show();
        }

        // ➕ Add Member
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            using (MemberForm memberForm = new MemberForm())
            {
                if (memberForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers();
                }
            }
        }

        // ✏️ Edit Member
        private void btnEditMember_Click(object sender, EventArgs e)
        {
            using (EditMemberForm editmemberForm = new EditMemberForm())
            {
                if (editmemberForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers(); // Refresh the table after editing
                }
            }
        }

        // ❌ Delete Member
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            using (DeleteMemberForm deletememberForm = new DeleteMemberForm())
            {
                if (deletememberForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers(); // refresh the table after deleting a member
                }
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

            dgvMembers.DataSource = DatabaseHelper.GetAllMembers();
        }

        // 🧼 Helper - Clear Inputs
        //private void ClearInputs()
        //{
        //    //txtName.Clear();
        //    //txtEmail.Clear();
        //    //txtPhone.Clear();
        //    //txtAddress.Clear();
        //    //dtpMembershipDate.Value = DateTime.Now;
        //}

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
