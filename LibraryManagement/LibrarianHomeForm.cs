using LibraryManagement;
using Npgsql;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibrarianHomeForm : Form
    {
        private string name;
        private string username;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        // ✅ Constructor now safely handles username
        public LibrarianHomeForm(string username)
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username not found. Please log in again.", "Error");
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
                return;
            }

            this.username = username;
            FetchFullNameFromDB();

            lblWelcome.Text = $"Welcome, {name}";
        }

        private void FetchFullNameFromDB()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT name FROM users WHERE username = @username";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // ✅ Prevent InvalidOperationException by specifying type if needed
                        cmd.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Varchar, username);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            name = result.ToString();
                        }
                        else
                        {
                            name = "Unknown User";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching name: " + ex.Message);
                name = "Unknown User";
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string totalBooksQuery = "SELECT COALESCE(SUM(copiesavailable), 0) FROM books";
                    using (var cmd = new NpgsqlCommand(totalBooksQuery, conn))
                    {
                        lblTotalBooksValue.Text = cmd.ExecuteScalar().ToString();
                    }

                    string totalBooksRow = "SELECT COUNT(*) FROM books";
                    using (var cmd = new NpgsqlCommand(totalBooksRow, conn))
                    {
                        lblBookRow.Text = cmd.ExecuteScalar().ToString();
                    }

                    string totalMembersQuery = "SELECT COUNT(*) FROM member";
                    using (var cmd = new NpgsqlCommand(totalMembersQuery, conn))
                    {
                        lblTotalMembersValue.Text = cmd.ExecuteScalar().ToString();
                    }

                    string totalBorrowQuery = "SELECT COUNT(*) FROM borrowreturn WHERE status = 'Borrowed'";
                    using (var cmd = new NpgsqlCommand(totalBorrowQuery, conn))
                    {
                        lblBorrowedBooksValue.Text = cmd.ExecuteScalar().ToString();
                    }

                    string totalLateReturnQuery = "SELECT COUNT(*) FROM borrowreturn WHERE duedate < CURRENT_DATE AND status = 'Borrowed'";
                    using (var cmd = new NpgsqlCommand(totalLateReturnQuery, conn))
                    {
                        lblLateReturnBooksValue.Text = cmd.ExecuteScalar().ToString();
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
                            br.isbn AS ""Book ISBN"",
                            b.title AS ""Book Title"",
                            br.borrowdate AS ""Borrow Date"",
                            br.duedate AS ""Due Date"",
                            br.status AS ""Status""
                        FROM borrowreturn br
                        JOIN member m ON br.memberid = m.memberid
                        JOIN books b ON br.isbn = b.isbn
                        ORDER BY br.borrowdate DESC;
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;

                        dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.RowTemplate.Height = 40;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.MultiSelect = false;
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
                            borrowid AS ""Borrow ID"",
                            memberid AS ""Member ID"",
                            name AS ""Member Name"",
                            isbn AS ""Book ISBN"",
                            title AS ""Book Title"",
                            borrowdate AS ""Borrow Date"",
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

                        dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                        dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView2.RowTemplate.Height = 40;
                        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView2.MultiSelect = false;
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
        }

        // ✅ Pass username to every new form
        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            BookManagementForm bookManagementForm = new BookManagementForm(username);
            bookManagementForm.Show();
            this.Hide();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            borrowANDreturn borrowAndReturn = new borrowANDreturn(username);
            borrowAndReturn.Show();
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
            Report reportForm = new Report(username); // ✅ Pass username
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
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
