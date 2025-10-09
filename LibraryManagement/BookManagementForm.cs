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
            dgvBooks.Columns[0].Width = 50;   // Book ID
            dgvBooks.Columns[1].Width = 180;  // Title
            dgvBooks.Columns[2].Width = 130;  // Author
            dgvBooks.Columns[3].Width = 110;  // Isbn
            dgvBooks.Columns[4].Width = 90;   //Category
            dgvBooks.Columns[5].Width = 100;  // Publisher
            dgvBooks.Columns[6].Width = 60;  //Year 
            dgvBooks.Columns[7].Width = 70;  // CopiesAvail
            dgvBooks.Columns[8].Width = 70;  //shelfloca
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
