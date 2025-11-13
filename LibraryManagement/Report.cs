using LibraryManagementSystem;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace LibraryManagement
{
    public partial class Report : Form
    {
        private string username;
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db";

        public Report(string username)
        {
            InitializeComponent();
            this.username = UserSession.Username;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadReturnedBooks();
            StyleDataGridView();
            ApplyCardStyle();

            foreach (DataGridViewColumn column in dgvReport.Columns)
            {
                if (!string.IsNullOrEmpty(column.HeaderText))
                {
                    column.HeaderText = char.ToUpper(column.HeaderText[0]) + column.HeaderText.Substring(1);
                }
            }

            // Adjust specific column widths
            //dgvReport.Columns["CopiesAvailable"].Width = 150;  // You can adjust this value
            //dgvReport.Columns["Id"].Width = 60;
            //dgvReport.Columns["Title"].Width = 200;
            //dgvReport.Columns["Author"].Width = 150;

            // Optional: Auto resize to fit content
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Format column headers
            dgvReport.Columns["borrowid"].HeaderText = "Borrow ID";
            dgvReport.Columns["title"].HeaderText = "Title";
            dgvReport.Columns["isbn"].HeaderText = "ISBN";
            dgvReport.Columns["memberid"].HeaderText = "Member ID";
            dgvReport.Columns["name"].HeaderText = "Name";
            dgvReport.Columns["phone"].HeaderText = "Phone";
            dgvReport.Columns["borrowdate"].HeaderText = "Borrow Date";
            dgvReport.Columns["duedate"].HeaderText = "Due Date";
            dgvReport.Columns["returndate"].HeaderText = "Return Date";

            // Adjust column widths
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvReport.Columns["borrowid"].Width = 120;
            dgvReport.Columns["title"].Width = 300;
            dgvReport.Columns["isbn"].Width = 140;
            dgvReport.Columns["memberid"].Width = 100;
            dgvReport.Columns["name"].Width = 150;
            dgvReport.Columns["phone"].Width = 100;
            dgvReport.Columns["borrowdate"].Width = 130;
            dgvReport.Columns["duedate"].Width = 130;
            dgvReport.Columns["returndate"].Width = 130;

            //dgvReport.Columns["borrowid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvReport.Columns["year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void DgvReport_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                System.Drawing.Rectangle cardRect = e.CellBounds;
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

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRectPath(System.Drawing.Rectangle rect, int radius)
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

        private void ApplyCardStyle()
        {
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvReport.GridColor = Color.White;
            dgvReport.RowHeadersVisible = false;

            dgvReport.DefaultCellStyle.BackColor = Color.White;
            dgvReport.DefaultCellStyle.ForeColor = Color.Black;
            dgvReport.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvReport.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgvReport.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvReport.DefaultCellStyle.Padding = new Padding(12, 10, 12, 10);

            dgvReport.RowTemplate.Height = 40;
            dgvReport.RowTemplate.MinimumHeight = 40;
            dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 250);

            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;
            dgvReport.ReadOnly = true;

            dgvReport.CellPainting -= DgvReport_CellPainting; // avoid double subscription
            dgvReport.CellPainting += DgvReport_CellPainting;
        }

        private void LoadReturnedBooks(string titleFilter = "", string memberFilter = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT borrowid, title, isbn, memberid, name, phone, borrowdate, duedate, returndate FROM borrowreturn WHERE status = 'Returned'";

                    if (!string.IsNullOrEmpty(titleFilter))
                        query += " AND LOWER(title) LIKE LOWER(@title)";
                    if (!string.IsNullOrEmpty(memberFilter))
                        query += " AND LOWER(name) LIKE LOWER(@name)";
                    if (startDate.HasValue && endDate.HasValue)
                        query += " AND returndate BETWEEN @startDate AND @endDate";

                    query += " ORDER BY returndate DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(titleFilter))
                            cmd.Parameters.AddWithValue("@title", "%" + titleFilter + "%");
                        if (!string.IsNullOrEmpty(memberFilter))
                            cmd.Parameters.AddWithValue("@name", "%" + memberFilter + "%");
                        if (startDate.HasValue && endDate.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@startDate", startDate.Value);
                            cmd.Parameters.AddWithValue("@endDate", endDate.Value);
                        }

                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvReport.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void StyleDataGridView()
        {
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dgvReport.RowTemplate.Height = 30;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.GridColor = Color.LightGray;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;

            // Alternate row color
            dgvReport.RowsDefaultCellStyle.BackColor = Color.White;
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadReturnedBooks(
                txtBookTitle.Text.Trim(),
                txtMemberName.Text.Trim(),
                dtpStart.Value,
                dtpEnd.Value
            );
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    FileName = "ReturnedBooksReport.csv"
                };

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        sb.Append(dgvReport.Columns[i].HeaderText);
                        if (i < dgvReport.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();

                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            string cellValue = row.Cells[i].Value?.ToString() ?? "";
                            if (DateTime.TryParse(cellValue, out DateTime dt))
                                cellValue = dt.ToString("dd/MM/yyyy");
                            cellValue = "\"" + cellValue.Replace("\"", "\"\"") + "\"";
                            sb.Append(cellValue);
                            if (i < dgvReport.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();
                    }

                    File.WriteAllText(saveFile.FileName, sb.ToString());
                    MessageBox.Show("Exported to CSV successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to CSV: " + ex.Message);
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReport.Rows.Count == 0)
                {
                    MessageBox.Show("No data available to export!", "Warning");
                    return;
                }

                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FileName = "ReturnedBooksReport.pdf"
                };

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        var titleFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                        var normalFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);

                        Paragraph title = new Paragraph("📊 Returned Books Report\n\n", titleFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        pdfDoc.Add(title);

                        PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count)
                        {
                            WidthPercentage = 100
                        };

                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, normalFont))
                            {
                                BackgroundColor = new BaseColor(70, 130, 180), // SteelBlue shade
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                Padding = 5
                            };
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value?.ToString() ?? "";
                                if (DateTime.TryParse(cellValue, out DateTime dt))
                                    cellValue = dt.ToString("dd/MM/yyyy");
                                pdfTable.AddCell(new Phrase(cellValue, normalFont));
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("Exported to PDF successfully!", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message);
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
