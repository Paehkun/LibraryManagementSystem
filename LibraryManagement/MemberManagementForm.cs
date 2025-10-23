using LibraryManagement;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MemberManagementForm : Form
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public MemberManagementForm()
        {
            InitializeComponent();
            dgvMembers.CellClick += dgvMembers_CellClick;
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
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
            if (dgvMembers.CurrentRow != null)
            {
                int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["memberid"].Value);
                using (EditMemberForm editMemberForm = new EditMemberForm(memberId))
                {
                    if (editMemberForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMembers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to edit.");
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["memberid"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this member?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteMember(memberId);
                    LoadMembers();
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text.Trim());
        }

        // ✅ Style and base setup for DataGridView
        private void SetupDataGridView()
        {
            dgvMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMembers.DefaultCellStyle.ForeColor = Color.Black;
            dgvMembers.DefaultCellStyle.BackColor = Color.White;
            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.ColumnHeadersVisible = true;
        }

        private void LoadMembers(string search = "")
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        SELECT memberid, name, phone, email, address, membershipdate
                        FROM member
                        WHERE (@search = '' 
                            OR CAST(memberid AS TEXT) ILIKE @q 
                            OR name ILIKE @q 
                            OR email ILIKE @q)
                        ORDER BY memberid;";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                        cmd.Parameters.AddWithValue("@q", "%" + search + "%");

                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvMembers.AutoGenerateColumns = false;
                            dgvMembers.Columns.Clear();

                            // ✅ Add columns manually (headers will show)
                            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn()
                            {
                                Name = "memberid",
                                HeaderText = "Member ID",
                                DataPropertyName = "memberid",
                                ReadOnly = true
                            });
                            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn()
                            {
                                Name = "name",
                                HeaderText = "Name",
                                DataPropertyName = "name"
                            });
                            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn()
                            {
                                Name = "phone",
                                HeaderText = "Phone",
                                DataPropertyName = "phone"
                            });
                            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn()
                            {
                                Name = "email",
                                HeaderText = "Email",
                                DataPropertyName = "email"
                            });
                            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn()
                            {
                                Name = "address",
                                HeaderText = "Address",
                                DataPropertyName = "address"
                            });
                            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn()
                            {
                                Name = "membershipdate",
                                HeaderText = "Member Since",
                                DataPropertyName = "membershipdate"
                            });
                            Console.WriteLine("Columns in DataTable: " + string.Join(", ", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));

                            // ✅ Bind data
                            dgvMembers.DataSource = dt;

                            // ✅ Add action buttons (Edit/Delete)
                            AddActionButtons();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}");
            }
        }

        private void AddActionButtons()
        {
            // Remove existing buttons first
            if (dgvMembers.Columns.Contains("Edit")) dgvMembers.Columns.Remove("Edit");
            if (dgvMembers.Columns.Contains("Delete")) dgvMembers.Columns.Remove("Delete");

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn()
            {
                HeaderText = "Edit",
                Name = "Edit",
                Text = "✏️ Edit",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = {
                    BackColor = Color.FromArgb(235, 247, 255),
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.FromArgb(210, 230, 255)
                },
                FlatStyle = FlatStyle.Flat,
                Width = 80
            };
            dgvMembers.Columns.Add(editBtn);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn()
            {
                HeaderText = "Delete",
                Name = "Delete",
                Text = "🗑️ Delete",
                UseColumnTextForButtonValue = true,
                DefaultCellStyle = {
                    BackColor = Color.FromArgb(255, 240, 240),
                    ForeColor = Color.Red,
                    SelectionBackColor = Color.FromArgb(255, 220, 220)
                },
                FlatStyle = FlatStyle.Flat,
                Width = 90
            };
            dgvMembers.Columns.Add(deleteBtn);
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string col = dgvMembers.Columns[e.ColumnIndex].Name;
                if (col == "Edit") btnEditMember_Click(sender, e);
                else if (col == "Delete") btnDeleteMember_Click(sender, e);
            }
        }
    }
}
