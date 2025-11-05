using Npgsql;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class EditBookForm : Form
    {
        private int _id;
        public EditBookForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

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
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT id, title, author, isbn, category, publisher, year, copiesavailable, shelflocation 
                                 FROM books 
                                 WHERE id = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBookId.Text = reader["id"].ToString();
                                txtTitle.Text = reader["title"].ToString();
                                txtAuthor.Text = reader["author"].ToString();
                                txtISBN.Text = reader["isbn"].ToString();
                                txtCategory.Text = reader["category"].ToString();
                                txtPublisher.Text = reader["publisher"].ToString();
                                txtYear.Text = reader["year"].ToString();
                                txtCopies.Text = reader["copiesavailable"].ToString();
                                txtShelfLocation.Text = reader["shelflocation"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No book found with this ID.");
                            }
                        }
                    }
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

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT title, author, isbn, category, publisher, year, copiesavailable, shelflocation 
                                     FROM books 
                                     WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", bookId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTitle.Text = reader["title"].ToString();
                                txtAuthor.Text = reader["author"].ToString();
                                txtISBN.Text = reader["isbn"].ToString();
                                txtCategory.Text = reader["category"].ToString();
                                txtPublisher.Text = reader["publisher"].ToString();
                                txtYear.Text = reader["year"].ToString();
                                txtCopies.Text = reader["copiesavailable"].ToString();
                                txtShelfLocation.Text = reader["shelflocation"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No book found with this ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book: {ex.Message}");
            }
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

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE books 
                                           SET title = @title, 
                                               author = @auth, 
                                               isbn = @isbn, 
                                               category = @cat, 
                                               publisher = @pub, 
                                               year = @year, 
                                               copiesavailable = @copies, 
                                               shelflocation = @shelf
                                           WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@auth", txtAuthor.Text.Trim());
                        cmd.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
                        cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@pub", txtPublisher.Text.Trim());
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@copies", copies);
                        cmd.Parameters.AddWithValue("@shelf", txtShelfLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", bookId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Book updated successfully!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No book found with this ID.");
                        }
                    }
                }
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
