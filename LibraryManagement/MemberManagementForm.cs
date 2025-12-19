using LibraryManagement;
using LibraryManagementSystem.Domain.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MemberManagementForm : Form
    {
        private MemberRepository _memberRepo;
        private string username;

        public MemberManagementForm(string username)
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _memberRepo = new MemberRepository(db);
            this.username = UserSession.Username;

            StyleDataGridView();
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            FormatColumns();
        }

        private void StyleDataGridView()
        {
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMembers.ColumnHeadersHeight = 45;

            dgvMembers.RowTemplate.Height = 45;
            dgvMembers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMembers.DefaultCellStyle.BackColor = Color.White;
            dgvMembers.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgvMembers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvMembers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMembers.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);

            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241);

            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMembers.GridColor = Color.FromArgb(189, 195, 199);
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.MultiSelect = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatColumns()
        {
            if (dgvMembers.Columns.Count == 0) return;

            // Hide base fields
            string[] hideColumns = {
                "CreatedAt", "LastModified", "IsDeleted", "CreateBy", "LastModifiedBy"
            };

            foreach (var col in hideColumns)
            {
                if (dgvMembers.Columns[col] != null)
                    dgvMembers.Columns[col].Visible = false;
            }

            // Format headers
            if (dgvMembers.Columns["memberid"] != null)
            {
                dgvMembers.Columns["memberid"].HeaderText = "Member ID";
                dgvMembers.Columns["memberid"].Width = 100;
                dgvMembers.Columns["memberid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMembers.Columns["name"] != null)
            {
                dgvMembers.Columns["name"].HeaderText = "Name";
                dgvMembers.Columns["name"].Width = 250;
            }

            if (dgvMembers.Columns["email"] != null)
            {
                dgvMembers.Columns["email"].HeaderText = "Email";
                dgvMembers.Columns["email"].Width = 280;
            }

            if (dgvMembers.Columns["phone"] != null)
            {
                dgvMembers.Columns["phone"].HeaderText = "Phone";
                dgvMembers.Columns["phone"].Width = 150;
                dgvMembers.Columns["phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvMembers.Columns["address"] != null)
            {
                dgvMembers.Columns["address"].HeaderText = "Address";
                dgvMembers.Columns["address"].Width = 350;
            }

            if (dgvMembers.Columns["membershipdate"] != null)
            {
                dgvMembers.Columns["membershipdate"].HeaderText = "Member Since";
                dgvMembers.Columns["membershipdate"].Width = 150;
                dgvMembers.Columns["membershipdate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvMembers.Columns["membershipdate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvMembers.ClearSelection();
        }

        private void LoadMembers(string search = "")
        {
            DataTable dt = _memberRepo.GetAllMembers(search);
            dgvMembers.DataSource = dt;
            FormatColumns();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text.Trim());
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
                MessageBox.Show("Please select a member to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteMemberForm())
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "admin")
            {
                new AdminHomeForm(UserSession.Username).Show();
            }
            else
            {
                new LibrarianHomeForm(UserSession.Username).Show();
            }

            this.Hide();
        }
    }
}