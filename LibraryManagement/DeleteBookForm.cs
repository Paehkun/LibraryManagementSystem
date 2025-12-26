using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class DeleteBookForm : Form
    {
        private BookRepository _bookRepo;

        public DeleteBookForm(BookRepository bookRepo)
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _bookRepo = bookRepo;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter an ISBN number.");
                return;
            }

            try
            {
                //Check if the book exists BEFORE asking for confirmation
                bool exists = _bookRepo.BookExists(isbn);
                if (!exists)
                {
                    MessageBox.Show("No book found with this ISBN (or it has already been deleted).");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this book?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                bool deleted = _bookRepo.DeleteBook(isbn);
                if (deleted)
                {
                    MessageBox.Show("Book deleted successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Book not deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}");
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
