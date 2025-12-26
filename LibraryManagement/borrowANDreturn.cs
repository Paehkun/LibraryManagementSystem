using LibraryManagement.Domain.Model;
using LibraryManagementSystem;
using LibraryManagementSystem.Domain.Repository;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static LibraryManagementSystem.Domain.Entities.BorrowReturn;

namespace LibraryManagement
{
    public partial class borrowANDreturn : Form
    {
        private BorrowRepository _borrowRepo;
        private string username;

        public borrowANDreturn(string username)
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _borrowRepo = new BorrowRepository(db);
            this.username = UserSession.Username;

            StyleDataGridView();
        }

        private void borrowANDreturn_Load(object sender, EventArgs e)
        {
            LoadBorrowRecords();
            FormatColumns();
        }

        private void StyleDataGridView()
        {
            dgvBorrowReturn.EnableHeadersVisualStyles = false;
            dgvBorrowReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvBorrowReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBorrowReturn.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvBorrowReturn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBorrowReturn.ColumnHeadersHeight = 45;

            dgvBorrowReturn.RowTemplate.Height = 45;
            dgvBorrowReturn.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvBorrowReturn.DefaultCellStyle.BackColor = Color.White;
            dgvBorrowReturn.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
            dgvBorrowReturn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvBorrowReturn.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBorrowReturn.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);

            dgvBorrowReturn.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 240, 241);

            dgvBorrowReturn.BackgroundColor = Color.White;
            dgvBorrowReturn.BorderStyle = BorderStyle.None;
            dgvBorrowReturn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBorrowReturn.GridColor = Color.FromArgb(189, 195, 199);
            dgvBorrowReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowReturn.AllowUserToAddRows = false;
            dgvBorrowReturn.AllowUserToDeleteRows = false;
            dgvBorrowReturn.ReadOnly = true;
            dgvBorrowReturn.RowHeadersVisible = false;
            dgvBorrowReturn.MultiSelect = false;
            dgvBorrowReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatColumns()
        {
            if (dgvBorrowReturn.Columns.Count == 0) return;

            // Hide columns
            string[] hideColumns = {
                "created_at", "last_modified", "is_deleted", "create_by",
                "last_modified_by", "image", "id"
            };

            foreach (var col in hideColumns)
            {
                if (dgvBorrowReturn.Columns[col] != null)
                    dgvBorrowReturn.Columns[col].Visible = false;
            }

            // Format headers
            if (dgvBorrowReturn.Columns["borrowid"] != null)
            {
                dgvBorrowReturn.Columns["borrowid"].HeaderText = "Borrow ID";
                dgvBorrowReturn.Columns["borrowid"].Width = 120;
                dgvBorrowReturn.Columns["borrowid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBorrowReturn.Columns["title"] != null)
            {
                dgvBorrowReturn.Columns["title"].HeaderText = "Book Title";
                dgvBorrowReturn.Columns["title"].Width = 250;
            }

            if (dgvBorrowReturn.Columns["isbn"] != null)
            {
                dgvBorrowReturn.Columns["isbn"].HeaderText = "ISBN";
                dgvBorrowReturn.Columns["isbn"].Width = 140;
            }

            if (dgvBorrowReturn.Columns["memberid"] != null)
            {
                dgvBorrowReturn.Columns["memberid"].HeaderText = "Member ID";
                dgvBorrowReturn.Columns["memberid"].Width = 100;
                dgvBorrowReturn.Columns["memberid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBorrowReturn.Columns["name"] != null)
            {
                dgvBorrowReturn.Columns["name"].HeaderText = "Member Name";
                dgvBorrowReturn.Columns["name"].Width = 180;
            }

            if (dgvBorrowReturn.Columns["phone"] != null)
            {
                dgvBorrowReturn.Columns["phone"].HeaderText = "Phone";
                dgvBorrowReturn.Columns["phone"].Width = 130;
            }

            if (dgvBorrowReturn.Columns["borrowdate"] != null)
            {
                dgvBorrowReturn.Columns["borrowdate"].HeaderText = "Borrow Date";
                dgvBorrowReturn.Columns["borrowdate"].Width = 120;
                dgvBorrowReturn.Columns["borrowdate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvBorrowReturn.Columns["borrowdate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBorrowReturn.Columns["duedate"] != null)
            {
                dgvBorrowReturn.Columns["duedate"].HeaderText = "Due Date";
                dgvBorrowReturn.Columns["duedate"].Width = 120;
                dgvBorrowReturn.Columns["duedate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvBorrowReturn.Columns["duedate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBorrowReturn.Columns["returndate"] != null)
            {
                dgvBorrowReturn.Columns["returndate"].HeaderText = "Return Date";
                dgvBorrowReturn.Columns["returndate"].Width = 120;
                dgvBorrowReturn.Columns["returndate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvBorrowReturn.Columns["returndate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvBorrowReturn.Columns["status"] != null)
            {
                dgvBorrowReturn.Columns["status"].HeaderText = "Status";
                dgvBorrowReturn.Columns["status"].Width = 100;
                dgvBorrowReturn.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvBorrowReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBorrowReturn.ClearSelection();
        }

        private void LoadBorrowRecords()
        {
            try
            {
                DataTable dt = _borrowRepo.GetBorrowRecords();
                dgvBorrowReturn.DataSource = dt;
                FormatColumns();
                ApplyStatusColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyStatusColors()
        {
            DateTime today = DateTime.Now.Date;

            foreach (DataGridViewRow row in dgvBorrowReturn.Rows)
            {
                if (row.Cells["status"].Value == null)
                    continue;

                int status = Convert.ToInt32(row.Cells["status"].Value);

                if (status == (int)BorrowStatus.Borrowed)
                {
                    if (DateTime.TryParse(row.Cells["duedate"].Value?.ToString(), out DateTime dueDate))
                    {
                        if (dueDate < today)
                        {
                            // Overdue
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
                        }
                        else
                        {
                            // Borrowed (not overdue)
                            row.DefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 128, 0);
                        }
                    }
                }
                else
                {
                    // Returned
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(52, 73, 94);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int memberId;
                using (SelectMemberForm memberForm = new SelectMemberForm())
                {
                    if (memberForm.ShowDialog() != DialogResult.OK)
                        return;

                    memberId = int.Parse(memberForm.SelectedMemberId);
                }

                List<(string Title, string ISBN)> selectedBooks = new();
                using (SelectBooksForm booksForm = new SelectBooksForm())
                {
                    if (booksForm.ShowDialog() != DialogResult.OK)
                        return;

                    foreach (var book in booksForm.SelectedBooks)
                    {
                        selectedBooks.Add((book.Title, book.ISBN));
                    }
                }

                if (selectedBooks.Count == 0)
                {
                    MessageBox.Show("No books selected!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string input = Interaction.InputBox(
                    "Enter number of borrow days:", "Borrow Duration", "7");

                if (!int.TryParse(input, out int borrowDays) || borrowDays <= 0)
                {
                    MessageBox.Show("Invalid borrow days.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime borrowDate = DateTime.Now;
                DateTime dueDate = borrowDate.AddDays(borrowDays);

                foreach (var book in selectedBooks)
                {
                    _borrowRepo.AddBorrowRecord(
                        book.Title,
                        book.ISBN,
                        memberId,
                        borrowDate,
                        dueDate
                    );
                }

                MessageBox.Show("Books borrowed successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox(
                    "Enter Borrow ID to return:",
                    "Return Book",
                    ""
                );

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Borrow ID is required!", "Missing Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string borrowId = input.Trim();
                _borrowRepo.ReturnBook(borrowId);

                MessageBox.Show("Book returned successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error returning book: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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