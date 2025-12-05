using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddBookForm : Form
    {
        private BookRepository _bookRepo;
        public AddBookForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _bookRepo = new BookRepository(db);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            var book = new Book
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Publisher = txtPublisher.Text.Trim(),
                Year = int.Parse(txtYear.Text),
                CopiesAvailable = int.Parse(txtCopies.Text),
                ShelfLocation = txtShelfLocation.Text.Trim(),
                Image = txtImg.Text.Trim()
            };

            try
            {
                _bookRepo.AddBook(book);
                MessageBox.Show("Book added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private bool ValidateInputs()
        {
            int year, copies;

            return
                !string.IsNullOrWhiteSpace(txtTitle.Text) &&
                !string.IsNullOrWhiteSpace(txtAuthor.Text) &&
                !string.IsNullOrWhiteSpace(txtISBN.Text) &&
                !string.IsNullOrWhiteSpace(txtCategory.Text) &&
                !string.IsNullOrWhiteSpace(txtPublisher.Text) &&
                !string.IsNullOrWhiteSpace(txtShelfLocation.Text) &&
                !string.IsNullOrWhiteSpace(txtImg.Text) &&
                int.TryParse(txtYear.Text, out year) &&
                int.TryParse(txtCopies.Text, out copies);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
