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
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public LibrarianHomeForm(string username)
        {
            InitializeComponent();
            this.username = username;          // ✅ assign the parameter to the field
            FetchFullNameFromDB();
            lblWelcome.Text = $"Welcome, {name}";
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}");
            }
        }

        private void LibrarianHomeForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            BookManagementForm bookManagementForm = new BookManagementForm(name);
            bookManagementForm.Show();

            this.Hide();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Borrow/Return Page");
        }

        private void btnMemberRecords_Click(object sender, EventArgs e)
        {
            MemberManagementForm memberManagementForm = new MemberManagementForm();
            memberManagementForm.Show();

            this.Hide();
        }

        private void btnBookCatalog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Book Catalog Page");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Reports Page");
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
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalMembers_Click(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalBooks_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalBooksValue_Click(object sender, EventArgs e)
        {

        }
    }
}
