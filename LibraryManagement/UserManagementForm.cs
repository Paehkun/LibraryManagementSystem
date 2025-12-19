using LibraryManagement;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class UserManagementForm : Form
    {
        private string username;

        public UserManagementForm(string username)
        {
            InitializeComponent();
            this.username = username;

            StyleDataGridView();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            FormatColumns();
        }

        private void StyleDataGridView()
        {
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.ColumnHeadersHeight = 45;

            dgvUsers.RowTemplate.Height = 45;
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvUsers.DefaultCellStyle.BackColor = Color.White;
            dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsers.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);

            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241);

            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.GridColor = Color.FromArgb(189, 195, 199);
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.MultiSelect = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatColumns()
        {
            if (dgvUsers.Columns.Count == 0) return;

            // Format headers and widths
            if (dgvUsers.Columns["id"] != null)
            {
                dgvUsers.Columns["id"].HeaderText = "ID";
                dgvUsers.Columns["id"].Width = 80;
                dgvUsers.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvUsers.Columns["name"] != null)
            {
                dgvUsers.Columns["name"].HeaderText = "Name";
                dgvUsers.Columns["name"].Width = 200;
            }

            if (dgvUsers.Columns["username"] != null)
            {
                dgvUsers.Columns["username"].HeaderText = "Username";
                dgvUsers.Columns["username"].Width = 180;
            }

            if (dgvUsers.Columns["role"] != null)
            {
                dgvUsers.Columns["role"].HeaderText = "Role";
                dgvUsers.Columns["role"].Width = 120;
                dgvUsers.Columns["role"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvUsers.Columns["email"] != null)
            {
                dgvUsers.Columns["email"].HeaderText = "Email";
                dgvUsers.Columns["email"].Width = 250;
            }

            if (dgvUsers.Columns["phone"] != null)
            {
                dgvUsers.Columns["phone"].HeaderText = "Phone";
                dgvUsers.Columns["phone"].Width = 150;
                dgvUsers.Columns["phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUsers.ClearSelection();
        }

        private void LoadUsers(string search = "")
        {
            DataTable dt = DatabaseHelper.GetAllUsers(search);
            dgvUsers.DataSource = dt;
            FormatColumns();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (AddUserForm addUserForm = new AddUserForm())
            {
                if (addUserForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["id"].Value);
                using (EditUserForm editUserForm = new EditUserForm(userId))
                {
                    if (editUserForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteUserForm())
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeForm home = new AdminHomeForm(username);
            home.Show();
        }
    }
}