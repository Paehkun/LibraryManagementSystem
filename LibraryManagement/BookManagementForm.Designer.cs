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
            topPanel = new System.Windows.Forms.Panel();
            mainPanel = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            btnAddBook = new System.Windows.Forms.Button();
            btnEditBook = new System.Windows.Forms.Button();
            btnDeleteBook = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dgvBooks = new System.Windows.Forms.DataGridView();

            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();

            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddBook);
            topPanel.Controls.Add(btnEditBook);
            topPanel.Controls.Add(btnDeleteBook);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1920, 70);
            topPanel.TabIndex = 0;

            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(20, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(100, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.Click += btnBack_Click;

            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(140, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(300, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📚 Book Management";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddBook.ForeColor = System.Drawing.Color.White;
            btnAddBook.Location = new System.Drawing.Point(1400, 15);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new System.Drawing.Size(140, 40);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "➕ Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddBook.Click += btnAddBook_Click;

            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEditBook.ForeColor = System.Drawing.Color.White;
            btnEditBook.Location = new System.Drawing.Point(1560, 15);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new System.Drawing.Size(140, 40);
            btnEditBook.TabIndex = 3;
            btnEditBook.Text = "✏️ Edit Book";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditBook.Click += btnEditBook_Click;

            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeleteBook.ForeColor = System.Drawing.Color.White;
            btnDeleteBook.Location = new System.Drawing.Point(1720, 15);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new System.Drawing.Size(140, 40);
            btnDeleteBook.TabIndex = 4;
            btnDeleteBook.Text = "🗑️ Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteBook.Click += btnDeleteBook_Click;

            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(txtSearch);
            mainPanel.Controls.Add(dgvBooks);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 70);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(40);
            mainPanel.Size = new System.Drawing.Size(1920, 1010);
            mainPanel.TabIndex = 1;

            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.White;
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            txtSearch.Location = new System.Drawing.Point(50, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by Title, Author, ISBN, or Category...";
            txtSearch.Size = new System.Drawing.Size(500, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.BackgroundColor = System.Drawing.Color.White;
            dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvBooks.Location = new System.Drawing.Point(50, 80);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new System.Drawing.Size(1820, 880);
            dgvBooks.TabIndex = 1;

            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Name = "BookManagementForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "📚 Book Management - Library System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += BookManagementForm_Load;

            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }
    }
}