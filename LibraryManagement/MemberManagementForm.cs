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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm librarianHome = new LibrarianHomeForm("Librarian");
            librarianHome.Show();
        }

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

        private void LoadMembers()
        {
            flowMembers.Controls.Clear();

            DataTable members = DatabaseHelper.GetAllMembers();
            foreach (DataRow row in members.Rows)
            {
                // Create a panel for each member card
                Panel card = new Panel();
                card.Size = new Size(1300, 80);
                card.BackColor = Color.White;
                card.Margin = new Padding(10);
                card.Padding = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;

                // Rounded corners (optional)
                card.Paint += (s, e) =>
                {
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int radius = 20;
                    Rectangle rect = card.ClientRectangle;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    card.Region = new Region(path);
                };

                // ✅ Get values from DataRow
                int memberId = Convert.ToInt32(row["memberid"]);
                string memberName = row["name"].ToString();
                string memberPhone = row["phone"].ToString();

                // Name label
                Label lblName = new Label();
                lblName.Text = memberName;
                lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblName.Location = new Point(80, 20);
                lblName.AutoSize = true;

                // ID label
                Label lblID = new Label();
                lblID.Text = $"#{memberId}";
                lblID.Font = new Font("Segoe UI", 11);
                lblID.Location = new Point(300, 25);
                lblID.AutoSize = true;

                // Phone label
                Label lblPhone = new Label();
                lblPhone.Text = memberPhone;
                lblPhone.Font = new Font("Segoe UI", 11);
                lblPhone.Location = new Point(450, 25);
                lblPhone.AutoSize = true;

                // Edit button
                Button btnEdit = new Button();
                btnEdit.Text = "✏️";
                btnEdit.Size = new Size(40, 40);
                btnEdit.Location = new Point(1150, 20);
                btnEdit.Click += (s, e) => EditMember(memberId);

                // Delete button
                Button btnDelete = new Button();
                btnDelete.Text = "🗑️";
                btnDelete.Size = new Size(40, 40);
                btnDelete.Location = new Point(1200, 20);
                btnDelete.Click += (s, e) => DeleteMember(memberId);

                // Add controls to card
                card.Controls.Add(lblName);
                card.Controls.Add(lblID);
                card.Controls.Add(lblPhone);
                card.Controls.Add(btnEdit);
                card.Controls.Add(btnDelete);

                // Add card to flow layout panel
                flowMembers.Controls.Add(card);
            }
        }


        private void EditMember(int memberId)
        {
            // You can open your EditMemberForm with the selected ID here
            using (EditMemberForm editForm = new EditMemberForm())
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers(); // Refresh after edit
                }
            }
        }

        private void DeleteMember(int memberId)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DatabaseHelper.DeleteMember(memberId); // make sure you have this method
                LoadMembers();
            }
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

        private void dgvMembers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
