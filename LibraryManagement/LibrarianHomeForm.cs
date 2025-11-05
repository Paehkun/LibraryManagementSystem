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
            BookManagementForm bookManagementForm = new BookManagementForm(name);
            bookManagementForm.Show();

            this.Hide();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            borrowANDreturn BorrowandReturn = new borrowANDreturn();
            BorrowandReturn.Show();

            this.Hide();
        }

        private void btnMemberRecords_Click(object sender, EventArgs e)
        {
            MemberManagementForm memberManagementForm = new MemberManagementForm();
            memberManagementForm.Show();

            this.Hide();
        }

        private void btnBookCatalog_Click(object sender, EventArgs e)
        {
            BookCatalogForm bookCatalogForm = new BookCatalogForm();
            bookCatalogForm.Show();
            this.Hide();
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
        
    }
}
