using LibraryManagement.Domain.Model;
using LibraryManagement.Domain.Repository;
using LibraryManagement.Domain.Validation;
using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class EditBookForm : Form
    {
        private int _id;
        private BookRepository _bookRepo;
        private CategoryRepository _categoryRepo;

        public EditBookForm(int id)
        {
            InitializeComponent();
            _id = id;
            DBConnection db = new DBConnection();
            _bookRepo = new BookRepository(db);
            _categoryRepo = new CategoryRepository(db);

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
                DataTable dt = _bookRepo.GetBookById(id);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No book found with this ID.");
                    return;
                }

                DataRow row = dt.Rows[0];

                txtBookId.Text = row["id"].ToString();
                txtTitle.Text = row["title"].ToString();
                txtAuthor.Text = row["author"].ToString();
                txtISBN.Text = row["isbn"].ToString();

                string category = row["category"].ToString();
                if (!string.IsNullOrEmpty(category) && cmbCategory.Items.Contains(category))
                    cmbCategory.SelectedItem = category;
                else
                    cmbCategory.SelectedIndex = 0;

                txtPublisher.Text = row["publisher"].ToString();
                txtYear.Text = row["year"].ToString();
                txtCopies.Text = row["copiesavailable"].ToString();
                txtShelfLocation.Text = row["shelflocation"].ToString();
                txtImg.Text = row["image"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            try
            {
                List<string> categories = _categoryRepo.GetAllCategories();

                foreach (var category in categories)
                {
                    cmbCategory.Items.Add(category);
                }

                cmbCategory.Items.Insert(0, "Select Category");
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
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
