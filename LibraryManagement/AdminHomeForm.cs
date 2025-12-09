using LibraryManagement;
using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public AdminHomeForm(string username = "")
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _bookRepo = new BookRepository(db);
            _userRepo = new UserRepository(db);
            this.username = UserSession.Username;          // ✅ assign the parameter to the field
            FetchFullNameFromDB();
            lblWelcome.Text = $"Welcome, {name}";
            SetupSidebarAnimation();
            SetupSidebarButtons();
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
                // Expand
                if (leftPanel.Width < 250)
                {
                    leftPanel.Width += 10;

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
                // Collapse
                if (leftPanel.Width > 70)
                {
                    leftPanel.Width -= 10;
                    lblWelcome.Visible = false;
                }
                else
                {
                    sidebarTimer.Stop();
                }
            }

            UpdateSidebarButtonText(); // icon-only or full text
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
            int btnWidth = 200;
            int btnHeight = 45;
            int startY = 80;
            int spacing = 55;

            Button[] buttons =
            {
        btnBookManagement,
        btnMemberRecords,
        btnUserManagement,
        btnBookCatalog,
        btnReports,
        //btnBorrowReturn,
        btnLogout
    };

            string[] texts =
            {
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
                b.Location = new Point(20, startY + (i * spacing));
                b.TextAlign = ContentAlignment.MiddleLeft;

                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = Color.White;
                b.ForeColor = Color.Black;
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            }
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
            lblBookRow.Text = stats.TotalBookRows.ToString();
            lblTotalMembersValue.Text = stats.TotalMembers.ToString();
            lblBorrowedBooksValue.Text = stats.TotalBorrowedBooks.ToString();
            lblLateReturnBooksValue.Text = stats.TotalLateReturnedBooks.ToString();
            lblLateReturnBooksValue.BringToFront();
        }
        private void LoadBorrowedBooks()
        {
            var loadborrowedbooks = _bookRepo.LoadBorrowedBooks();

            dataGridView1.DataSource = loadborrowedbooks;
            // Hide BaseClass 
            string[] baseFields = { "CreatedAt", "LastModified", "IsDeleted", "CreateBy", "LastModifiedBy", "Image", "Id" };
            foreach (var field in baseFields)
            {
                if (dataGridView1.Columns[field] != null)
                    dataGridView1.Columns[field].Visible = false;
            }
        }

        private void LoadLateReturnedBooks()
        {
            var lateBooks = _bookRepo.LoadLateReturnedBooks();

            dataGridView2.DataSource = lateBooks;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            LoadLateReturnedBooks();
            LoadBorrowedBooks();
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