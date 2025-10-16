namespace LibraryManagementSystem
{
    partial class LibrarianHomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnBookManagement;
        private Button btnMemberRecords;
        private Button btnBookCatalog;
        private Button btnReports;
        private Button btnBorrowReturn;
        private Button btnLogout;

        // Right panel dashboard labels
        private Label lblTotalBooks;
        private Label lblTotalBooksValue;
        private Label lblBorrowedBooks;
        private Label lblLateReturnBooks;
        private Label lblTotalMembers;
        private Label lblTotalMembersValue;

        private Panel leftPanel;
        private Panel rightPanel;

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
            lblWelcome = new Label();
            btnBookManagement = new Button();
            btnMemberRecords = new Button();
            btnBookCatalog = new Button();
            btnReports = new Button();
            btnBorrowReturn = new Button();
            btnLogout = new Button();
            lblTotalBooks = new Label();
            lblTotalBooksValue = new Label();
            lblBorrowedBooks = new Label();
            lblLateReturnBooks = new Label();
            lblTotalMembers = new Label();
            lblTotalMembersValue = new Label();
            leftPanel = new Panel();
            rightPanel = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            roundedLabel1 = new RoundedLabel();
            roundedLabel2 = new RoundedLabel();
            roundedLabel3 = new RoundedLabel();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(200, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Librarian";
            // 
            // btnBookManagement
            // 
            btnBookManagement.BackColor = Color.White;
            btnBookManagement.Font = new Font("Segoe UI", 10F);
            btnBookManagement.Location = new Point(20, 83);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(200, 40);
            btnBookManagement.TabIndex = 1;
            btnBookManagement.Text = "📖 Book Management";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnMemberRecords
            // 
            btnMemberRecords.BackColor = Color.White;
            btnMemberRecords.Font = new Font("Segoe UI", 10F);
            btnMemberRecords.Location = new Point(20, 140);
            btnMemberRecords.Name = "btnMemberRecords";
            btnMemberRecords.Size = new Size(200, 40);
            btnMemberRecords.TabIndex = 2;
            btnMemberRecords.Text = "👥 Member Management";
            btnMemberRecords.UseVisualStyleBackColor = false;
            btnMemberRecords.Click += btnMemberRecords_Click;
            // 
            // btnBookCatalog
            // 
            btnBookCatalog.BackColor = Color.White;
            btnBookCatalog.Font = new Font("Segoe UI", 10F);
            btnBookCatalog.Location = new Point(20, 198);
            btnBookCatalog.Name = "btnBookCatalog";
            btnBookCatalog.Size = new Size(200, 40);
            btnBookCatalog.TabIndex = 3;
            btnBookCatalog.Text = "📚 Catalog";
            btnBookCatalog.UseVisualStyleBackColor = false;
            btnBookCatalog.Click += btnBookCatalog_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.Location = new Point(20, 256);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 40);
            btnReports.TabIndex = 4;
            btnReports.Text = "📊 Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnBorrowReturn
            // 
            btnBorrowReturn.BackColor = Color.White;
            btnBorrowReturn.Font = new Font("Segoe UI", 10F);
            btnBorrowReturn.Location = new Point(20, 316);
            btnBorrowReturn.Name = "btnBorrowReturn";
            btnBorrowReturn.Size = new Size(200, 40);
            btnBorrowReturn.TabIndex = 5;
            btnBorrowReturn.Text = "🔁 Borrow / Return";
            btnBorrowReturn.UseVisualStyleBackColor = false;
            btnBorrowReturn.Click += btnBorrowReturn_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.Location = new Point(20, 375);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.BackColor = Color.White;
            lblTotalBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBooks.Location = new Point(734, 83);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(205, 23);
            lblTotalBooks.TabIndex = 0;
            lblTotalBooks.Text = "📚 Total Book Copies";
            lblTotalBooks.Click += lblTotalBooks_Click;
            // 
            // lblTotalBooksValue
            // 
            lblTotalBooksValue.BackColor = Color.White;
            lblTotalBooksValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalBooksValue.Location = new Point(769, 124);
            lblTotalBooksValue.Name = "lblTotalBooksValue";
            lblTotalBooksValue.Size = new Size(111, 69);
            lblTotalBooksValue.TabIndex = 1;
            lblTotalBooksValue.Text = "0";
            lblTotalBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooks
            // 
            lblBorrowedBooks.BackColor = Color.White;
            lblBorrowedBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBorrowedBooks.Location = new Point(1100, 316);
            lblBorrowedBooks.Name = "lblBorrowedBooks";
            lblBorrowedBooks.Size = new Size(196, 23);
            lblBorrowedBooks.TabIndex = 2;
            lblBorrowedBooks.Text = "📖 Borrowed Books";
            // 
            // lblLateReturnBooks
            // 
            lblLateReturnBooks.BackColor = Color.White;
            lblLateReturnBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLateReturnBooks.Location = new Point(335, 316);
            lblLateReturnBooks.Name = "lblLateReturnBooks";
            lblLateReturnBooks.Size = new Size(157, 23);
            lblLateReturnBooks.TabIndex = 4;
            lblLateReturnBooks.Text = "⏰ Late Return Books:";
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.BackColor = Color.White;
            lblTotalMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembers.Location = new Point(1122, 83);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(186, 23);
            lblTotalMembers.TabIndex = 6;
            lblTotalMembers.Text = "👥 Total Members";
            lblTotalMembers.Click += lblTotalMembers_Click;
            // 
            // lblTotalMembersValue
            // 
            lblTotalMembersValue.BackColor = Color.White;
            lblTotalMembersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalMembersValue.Location = new Point(1156, 124);
            lblTotalMembersValue.Name = "lblTotalMembersValue";
            lblTotalMembersValue.Size = new Size(111, 69);
            lblTotalMembersValue.TabIndex = 7;
            lblTotalMembersValue.Text = "0";
            lblTotalMembersValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(btnBookManagement);
            leftPanel.Controls.Add(btnMemberRecords);
            leftPanel.Controls.Add(btnBookCatalog);
            leftPanel.Controls.Add(btnReports);
            leftPanel.Controls.Add(btnBorrowReturn);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(250, 1181);
            leftPanel.TabIndex = 1;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.PeachPuff;
            rightPanel.Controls.Add(dataGridView2);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(label1);
            rightPanel.Controls.Add(lblTotalBooks);
            rightPanel.Controls.Add(lblTotalBooksValue);
            rightPanel.Controls.Add(lblBorrowedBooks);
            rightPanel.Controls.Add(lblLateReturnBooks);
            rightPanel.Controls.Add(lblTotalMembers);
            rightPanel.Controls.Add(lblTotalMembersValue);
            rightPanel.Controls.Add(roundedLabel1);
            rightPanel.Controls.Add(roundedLabel2);
            rightPanel.Controls.Add(roundedLabel3);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1528, 1181);
            rightPanel.TabIndex = 0;
            rightPanel.Paint += rightPanel_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(898, 400);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(700, 406);
            dataGridView2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(700, 406);
            dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 118);
            label2.Name = "label2";
            label2.Size = new Size(111, 69);
            label2.TabIndex = 9;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(312, 83);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 8;
            label1.Text = "📚 Total Books";
            // 
            // roundedLabel1
            // 
            roundedLabel1.BackColor = Color.White;
            roundedLabel1.BorderColor = Color.White;
            roundedLabel1.BorderRadius = 40;
            roundedLabel1.BorderSize = 2;
            roundedLabel1.ForeColor = Color.Black;
            roundedLabel1.Location = new Point(160, 35);
            roundedLabel1.Name = "roundedLabel1";
            roundedLabel1.Size = new Size(1311, 192);
            roundedLabel1.TabIndex = 10;
            roundedLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedLabel2
            // 
            roundedLabel2.BackColor = Color.White;
            roundedLabel2.BorderColor = Color.White;
            roundedLabel2.BorderRadius = 40;
            roundedLabel2.BorderSize = 2;
            roundedLabel2.ForeColor = Color.Black;
            roundedLabel2.Location = new Point(312, 290);
            roundedLabel2.Name = "roundedLabel2";
            roundedLabel2.Size = new Size(195, 82);
            roundedLabel2.TabIndex = 13;
            roundedLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedLabel3
            // 
            roundedLabel3.BackColor = Color.White;
            roundedLabel3.BorderColor = Color.White;
            roundedLabel3.BorderRadius = 40;
            roundedLabel3.BorderSize = 2;
            roundedLabel3.ForeColor = Color.Black;
            roundedLabel3.Location = new Point(1089, 290);
            roundedLabel3.Name = "roundedLabel3";
            roundedLabel3.Size = new Size(219, 82);
            roundedLabel3.TabIndex = 14;
            roundedLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LibrarianHomeForm
            // 
            ClientSize = new Size(1778, 1181);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "LibrarianHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Librarian Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += LibrarianHomeForm_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
        private Label label2;
        private Label label1;
        private LibraryManagementSystem.RoundedLabel roundedLabel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private RoundedLabel roundedLabel2;
        private RoundedLabel roundedLabel3;
    }
}
