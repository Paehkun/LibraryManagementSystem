using Npgsql;
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            string category = txtCategory.Text.Trim();
            string publisher = txtPublisher.Text.Trim();
            string shelflocation = txtShelfLocation.Text.Trim();
            string image = txtImg.Text.Trim();

            int copiesavailable;
            int year;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
        string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(category) ||
        string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(shelflocation) ||
        string.IsNullOrEmpty(image) ||
        !int.TryParse(txtYear.Text, out year) ||
        !int.TryParse(txtCopies.Text, out copiesavailable))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO books (title, author, isbn, category, publisher, year, copiesavailable, shelflocation, image) VALUES (@title, @author, @isbn, @category, @publisher, @year, @copiesavailable, @shelflocation, @image)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@publisher", publisher);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@copiesavailable", copiesavailable);
                        cmd.Parameters.AddWithValue("@shelflocation", shelflocation);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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
