using LibraryManagement;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookManagementForm : Form
    {
        private string username;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        public BookManagementForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            LoadBooks();                // 🟡 Load data first
            StyleDataGridView();        // 🎨 Column & header style
            ApplyCardStyle();           // 🪄 Card look even on first load
            foreach (DataGridViewColumn column in dgvBooks.Columns)
            {
                if (!string.IsNullOrEmpty(column.HeaderText))
                {
                    column.HeaderText = char.ToUpper(column.HeaderText[0]) + column.HeaderText.Substring(1);
                }
            }

            // Adjust specific column widths
            dgvBooks.Columns["CopiesAvailable"].Width = 150;  // You can adjust this value
            dgvBooks.Columns["Id"].Width = 60;
            dgvBooks.Columns["Title"].Width = 200;
            dgvBooks.Columns["Author"].Width = 150;

            // Optional: Auto resize to fit content
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBooks.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Format column headers
            dgvBooks.Columns["id"].HeaderText = "ID";
            dgvBooks.Columns["title"].HeaderText = "Title";
            dgvBooks.Columns["author"].HeaderText = "Author";
            dgvBooks.Columns["isbn"].HeaderText = "ISBN";
            dgvBooks.Columns["category"].HeaderText = "Category";
            dgvBooks.Columns["publisher"].HeaderText = "Publisher";
            dgvBooks.Columns["year"].HeaderText = "Year";
            dgvBooks.Columns["copiesavailable"].HeaderText = "Copies Available";
            dgvBooks.Columns["shelflocation"].HeaderText = "Shelf Location";

            // Adjust column widths
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBooks.Columns["id"].Width = 60;
            dgvBooks.Columns["title"].Width = 260;
            dgvBooks.Columns["author"].Width = 180;
            dgvBooks.Columns["isbn"].Width = 150;
            dgvBooks.Columns["category"].Width = 120;
            dgvBooks.Columns["publisher"].Width = 180;
            dgvBooks.Columns["year"].Width = 80;
            dgvBooks.Columns["copiesavailable"].Width = 150;
            dgvBooks.Columns["shelflocation"].Width = 160;

            // Optional: make the text centered for ID and Year
            dgvBooks.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.Columns["year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

        private void StyleDataGridView()
        {
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.ColumnHeadersHeight = 40;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Optional column widths
            dgvBooks.Columns[1].Width = 250;
            dgvBooks.Columns[2].Width = 200;
            dgvBooks.Columns[3].Width = 180;
            dgvBooks.Columns[4].Width = 150;
            dgvBooks.Columns[5].Width = 150;
        }

        private void ApplyCardStyle()
        {
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBooks.GridColor = Color.White;
            dgvBooks.RowHeadersVisible = false;

            dgvBooks.DefaultCellStyle.BackColor = Color.White;
            dgvBooks.DefaultCellStyle.ForeColor = Color.Black;
            dgvBooks.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgvBooks.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBooks.DefaultCellStyle.Padding = new Padding(12, 10, 12, 10);

            dgvBooks.RowTemplate.Height = 40;
            dgvBooks.RowTemplate.MinimumHeight = 40;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 250);

            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;

            dgvBooks.CellPainting -= DgvBooks_CellPainting; // avoid double subscription
            dgvBooks.CellPainting += DgvBooks_CellPainting;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (AddBookForm addBookForm = new AddBookForm())
            {
                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                    ApplyCardStyle(); // 🔄 Reapply style after refresh
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
                        ApplyCardStyle(); // 🔄
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.");
            }
        }

        

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteBookForm())
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                    ApplyCardStyle(); // 🔄
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm home = new LibrarianHomeForm(username);
            home.Show();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = DatabaseHelper.GetAllBooks();
            dgvBooks.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT id, title, author, isbn, category, publisher, year, copiesavailable, shelflocation 
                             FROM books
                             WHERE CAST(id AS TEXT) ILIKE @search
                                OR title ILIKE @search
                                OR author ILIKE @search
                                OR isbn ILIKE @search
                                OR category ILIKE @search
                                OR publisher ILIKE @search
                             ORDER BY id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBooks.DataSource = dt;
                            ApplyCardStyle();  // 🪄 make sure search also keeps the card look
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}");
            }
        }
    }
}
