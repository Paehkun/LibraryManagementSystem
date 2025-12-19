using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Repository;
using LibraryManagement.Domain.Validation;
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

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
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
                    if (!string.IsNullOrEmpty(book.Category) && cmbCategory.Items.Contains(book.Category))
                        cmbCategory.SelectedItem = book.Category;
                    else
                        cmbCategory.SelectedIndex = 0;
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

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT category FROM categories ORDER BY id ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCategory.Items.Add(reader.GetString(0));
                    }
                }
            }

            cmbCategory.Items.Insert(0, "Select Category"); // optional default
            cmbCategory.SelectedIndex = 0; // show default prompt
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
            if (!int.TryParse(txtBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Please enter a valid Book ID.");
                return;
            }

            var book = new Book
            {
                Id = bookId,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Publisher = txtPublisher.Text.Trim(),
                Year = int.TryParse(txtYear.Text.Trim(), out int y) ? y : 0,
                CopiesAvailable = int.TryParse(txtCopies.Text.Trim(), out int c) ? c : -1,
                ShelfLocation = txtShelfLocation.Text.Trim(),
                Image = "" 
            };

            try
            {
                Validator.ValidateBook(book);

                _bookRepo.UpdateBook(book);
                MessageBox.Show("Book updated successfully!");
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

        
    }
}
