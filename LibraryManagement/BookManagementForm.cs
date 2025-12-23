using LibraryManagement;
using LibraryManagementSystem.Domain.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookManagementForm : Form
    {
        private string username;
        private BookRepository _bookRepo;

        public BookManagementForm(string username)
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _bookRepo = new BookRepository(db);
            this.username = UserSession.Username;

            StyleDataGridView();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            FormatColumns();
        }

        private void StyleDataGridView()
        {
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.ColumnHeadersHeight = 45;

            dgvBooks.RowTemplate.Height = 45;
            dgvBooks.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvBooks.DefaultCellStyle.BackColor = Color.White;
            dgvBooks.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgvBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvBooks.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBooks.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);

            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241);

            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooks.GridColor = Color.FromArgb(189, 195, 199);
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.MultiSelect = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatColumns()
        {
            if (dgvBooks.Columns.Count == 0) return;

            // Hide base fields
            string[] hideColumns = {
                "CreatedAt", "LastModified", "IsDeleted", "CreateBy",
                "LastModifiedBy", "Image"
            };

            foreach (var col in hideColumns)
            {
                if (dgvBooks.Columns[col] != null)
                    dgvBooks.Columns[col].Visible = false;
            }

            // Format headers
            if (dgvBooks.Columns["id"] != null)
            {
                dgvBooks.Columns["id"].HeaderText = "ID";
                dgvBooks.Columns["id"].Width = 60;
                dgvBooks.Columns["id"].DisplayIndex = 0;
                dgvBooks.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBooks.Columns["title"] != null)
            {
                dgvBooks.Columns["title"].HeaderText = "Title";
                dgvBooks.Columns["title"].Width = 290;
            }

            if (dgvBooks.Columns["author"] != null)
            {
                dgvBooks.Columns["author"].HeaderText = "Author";
                dgvBooks.Columns["author"].Width = 220;
            }

            if (dgvBooks.Columns["isbn"] != null)
            {
                dgvBooks.Columns["isbn"].HeaderText = "ISBN";
                dgvBooks.Columns["isbn"].Width = 160;
            }

            if (dgvBooks.Columns["category"] != null)
            {
                dgvBooks.Columns["category"].HeaderText = "Category";
                dgvBooks.Columns["category"].Width = 120;
            }

            if (dgvBooks.Columns["publisher"] != null)
            {
                dgvBooks.Columns["publisher"].HeaderText = "Publisher";
                dgvBooks.Columns["publisher"].Width = 180;
            }

            if (dgvBooks.Columns["year"] != null)
            {
                dgvBooks.Columns["year"].HeaderText = "Year";
                dgvBooks.Columns["year"].Width = 80;
                dgvBooks.Columns["year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBooks.Columns["copiesavailable"] != null)
            {
                dgvBooks.Columns["copiesavailable"].HeaderText = "Available";
                dgvBooks.Columns["copiesavailable"].Width = 100;
                dgvBooks.Columns["copiesavailable"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBooks.Columns["totalcopies"] != null)
            {
                dgvBooks.Columns["totalcopies"].HeaderText = "Total";
                dgvBooks.Columns["totalcopies"].Width = 80;
                dgvBooks.Columns["totalcopies"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBooks.Columns["shelflocation"] != null)
            {
                dgvBooks.Columns["shelflocation"].HeaderText = "Shelf";
                dgvBooks.Columns["shelflocation"].Width = 120;
            }

            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBooks.ClearSelection();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _bookRepo.GetAllBooks(txtSearch.Text.Trim());
            FormatColumns();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (AddBookForm addBookForm = new AddBookForm())
            {
                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["id"].Value);
                using (EditBookForm editForm = new EditBookForm(id))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadBooks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteBookForm(_bookRepo))
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "admin")
            {
                new AdminHomeForm(UserSession.Username).Show();
            }
            else
            {
                new LibrarianHomeForm(UserSession.Username).Show();
            }

            this.Hide();
        }
    }
}