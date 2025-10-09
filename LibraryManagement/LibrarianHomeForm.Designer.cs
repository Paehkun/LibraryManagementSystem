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
        private Label lblBorrowedBooksValue;
        private Label lblLateReturnBooks;
        private Label lblLateReturnBooksValue;
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
            lblBorrowedBooksValue = new Label();
            lblLateReturnBooks = new Label();
            lblLateReturnBooksValue = new Label();
            lblTotalMembers = new Label();
            lblTotalMembersValue = new Label();
            leftPanel = new Panel();
            rightPanel = new Panel();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
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
            lblTotalBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBooks.Location = new Point(208, 83);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(157, 23);
            lblTotalBooks.TabIndex = 0;
            lblTotalBooks.Text = "📚 Total Books:";
            // 
            // lblTotalBooksValue
            // 
            lblTotalBooksValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBooksValue.Location = new Point(208, 106);
            lblTotalBooksValue.Name = "lblTotalBooksValue";
            lblTotalBooksValue.Size = new Size(100, 23);
            lblTotalBooksValue.TabIndex = 1;
            lblTotalBooksValue.Text = "0";
            // 
            // lblBorrowedBooks
            // 
            lblBorrowedBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBorrowedBooks.Location = new Point(620, 256);
            lblBorrowedBooks.Name = "lblBorrowedBooks";
            lblBorrowedBooks.Size = new Size(196, 23);
            lblBorrowedBooks.TabIndex = 2;
            lblBorrowedBooks.Text = "📖 Borrowed Books:";
            // 
            // lblBorrowedBooksValue
            // 
            lblBorrowedBooksValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBorrowedBooksValue.Location = new Point(620, 291);
            lblBorrowedBooksValue.Name = "lblBorrowedBooksValue";
            lblBorrowedBooksValue.Size = new Size(100, 23);
            lblBorrowedBooksValue.TabIndex = 3;
            lblBorrowedBooksValue.Text = "0";
            // 
            // lblLateReturnBooks
            // 
            lblLateReturnBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLateReturnBooks.Location = new Point(208, 256);
            lblLateReturnBooks.Name = "lblLateReturnBooks";
            lblLateReturnBooks.Size = new Size(157, 23);
            lblLateReturnBooks.TabIndex = 4;
            lblLateReturnBooks.Text = "⏰ Late Return Books:";
            // 
            // lblLateReturnBooksValue
            // 
            lblLateReturnBooksValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLateReturnBooksValue.Location = new Point(208, 291);
            lblLateReturnBooksValue.Name = "lblLateReturnBooksValue";
            lblLateReturnBooksValue.Size = new Size(100, 23);
            lblLateReturnBooksValue.TabIndex = 5;
            lblLateReturnBooksValue.Text = "0";
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembers.Location = new Point(620, 83);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(186, 23);
            lblTotalMembers.TabIndex = 6;
            lblTotalMembers.Text = "👥 Total Members:";
            lblTotalMembers.Click += lblTotalMembers_Click;
            // 
            // lblTotalMembersValue
            // 
            lblTotalMembersValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembersValue.Location = new Point(620, 106);
            lblTotalMembersValue.Name = "lblTotalMembersValue";
            lblTotalMembersValue.Size = new Size(100, 23);
            lblTotalMembersValue.TabIndex = 7;
            lblTotalMembersValue.Text = "0";
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Beige;
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
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.PeachPuff;
            rightPanel.Controls.Add(lblTotalBooks);
            rightPanel.Controls.Add(lblTotalBooksValue);
            rightPanel.Controls.Add(lblBorrowedBooks);
            rightPanel.Controls.Add(lblBorrowedBooksValue);
            rightPanel.Controls.Add(lblLateReturnBooks);
            rightPanel.Controls.Add(lblLateReturnBooksValue);
            rightPanel.Controls.Add(lblTotalMembers);
            rightPanel.Controls.Add(lblTotalMembersValue);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1528, 1181);
            rightPanel.TabIndex = 0;
            rightPanel.Paint += rightPanel_Paint;
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
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
