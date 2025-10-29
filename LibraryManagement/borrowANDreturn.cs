using LibraryManagementSystem;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class borrowANDreturn : Form
    {
        private int selectedMemberId = -1;
        private string selectedMemberName = "";
        private string selectedPhone = "";
        private List<(string Title, string ISBN)> selectedBooks = new List<(string, string)>();

        private ListBox listBoxSelectedBooks;

        public borrowANDreturn()
        {
            InitializeComponent();
            listBoxSelectedBooks = new ListBox
            {
                Location = new Point(300, 150),
                Size = new Size(400, 100),
                Font = new Font("Segoe UI", 10)
            };
            this.Controls.Add(listBoxSelectedBooks);
            LoadBorrowRecords();
            StyleDataGridView();
            ApplyCardStyle();
            // ✅ Adjust specific column widths
            dataGridView1.Columns["borrowid"].Width = 120;
            dataGridView1.Columns["title"].Width = 220;
            dataGridView1.Columns["isbn"].Width = 150;
            dataGridView1.Columns["memberid"].Width = 120;
            dataGridView1.Columns["name"].Width = 180;
            dataGridView1.Columns["borrowdate"].Width = 150;
            dataGridView1.Columns["duedate"].Width = 150;
            dataGridView1.Columns["returndate"].Width = 150;
            dataGridView1.Columns["status"].Width = 100;

            // ✅ Optional: center-align some columns
            dataGridView1.Columns["borrowid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["memberid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["borrowid"].HeaderText = "Borrow ID";
            dataGridView1.Columns["title"].HeaderText = "Book Title";
            dataGridView1.Columns["isbn"].HeaderText = "ISBN";
            dataGridView1.Columns["memberid"].HeaderText = "Member ID";
            dataGridView1.Columns["name"].HeaderText = "Name";
            dataGridView1.Columns["borrowdate"].HeaderText = "Borrow Date";
            dataGridView1.Columns["duedate"].HeaderText = "Due Date";
            dataGridView1.Columns["returndate"].HeaderText = "Return Date";
            dataGridView1.Columns["status"].HeaderText = "Status";
            int centerX = (this.ClientSize.Width - dataGridView1.Width) / 2;
            dataGridView1.Location = new Point(centerX, 200); // 200 = Y position (you can adjust)
        }

        private void LoadBorrowRecords()
        {
            DataTable dt = DatabaseHelper.GetBorrowRecords();
            dataGridView1.DataSource = dt;

            // Style
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.RowTemplate.Height = 35;

            CheckLateReturns();
        }

        private void CheckLateReturns()
        {
            DateTime today = DateTime.Now.Date;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["returndate"].Value != null &&
                    DateTime.TryParse(row.Cells["returndate"].Value.ToString(), out DateTime returnDate))
                {
                    if (returnDate < today)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMemberId == -1)
                {
                    MessageBox.Show("Please select a member first.", "Missing Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedBooks.Count == 0)
                {
                    MessageBox.Show("Please select at least one book.", "Missing Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtBorrowDays.Text) || !int.TryParse(txtBorrowDays.Text, out int borrowDays))
                {
                    MessageBox.Show("Please enter valid borrow days.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow member = DatabaseHelper.GetMemberById(selectedMemberId);
                if (member == null)
                {
                    MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string name = member["name"].ToString();
                string phone = member["phone"].ToString();
                DateTime borrowDate = DateTime.Now;
                DateTime dueDate = borrowDate.AddDays(borrowDays);

                foreach (var book in selectedBooks)
                {
                    DatabaseHelper.AddBorrowRecord(book.Title, book.ISBN, selectedMemberId, name, phone, borrowDate, dueDate);
                }

                MessageBox.Show("Borrow record(s) added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowRecords();
                selectedBooks.Clear();
                listBoxSelectedBooks.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnSelectMember_Click(object sender, EventArgs e)
        {
            using (SelectMemberForm memberForm = new SelectMemberForm())
            {
                if (memberForm.ShowDialog() == DialogResult.OK)
                {
                    selectedMemberId = int.Parse(memberForm.SelectedMemberId);
                    selectedMemberName = memberForm.SelectedMemberName;
                    selectedPhone = memberForm.SelectedMemberPhone;

                    MessageBox.Show($"Selected Member: {selectedMemberName} (ID: {selectedMemberId})",
                        "Member Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void BtnSelectBooks_Click(object sender, EventArgs e)
        {
            using (SelectBooksForm booksForm = new SelectBooksForm())
            {
                if (booksForm.ShowDialog() == DialogResult.OK)
                {
                    selectedBooks.Clear();
                    listBoxSelectedBooks.Items.Clear();

                    foreach (var book in booksForm.SelectedBooks)
                    {
                        selectedBooks.Add((book.Title, book.ISBN));
                        listBoxSelectedBooks.Items.Add($"{book.Title} ({book.ISBN})");
                    }

                    MessageBox.Show($"{selectedBooks.Count} book(s) selected.", "Books Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm librarianHome = new LibrarianHomeForm("Librarian");
            librarianHome.Show();
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
