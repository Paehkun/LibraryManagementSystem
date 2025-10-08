using LibraryManagement;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookManagementForm : Form
    {
        private string username;
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
            MessageBox.Show("Open Edit Book Page");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Book Selected");
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
            dgvBooks.Columns[0].Width = 60;   // Book ID
            dgvBooks.Columns[1].Width = 250;  // Title
            dgvBooks.Columns[2].Width = 150;  // Author
            dgvBooks.Columns[3].Width = 120;  // Genre
            dgvBooks.Columns[4].Width = 80;   // Quantity
        }


    }
}
