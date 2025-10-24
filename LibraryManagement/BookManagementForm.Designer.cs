using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagementSystem
{
    partial class BookManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel leftPanel;
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
            leftPanel = new Panel();
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
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(33, 150, 243); // modern blue
            leftPanel.Controls.Add(btnBack);
            leftPanel.Controls.Add(btnDeleteBook);
            leftPanel.Controls.Add(btnEditBook);
            leftPanel.Controls.Add(btnAddBook);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(250, 1181);
            leftPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(25, 280);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 35);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            // button colors match theme
            btnBack.ForeColor = Color.Black;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.White;
            btnDeleteBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.Location = new Point(25, 200);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(200, 40);
            btnDeleteBook.TabIndex = 1;
            btnDeleteBook.Text = "🗑️ Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.ForeColor = Color.Black;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = Color.White;
            btnEditBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditBook.FlatStyle = FlatStyle.Flat;
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.Location = new Point(25, 140);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(200, 40);
            btnEditBook.TabIndex = 2;
            btnEditBook.Text = "✏️ Edit Book";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.ForeColor = Color.Black;
            btnEditBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.White;
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.Location = new Point(25, 80);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(200, 40);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "➕ Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.ForeColor = Color.Black;
            btnAddBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnAddBook.Click += btnAddBook_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(245, 247, 250); // light neutral background
            rightPanel.Controls.Add(txtSearch);
            rightPanel.Controls.Add(dgvBooks);
            rightPanel.Controls.Add(lblTitle);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1758, 1181);
            rightPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(174, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search Book";
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 2;
            // small padding & subtle border color
            txtSearch.BackColor = Color.White;
            txtSearch.ForeColor = Color.Black;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            // keep AutoSizeColumnsMode.Fill so layout unchanged
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.Location = new Point(174, 140);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.GridColor = Color.LightGray;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvBooks.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvBooks.Size = new Size(1356, 872);
            dgvBooks.TabIndex = 0;

            // header & row appearance (safe to set in Designer)
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooks.ColumnHeadersHeight = 42;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvBooks.RowTemplate.Height = 56; // taller rows for a card-like feel
            dgvBooks.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            dgvBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dgvBooks.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 251);

            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📚 Book List";
            // 
            // BookManagementForm
            // 
            ClientSize = new Size(2008, 1181);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "BookManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - Book Management";
            WindowState = FormWindowState.Maximized;
            Load += BookManagementForm_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
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
    }
}
