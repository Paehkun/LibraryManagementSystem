using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class SelectBooksForm : Form
    {
        public List<(string ISBN, string Title)> SelectedBooks { get; private set; } = new();

        public SelectBooksForm()
        {
            InitializeComponent();
            LoadBooks();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadBooks()
        {
            DataTable dt = DatabaseHelper.GetAllBooks();
            dataGridView1.DataSource = dt;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
            dataGridView1.ReadOnly = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["copiesavailable"] != null)
                {
                    var cellValue = row.Cells["copiesavailable"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int copies))
                    {
                        if (copies <= 0)
                        {
                            // Grey out the row and disable clicking
                            row.DefaultCellStyle.BackColor = Color.Black;
                            row.DefaultCellStyle.ForeColor = Color.DarkGray;
                            row.ReadOnly = true; // prevents clicking/editing
                        }
                        else
                        {
                            // Restore normal style for available books
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.ReadOnly = false;
                        }
                    }
                }
            }


            // 🛑 Prevent selecting rows with 0 copies
            dataGridView1.SelectionChanged += (s, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.Cells["copiesavailable"].Value != DBNull.Value &&
                        int.TryParse(row.Cells["copiesavailable"].Value.ToString(), out int copies) &&
                        copies <= 0)
                    {
                        row.Selected = false; // deselect it
                    }
                }
            };
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (int.TryParse(row.Cells["copiesavailable"].Value?.ToString(), out int copies) && copies == 0)
                {
                    // Deselect this row if copies = 0
                    row.Selected = false;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedBooks.Clear();

            if (dataGridView1.SelectedRows.Count == 0)
            {
                // No popup here — just silently close if no selection
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string isbn = row.Cells["isbn"].Value.ToString();
                string title = row.Cells["title"].Value.ToString();
                SelectedBooks.Add((isbn, title));
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
