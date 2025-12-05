using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class EditBookForm : Form
    {
        private int _id;
        private BookRepository _bookRepo;
        public EditBookForm(int id)
        {
            InitializeComponent();       
            _id = id;
            DBConnection db = new DBConnection();
            _bookRepo = new BookRepository(db);

        }

       // private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                LoadBooks(_id);
                txtBookId.ReadOnly = false; // prevent editing ID
            }
        }
        private void LoadBooks(int id)
        {
            try
            {
                Book book = _bookRepo.GetAllBooks().FirstOrDefault(b => b.Id == id);
                if (book != null)
                {
                    txtBookId.Text = book.Id.ToString();
                    txtTitle.Text = book.Title;
                    txtAuthor.Text = book.Author;
                    txtISBN.Text = book.ISBN;
                    txtCategory.Text = book.Category;
                    txtPublisher.Text = book.Publisher;
                    txtYear.Text = book.Year.ToString();
                    txtCopies.Text = book.CopiesAvailable.ToString();
                    txtShelfLocation.Text = book.ShelfLocation;
                }
                else
                {
                    MessageBox.Show("No book found with this ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book: {ex.Message}");
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID.");
                return;
            }

            LoadBooks(bookId);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text.Trim(), out int bookId) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtPublisher.Text) ||
                !int.TryParse(txtYear.Text.Trim(), out int year) ||
                !int.TryParse(txtCopies.Text.Trim(), out int copies) ||
                string.IsNullOrWhiteSpace(txtShelfLocation.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            var book = new Book
            {
                Id = bookId,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Publisher = txtPublisher.Text.Trim(),
                Year = year,
                CopiesAvailable = copies,
                ShelfLocation = txtShelfLocation.Text.Trim(),
                Image = "" // Or read from a textbox if you have it
            };

            try
            {
                _bookRepo.UpdateBook(book);
                MessageBox.Show("Book updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
