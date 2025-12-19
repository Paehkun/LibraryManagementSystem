using LibraryManagement.Domain.Model;
using LibraryManagement.Domain.Validation;
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

            var book = new Book
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Publisher = txtPublisher.Text.Trim(),
                Year = int.TryParse(txtYear.Text, out int y) ? y : 0,
                CopiesAvailable = int.TryParse(txtCopies.Text, out int c) ? c : -1,
                ShelfLocation = txtShelfLocation.Text.Trim(),
                Image = txtImg.Text.Trim()
            };

            try
            {
                Validator.ValidateBook(book);

                _bookRepo.AddBook(book);
                MessageBox.Show("Book added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Select Category"); 
            cmbCategory.Items.Add("Adventure");
            cmbCategory.Items.Add("Classic");
            cmbCategory.Items.Add("Dystopian");
            cmbCategory.Items.Add("Fantasy");
            cmbCategory.Items.Add("Fiction");
            cmbCategory.Items.Add("Horror");
            cmbCategory.Items.Add("Historical");
            cmbCategory.Items.Add("Mystery");
            cmbCategory.Items.Add("Poetry");
            cmbCategory.Items.Add("Psychological");
            cmbCategory.Items.Add("Romance");
            cmbCategory.Items.Add("Science Fiction");
            cmbCategory.Items.Add("Thriller");

            cmbCategory.SelectedIndex = 0;

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
