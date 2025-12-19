using LibraryManagement;
using LibraryManagementSystem.Domain.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        private string name;
        private string username;
        private bool sidebarExpanded = true;
        private System.Windows.Forms.Timer sidebarTimer;
        private BookRepository _bookRepo;
        private UserRepository _userRepo;

        public AdminHomeForm(string username = "")
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _bookRepo = new BookRepository(db);
            _userRepo = new UserRepository(db);

            this.username = UserSession.Username;

            FetchFullNameFromDB();
            lblWelcome.Text = $"Welcome, {name}";

            SetupSidebarAnimation();
            SetupSidebarButtons();
            StyleDataGridViews();
        }

        private void BtnToggleSidebar_Click(object sender, EventArgs e)
        {
            sidebarExpanded = !sidebarExpanded;
            sidebarTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                if (leftPanel.Width < 250)
                {
                    leftPanel.Width += 15;
                    if (leftPanel.Width > 150)
                        lblWelcome.Visible = true;
                }
                else
                {
                    sidebarTimer.Stop();
                }
            }
            else
            {
                if (leftPanel.Width > 70)
                {
                    leftPanel.Width -= 15;
                    lblWelcome.Visible = false;
                }
                else
                {
                    sidebarTimer.Stop();
                }
            }

            UpdateSidebarButtonText();
        }

        private void UpdateSidebarButtonText()
        {
            if (leftPanel.Width < 100)
            {
                btnBookManagement.Text = "📖";
                btnMemberRecords.Text = "👥";
                btnUserManagement.Text = "👥";
                btnBookCatalog.Text = "📚";
                btnReports.Text = "📊";
                //btnBorrowReturn.Text = "🔁";
                btnLogout.Text = "🚪";
            }
            else
            {
                btnBookManagement.Text = "📖 Book Management";
                btnMemberRecords.Text = "👥 Member Management";
                btnUserManagement.Text = "👥 User Management";
                btnBookCatalog.Text = "📚 Catalog";
                btnReports.Text = "📊 Reports";
                //btnBorrowReturn.Text = "🔁 Borrow And Return";
                btnLogout.Text = "🚪 Logout";
            }
        }

        private void SetupSidebarAnimation()
        {
            sidebarTimer = new System.Windows.Forms.Timer();
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += SidebarTimer_Tick;
        }

        private void SetupSidebarButtons()
        {
            int btnWidth = 220;
            int btnHeight = 50;
            int startY = 100;
            int spacing = 10;

            Button[] buttons = {
                btnBookManagement,
                btnMemberRecords,
                btnUserManagement,
                btnBookCatalog,
                btnReports,
                btnLogout
            };

            string[] texts = {
                "📖 Book Management",
                "👥 Member Management",
                "👥 User Management",
                "📚 Catalog",
                "📊 Reports",
                "🚪 Logout"
            };

            for (int i = 0; i < buttons.Length; i++)
            {
                var b = buttons[i];
                b.Text = texts[i];
                b.Size = new Size(btnWidth, btnHeight);
                b.Location = new Point(15, startY + (i * (btnHeight + spacing)));
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.Padding = new Padding(15, 0, 0, 0);
                b.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.FromArgb(41, 128, 185);
                b.ForeColor = Color.White;
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
                b.Cursor = Cursors.Hand;
            }
        }

        private void StyleDataGridViews()
        {
            StyleDataGridView(dataGridView1, Color.FromArgb(52, 152, 219), Color.FromArgb(236, 240, 241));
            StyleDataGridView(dataGridView2, Color.FromArgb(231, 76, 60), Color.FromArgb(255, 235, 238));
        }

        private void StyleDataGridView(DataGridView dgv, Color headerColor, Color alternatingColor)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 45;

            dgv.RowTemplate.Height = 45;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = alternatingColor;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(189, 195, 199);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.ClearSelection();
        }

        private void FetchFullNameFromDB()
        {
            var user = _userRepo.GetUserByUsername(username);
            if (user != null)
            {
                name = user.Name;
                lblWelcome.Text = $"Welcome, {name}";
            }
            else
            {
                lblWelcome.Text = "Welcome, User";
            }
        }

        private void LoadDashboardData()
        {
            var stats = _bookRepo.GetDashboardStats();

            lblTotalBooksValue.Text = stats.TotalBooks.ToString();
            lblBookRowValue.Text = stats.TotalBookRows.ToString();
            lblTotalMembersValue.Text = stats.TotalMembers.ToString();
            lblBorrowedBooksValue.Text = stats.TotalBorrowedBooks.ToString();
            lblLateReturnBooksValue.Text = stats.TotalLateReturnedBooks.ToString();
        }

        private void LoadBorrowedBooks()
        {
            var borrowedBooks = _bookRepo.LoadBorrowedBooks();
            dataGridView1.DataSource = borrowedBooks;

            string[] hideColumns = {
                "CreatedAt", "LastModified", "IsDeleted", "CreateBy",
                "LastModifiedBy", "Image", "Id", "ISBN", "Memberid",
                "Phone", "ReturnDate"
            };

            foreach (var col in hideColumns)
            {
                if (dataGridView1.Columns[col] != null)
                    dataGridView1.Columns[col].Visible = false;
            }

            dataGridView1.ClearSelection();
        }

        private void LoadLateReturnedBooks()
        {
            var lateBooks = _bookRepo.LoadLateReturnedBooks();
            dataGridView2.DataSource = lateBooks;

            string[] hideColumns = {
                "CreatedAt", "LastModified", "IsDeleted", "CreateBy",
                "LastModifiedBy", "Image", "Id", "ISBN", "Memberid",
                "Phone", "ReturnDate"
            };

            foreach (var col in hideColumns)
            {
                if (dataGridView2.Columns[col] != null)
                    dataGridView2.Columns[col].Visible = false;
            }

            dataGridView2.ClearSelection();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadBorrowedBooks();
            LoadLateReturnedBooks();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            BookManagementForm bookManagementForm = new BookManagementForm(username);
            bookManagementForm.Show();
            this.Hide();
        }

        private void btnMemberRecords_Click(object sender, EventArgs e)
        {
            MemberManagementForm memberManagementForm = new MemberManagementForm(username);
            memberManagementForm.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(username);
            userManagementForm.Show();
            this.Hide();
        }

        private void btnBookCatalog_Click(object sender, EventArgs e)
        {
            BookCatalogForm bookCatalogForm = new BookCatalogForm(username);
            bookCatalogForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report(username);
            reportForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UserSession.Username = null;
                UserSession.Role = null;
                new LoginForm().Show();
                this.Hide();
            }
        }
    }
}