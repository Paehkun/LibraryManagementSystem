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
            // Example data for UI preview
            dgvBooks.Rows.Add("1", "The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "5");
            dgvBooks.Rows.Add("2", "1984", "George Orwell", "Dystopian", "3");
            dgvBooks.Rows.Add("3", "To Kill a Mockingbird", "Harper Lee", "Classic", "4");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Add Book Page");
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
    }
}
