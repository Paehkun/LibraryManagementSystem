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
        }

        private void LoadBooks()
        {
            DataTable dt = DatabaseHelper.GetAllBooks();
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
            dataGridView1.ReadOnly = true;
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
