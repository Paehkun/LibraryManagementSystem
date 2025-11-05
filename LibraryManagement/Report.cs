using LibraryManagementSystem;
using Npgsql; // Make sure you added this reference for PostgreSQL
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement
{
    public partial class Report : Form
    {
        private string username;
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db";
        public Report(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadReturnedBooks();
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

                    // Write header
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        sb.Append(dgvReport.Columns[i].HeaderText);
                        if (i < dgvReport.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();

                    // Write data
                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            string cellValue = row.Cells[i].Value?.ToString() ?? "";

                            // 🕒 Convert timestamps to only show date
                            if (DateTime.TryParse(cellValue, out DateTime dt))
                            {
                                cellValue = dt.ToString("dd/MM/yyyy"); // <-- Only date part
                            }

                            // Escape commas and quotes properly
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
                    // Create PDF
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        // iTextSharp references
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 20f, 20f, 20f, 20f);
                        iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Title
                        var titleFont = iTextSharp.text.FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                        var normalFont = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);

                        iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("📊 Returned Books Report\n\n", titleFont);
                        title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        pdfDoc.Add(title);

                        // Create table with same number of columns
                        iTextSharp.text.pdf.PdfPTable pdfTable = new iTextSharp.text.pdf.PdfPTable(dgvReport.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Add header
                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, normalFont));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(220, 220, 220);
                            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }

                        // Add data
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value?.ToString() ?? "";
                                DateTime dt;
                                if (DateTime.TryParse(cellValue, out dt))
                                {
                                    cellValue = dt.ToString("dd/MM/yyyy"); // Only show date
                                }
                                pdfTable.AddCell(new iTextSharp.text.Phrase(cellValue, normalFont));
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
            this.Hide();
            LibrarianHomeForm home = new LibrarianHomeForm(username);
            home.Show();
        }

    }
}
