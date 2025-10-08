using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

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
            dgvBooks = new DataGridView();
            lblTitle = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.LightSteelBlue;
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
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.Location = new Point(25, 280);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 35);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteBook.Location = new Point(25, 200);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(200, 40);
            btnDeleteBook.TabIndex = 1;
            btnDeleteBook.Text = "🗑️ Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditBook.Location = new Point(25, 140);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(200, 40);
            btnEditBook.TabIndex = 2;
            btnEditBook.Text = "✏️ Edit Book";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddBook.Location = new Point(25, 80);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(200, 40);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "➕ Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.WhiteSmoke;
            rightPanel.Controls.Add(dgvBooks);
            rightPanel.Controls.Add(lblTitle);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1758, 1181);
            rightPanel.TabIndex = 0;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.Location = new Point(283, 80);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.Size = new Size(1133, 872);
            dgvBooks.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 35);
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
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
