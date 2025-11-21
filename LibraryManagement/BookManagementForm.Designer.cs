using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagementSystem
{
    partial class BookManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel rightPanel;
        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnDeleteBook;
        private Button btnBack;
        private Label lblTitle;
        private DataGridView dgvBooks;
        // NOTE: use txtSearch (consistent with event handlers and other code)
        private TextBox txtSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnBack = new Button();
            btnDeleteBook = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            rightPanel = new Panel();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            lblTitle = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            topPanel = new Panel();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RoyalBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 43);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.RoyalBlue;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnDeleteBook.FlatStyle = FlatStyle.System;
            btnDeleteBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(713, 10);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(143, 40);
            btnDeleteBook.TabIndex = 1;
            btnDeleteBook.Text = "🗑️ Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = Color.RoyalBlue;
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnEditBook.FlatStyle = FlatStyle.System;
            btnEditBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditBook.ForeColor = Color.White;
            btnEditBook.Location = new Point(537, 10);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(143, 40);
            btnEditBook.TabIndex = 2;
            btnEditBook.Text = "✏️ Edit Book";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.RoyalBlue;
            btnAddBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnAddBook.FlatStyle = FlatStyle.System;
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBook.ForeColor = Color.RoyalBlue;
            btnAddBook.Location = new Point(353, 10);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(143, 40);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "➕ Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(245, 247, 250);
            rightPanel.Controls.Add(topPanel);
            rightPanel.Controls.Add(txtSearch);
            rightPanel.Controls.Add(dgvBooks);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(2008, 1181);
            rightPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(174, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search Book";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(250, 250, 251);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvBooks.ColumnHeadersHeight = 42;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.LightGray;
            dgvBooks.Location = new Point(174, 140);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowTemplate.Height = 56;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1439, 951);
            dgvBooks.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(150, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📚 Book List";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.RoyalBlue;
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(btnDeleteBook);
            topPanel.Controls.Add(btnAddBook);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnEditBook);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20, 10, 20, 10);
            topPanel.Size = new Size(2008, 60);
            topPanel.TabIndex = 4;
            // 
            // BookManagementForm
            // 
            ClientSize = new Size(2008, 1181);
            Controls.Add(rightPanel);
            Name = "BookManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - Book Management";
            WindowState = FormWindowState.Maximized;
            Load += BookManagementForm_Load;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Button button1;
        private Panel topPanel;
    }
}
