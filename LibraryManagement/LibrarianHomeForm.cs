using LibraryManagement;
using Npgsql;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class LibrarianHomeForm : Form
    {
        private string name;
        private string username;
        private bool sidebarExpanded = true;
        private System.Windows.Forms.Timer sidebarTimer;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public LibrarianHomeForm(string username = "")
        {
            InitializeComponent();

            this.username = UserSession.Username;

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
                btnBookCatalog.Text = "📚";
                btnReports.Text = "📊";
                btnBorrowReturn.Text = "🔁";
                btnLogout.Text = "🚪";
            }
            else
            {
                btnBookManagement.Text = "📖 Book Management";
                btnMemberRecords.Text = "👥 Member Management";
                btnBookCatalog.Text = "📚 Catalog";
                btnReports.Text = "📊 Reports";
                btnBorrowReturn.Text = "🔁 Borrow And Return";
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
        btnBookCatalog,
        btnReports,
        btnBorrowReturn,
        btnLogout
    };

            string[] texts =
            {
        "📖 Book Management",
        "👥 Member Management",
        "📚 Catalog",
        "📊 Reports",
        "🔁 Borrow And Return",
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
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT name FROM users WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        name = result.ToString();   // ✅ store full name
                    }
                }
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // 🟢 Total Books (based on total copies available)
                    string totalBooksQuery = "SELECT COALESCE(SUM(copiesavailable), 0) FROM books";
                    using (var cmd = new NpgsqlCommand(totalBooksQuery, conn))
                    {
                        var totalBooks = cmd.ExecuteScalar();
                        lblTotalBooksValue.Text = totalBooks.ToString();
                    }

                    // 👥 Total Books Row
                    string totalBooksRow = "SELECT COUNT(*) FROM books";
                    using (var cmd = new NpgsqlCommand(totalBooksRow, conn))
                    {
                        var totalBookRow = cmd.ExecuteScalar();
                        lblBookRow.Text = totalBookRow.ToString();
                    }


                    // 👥 Total Members
                    string totalMembersQuery = "SELECT COUNT(*) FROM member";
                    using (var cmd = new NpgsqlCommand(totalMembersQuery, conn))
                    {
                        var totalMembers = cmd.ExecuteScalar();
                        lblTotalMembersValue.Text = totalMembers.ToString();
                    }

                    string totalBorrowQuery = "SELECT COUNT(*) FROM borrowreturn WHERE status = 'Borrowed'";
                    using (var cmd = new NpgsqlCommand(totalBorrowQuery, conn))
                    {
                        var totalBorrow = cmd.ExecuteScalar();
                        lblBorrowedBooksValue.Text = totalBorrow.ToString();
                    }

                    string totalLateReturnQuery = "SELECT COUNT(*) FROM borrowreturn WHERE duedate < CURRENT_DATE AND status = 'Borrowed'";
                    using (var cmd = new NpgsqlCommand(totalLateReturnQuery, conn))
                    {
                        var totalLateReturn = cmd.ExecuteScalar();
                        lblLateReturnBooksValue.Text = totalLateReturn.ToString();
                        lblLateReturnBooksValue.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}");
            }
        }
        private void LoadBorrowedBooks()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    br.borrowid AS ""Borrow ID"",
                    br.memberid AS ""Member ID"",
                    m.name AS ""Member Name"",
                    
                    b.title AS ""Book Title"",
                    br.borrowdate AS ""Borrow Date"",
                    br.duedate AS ""Due Date""
                FROM borrowreturn br
                JOIN member m ON br.memberid = m.memberid
                JOIN books b ON br.isbn = b.isbn
                WHERE br.status = 'Borrowed'
                ORDER BY br.borrowdate DESC;
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Rows.Count == 1)
                        {
                            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
                            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                            dataGridView1.BackgroundColor = Color.LightGray;
                        }
                        else
                        {
                            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                            dataGridView1.BackgroundColor = Color.White;
                        }

                    }
                }

                // Optional: Styling like your other forms
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 40;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowed books: {ex.Message}");
            }
        }

        private void LoadLateReturnedBooks()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    borrowid AS ""Borrow ID"",
                    memberid AS ""Member ID"",
                    name AS ""Member Name"",                    
                    title AS ""Book Title"",
                    duedate AS ""Due Date""
                FROM borrowreturn
                WHERE duedate < CURRENT_DATE AND status = 'Borrowed';
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);
                        dataGridView2.DataSource = dt;
                        if (dataGridView1.Rows.Count == 1)
                        {
                            dataGridView2.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
                            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                            dataGridView2.BackgroundColor = Color.LightGray;
                        }
                        else
                        {
                            dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                            dataGridView2.BackgroundColor = Color.White;
                        }

                        dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                        dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView2.RowTemplate.Height = 40;
                        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView2.MultiSelect = false;
                        dataGridView2.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading late returned books: {ex.Message}");
            }
        }

        private void LibrarianHomeForm_Load(object sender, EventArgs e)
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

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            borrowANDreturn BorrowandReturn = new borrowANDreturn(username);
            BorrowandReturn.Show();

            this.Hide();
        }

        private void btnMemberRecords_Click(object sender, EventArgs e)
        {
            MemberManagementForm memberManagementForm = new MemberManagementForm(username);
            memberManagementForm.Show();

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