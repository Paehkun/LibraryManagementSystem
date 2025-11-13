using LibraryManagementSystem;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LibraryManagement
{
    public partial class borrowANDreturn : Form
    {
        private int selectedMemberId = -1;
        private string selectedMemberName = "";
        private string selectedPhone = "";
        private string username;
        private List<(string Title, string ISBN)> selectedBooks = new List<(string, string)>();

        public borrowANDreturn(string username)
        {
            InitializeComponent();
            this.username = UserSession.Username;

            // ✅ Apply UI styling first
            StyleDataGridView();
            ApplyCardStyle();

            // ✅ Hook Load event instead of calling LoadBorrowRecords() in constructor
            this.Load += borrowANDreturn_Load;
        }

        // ✅ This runs when form fully loaded, ensuring DataGridView has columns
        private void borrowANDreturn_Load(object sender, EventArgs e)
        {
            LoadBorrowRecords();
            SetColumnStyles(); // safe to set column width and headers now
        }

        private void LoadBorrowRecords()
        {
            try
            {
                DataTable dt = DatabaseHelper.GetBorrowRecords();
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridView1.RowTemplate.Height = 35;

                CheckLateReturns();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        // ✅ Column widths and header settings (safe after data is loaded)
        private void SetColumnStyles()
        {
            if (dataGridView1.Columns.Count == 0)
                return;

            dataGridView1.Columns["borrowid"].Width = 120;
            dataGridView1.Columns["title"].Width = 230;
            dataGridView1.Columns["isbn"].Width = 140;
            dataGridView1.Columns["memberid"].Width = 120;
            dataGridView1.Columns["name"].Width = 180;
            dataGridView1.Columns["borrowdate"].Width = 150;
            dataGridView1.Columns["duedate"].Width = 150;
            dataGridView1.Columns["returndate"].Width = 150;
            dataGridView1.Columns["status"].Width = 100;
            dataGridView1.Columns["phone"].Width = 120;

            // ✅ Center alignment
            dataGridView1.Columns["borrowid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["memberid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ✅ Set readable headers
            dataGridView1.Columns["borrowid"].HeaderText = "Borrow ID";
            dataGridView1.Columns["title"].HeaderText = "Book Title";
            dataGridView1.Columns["isbn"].HeaderText = "ISBN";
            dataGridView1.Columns["memberid"].HeaderText = "Member ID";
            dataGridView1.Columns["name"].HeaderText = "Name";
            dataGridView1.Columns["phone"].HeaderText = "Phone";
            dataGridView1.Columns["borrowdate"].HeaderText = "Borrow Date";
            dataGridView1.Columns["duedate"].HeaderText = "Due Date";
            dataGridView1.Columns["returndate"].HeaderText = "Return Date";
            dataGridView1.Columns["status"].HeaderText = "Status";

            // ✅ Center grid on form
            int centerX = (this.ClientSize.Width - dataGridView1.Width) / 2;
            dataGridView1.Location = new Point(centerX, 200);
        }

        private void CheckLateReturns()
        {
            DateTime today = DateTime.Now.Date;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status"].Value == null)
                    continue;

                string status = row.Cells["status"].Value.ToString();

                if (!status.Equals("Returned", StringComparison.OrdinalIgnoreCase))
                {
                    if (DateTime.TryParse(row.Cells["duedate"].Value?.ToString(), out DateTime dueDate))
                    {
                        if (dueDate < today)
                        {
                            // 🔴 Overdue book
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            // 🟠 Within borrow period
                            row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 🧩 Step 1: Select Member
                int memberId = -1;
                using (SelectMemberForm memberForm = new SelectMemberForm())
                {
                    if (memberForm.ShowDialog() != DialogResult.OK)
                        return;

                    memberId = int.Parse(memberForm.SelectedMemberId);
                }

                // 🧩 Step 2: Select Books
                List<(string Title, string ISBN)> selectedBooks = new List<(string, string)>();
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
                    MessageBox.Show("No books selected!", "Missing Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🧩 Step 3: Ask for Borrow Days
                string input = Interaction.InputBox("Enter number of borrow days:", "Borrow Duration", "7");
                if (!int.TryParse(input, out int borrowDays) || borrowDays <= 0)
                {
                    MessageBox.Show("Please enter a valid number of days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🧩 Step 4: Insert Borrow Records
                DateTime borrowDate = DateTime.Now;
                DateTime dueDate = borrowDate.AddDays(borrowDays);

                foreach (var book in selectedBooks)
                {
                    DatabaseHelper.AddBorrowRecord(book.Title, book.ISBN, memberId, borrowDate, dueDate);

                    string query = "UPDATE Books SET copiesavailable = copiesavailable - 1 WHERE isbn = @isbn";
                    DatabaseHelper.ExecuteNonQuery(query, new { isbn = book.ISBN });
                }

                MessageBox.Show($"{selectedBooks.Count} book(s) borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowRecords(); // refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Enter Borrow ID to return:", "Return Book", "");

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Borrow ID is required!", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string borrowId = input.Trim();

                DataTable dt = DatabaseHelper.ExecuteQuery(
                    "SELECT isbn, returndate, status FROM borrowreturn WHERE borrowid = @borrowid",
                    new { borrowid = borrowId });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No record found for this Borrow ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string isbn = dt.Rows[0]["isbn"].ToString();
                string status = dt.Rows[0]["status"].ToString();

                if (status == "Returned")
                {
                    MessageBox.Show("This book has already been returned.", "Already Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DateTime today = DateTime.Now.Date;
                string updateQuery = @"UPDATE borrowreturn 
                                       SET returndate = @returndate, status = 'Returned' 
                                       WHERE borrowid = @borrowid";
                DatabaseHelper.ExecuteNonQuery(updateQuery, new { returndate = today, borrowid = borrowId });

                string updateCopies = "UPDATE books SET copiesavailable = copiesavailable + 1 WHERE isbn = @isbn";
                DatabaseHelper.ExecuteNonQuery(updateCopies, new { isbn });

                MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void StyleDataGridView()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void ApplyCardStyle()
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.GridColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Padding = new Padding(12, 10, 12, 10);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.RowTemplate.MinimumHeight = 40;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 250);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            dataGridView1.CellPainting -= DgvBooks_CellPainting;
            dataGridView1.CellPainting += DgvBooks_CellPainting;
        }

        private void DgvBooks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                Rectangle cardRect = e.CellBounds;
                cardRect.Inflate(-5, -5);

                bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;

                Color cardColor = isSelected ? Color.FromArgb(230, 240, 255) : e.CellStyle.BackColor;
                Color borderColor = isSelected ? Color.FromArgb(130, 170, 250) : Color.LightGray;

                using (SolidBrush brush = new SolidBrush(cardColor))
                using (Pen borderPen = new Pen(borderColor, 1))
                {
                    Graphics g = e.Graphics;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    int radius = 10;
                    using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedRectPath(cardRect, radius))
                    {
                        g.FillPath(brush, path);
                        g.DrawPath(borderPen, path);
                    }
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue?.ToString() ?? string.Empty,
                    e.CellStyle.Font,
                    cardRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                );
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
