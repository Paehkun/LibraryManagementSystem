using System;
using System.Windows.Forms;
using Npgsql;

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
            string category = txtCategory.Text.Trim();
            int copies;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(category) || !int.TryParse(txtCopies.Text, out copies))
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
                    string query = "INSERT INTO books (title, author, category, copies) VALUES (@title, @auth, @cat, @copies)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@cat", category);
                        cmd.Parameters.AddWithValue("@copies", copies);
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
    }
}
