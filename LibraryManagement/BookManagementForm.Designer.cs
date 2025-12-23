using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagementSystem
{
    partial class BookManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBooks;

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
            topPanel = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            btnAddBook = new Button();
            btnEditBook = new Button();
            btnDeleteBook = new Button();
            mainPanel = new Panel();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddBook);
            topPanel.Controls.Add(btnEditBook);
            topPanel.Controls.Add(btnDeleteBook);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1680, 66);
            topPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(18, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(122, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📚 Book Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(46, 204, 113);
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(1225, 14);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(122, 38);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "➕ Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = Color.FromArgb(241, 196, 15);
            btnEditBook.Cursor = Cursors.Hand;
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 156, 18);
            btnEditBook.FlatStyle = FlatStyle.Flat;
            btnEditBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditBook.ForeColor = Color.White;
            btnEditBook.Location = new Point(1365, 14);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(122, 38);
            btnEditBook.TabIndex = 3;
            btnEditBook.Text = "✏️ Edit Book";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteBook.Cursor = Cursors.Hand;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(1505, 14);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(131, 38);
            btnDeleteBook.TabIndex = 4;
            btnDeleteBook.Text = "🗑️ Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(txtSearch);
            mainPanel.Controls.Add(dgvBooks);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 66);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(35, 38, 35, 38);
            mainPanel.Size = new Size(1680, 946);
            mainPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(52, 73, 94);
            txtSearch.Location = new Point(44, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by Title, Author, ISBN, or Category...";
            txtSearch.Size = new Size(438, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.Location = new Point(44, 75);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1592, 825);
            dgvBooks.TabIndex = 1;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 1012);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Name = "BookManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "📚 Book Management - Library System";
            WindowState = FormWindowState.Maximized;
            Load += BookManagementForm_Load;
            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }
    }
}