using LibraryManagement;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookManagementForm : Form
    {
        private string username;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        public BookManagementForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            AdjustColumnWidths();
            foreach (DataGridViewColumn col in dgvBooks.Columns)
            {
                if (!string.IsNullOrEmpty(col.HeaderText))
                {
                    col.HeaderText = char.ToUpper(col.HeaderText[0]) + col.HeaderText.Substring(1);
                    col.HeaderCell.Style.Font = new Font(dgvBooks.Font, FontStyle.Bold);
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (AddBookForm addBookForm = new AddBookForm())
            {
                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();// refresh the table after adding a book
                }
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            using (EditBookForm editForm = new EditBookForm())
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks(); // Refresh the table after editing
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteBookForm())
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks(); // Refresh the table after deletion
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm librarianHome = new LibrarianHomeForm("Librarian");
            librarianHome.Show();
        }
        private void LoadBooks()
        {
            dgvBooks.DataSource = DatabaseHelper.GetAllBooks();
        }
        private void AdjustColumnWidths()
        {
            // Set specific widths for each column
            dgvBooks.Columns[0].Width = 30;   // Book ID
            dgvBooks.Columns[1].Width = 150;  // Title
            dgvBooks.Columns[2].Width = 90;  // Author
            dgvBooks.Columns[3].Width = 70;  // Isbn
            dgvBooks.Columns[4].Width = 70;   //Category
            dgvBooks.Columns[5].Width = 80;  // Publisher
            dgvBooks.Columns[6].Width = 40;  //Year 
            dgvBooks.Columns[7].Width = 50;  // CopiesAvail
            dgvBooks.Columns[8].Width = 80;  //shelfloca
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT id, title, author, isbn, category, publisher, year, copiesavailable, shelflocation 
                             FROM books
                             WHERE CAST(id AS TEXT) ILIKE @search
                                OR title ILIKE @search
                                OR author ILIKE @search
                                OR isbn ILIKE @search
                                OR category ILIKE @search
                                OR publisher ILIKE @search
                             ORDER BY id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBooks.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}");
            }
        }

    }
}
