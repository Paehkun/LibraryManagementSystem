using LibraryManagement;
using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        private string name;
        private string username;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public AdminHomeForm(string username)
        {
            InitializeComponent();
            this.username = username;
            FetchFullNameFromDB();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {name}";
            LoadDashboardData();
            LoadBorrowedBooks();
            LoadLateReturnedBooks();
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
                        name = result.ToString();
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

                    // 🟢 Total Books Copies
                    string totalBooksQuery = "SELECT COALESCE(SUM(copiesavailable), 0) FROM books";
                    using (var cmd = new NpgsqlCommand(totalBooksQuery, conn))
                    {
                        var totalBooks = cmd.ExecuteScalar();
                        lblTotalBooksValue.Text = totalBooks.ToString();
                    }

                    // 🟢 Total Book Titles
                    string totalBookTitlesQuery = "SELECT COUNT(*) FROM books";
                    using (var cmd = new NpgsqlCommand(totalBookTitlesQuery, conn))
                    {
                        var totalTitles = cmd.ExecuteScalar();
                        lblBookRow.Text = totalTitles.ToString();
                    }

                    // 👥 Total Users (Admin + Librarian + Members)
                    string totalUsersQuery = "SELECT COUNT(*) FROM users";
                    using (var cmd = new NpgsqlCommand(totalUsersQuery, conn))
                    {
                        var totalUsers = cmd.ExecuteScalar();
                        lblTotalMembersValue.Text = totalUsers.ToString();
                    }

                    // 👥 Total Borrowed Books
                    string totalBorrowQuery = "SELECT COUNT(*) FROM borrowreturn WHERE status = 'Borrowed'";
                    using (var cmd = new NpgsqlCommand(totalBorrowQuery, conn))
                    {
                        var totalBorrow = cmd.ExecuteScalar();
                        lblBorrowedBooksValue.Text = totalBorrow.ToString();
                    }

                    // ⏰ Total Late Return Books
                    string totalLateReturnQuery = "SELECT COUNT(*) FROM borrowreturn WHERE duedate < CURRENT_DATE AND status = 'Borrowed'";
                    using (var cmd = new NpgsqlCommand(totalLateReturnQuery, conn))
                    {
                        var totalLateReturn = cmd.ExecuteScalar();
                        lblLateReturnBooksValue.Text = totalLateReturn.ToString();
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
                    u.name AS ""User Name"",
                    b.title AS ""Book Title"",
                    br.borrowdate AS ""Borrow Date"",
                    br.duedate AS ""Due Date""
                FROM borrowreturn br
                JOIN member u ON br.memberid = u.memberid
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
                    }
                }
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
                    br.borrowid AS ""Borrow ID"",
                    br.memberid AS ""Member ID"",
                    u.name AS ""User Name"",
                    b.title AS ""Book Title"",
                    br.duedate AS ""Due Date""
                FROM borrowreturn br
                JOIN member u ON br.memberid = u.memberid
                JOIN books b ON br.isbn = b.isbn
                WHERE br.duedate < CURRENT_DATE AND br.status = 'Borrowed';
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);
                        dataGridView2.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading late returned books: {ex.Message}");
            }
        }


        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BookManagementForm bookForm = new BookManagementForm(username);
            bookForm.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            MemberManagementForm userForm = new MemberManagementForm(username);
            userForm.Show();
            this.Hide();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report(username);
            reportForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
