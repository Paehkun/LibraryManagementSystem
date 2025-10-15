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
            label2 = new Label();
            label1 = new Label();
            roundedLabel1 = new RoundedLabel();
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
            lblTotalBooks.Location = new Point(620, 83);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(205, 23);
            lblTotalBooks.TabIndex = 0;
            lblTotalBooks.Text = "📚 Total Book Copies";
            lblTotalBooks.Click += lblTotalBooks_Click;
            // 
            // lblTotalBooksValue
            // 
            lblTotalBooksValue.BackColor = Color.SeaShell;
            lblTotalBooksValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBooksValue.Location = new Point(655, 124);
            lblTotalBooksValue.Name = "lblTotalBooksValue";
            lblTotalBooksValue.Size = new Size(111, 69);
            lblTotalBooksValue.TabIndex = 1;
            lblTotalBooksValue.Text = "0";
            lblTotalBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooks
            // 
            lblBorrowedBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBorrowedBooks.Location = new Point(620, 315);
            lblBorrowedBooks.Name = "lblBorrowedBooks";
            lblBorrowedBooks.Size = new Size(196, 23);
            lblBorrowedBooks.TabIndex = 2;
            lblBorrowedBooks.Text = "📖 Borrowed Books";
            // 
            // lblBorrowedBooksValue
            // 
            lblBorrowedBooksValue.BackColor = Color.SeaShell;
            lblBorrowedBooksValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBorrowedBooksValue.Location = new Point(655, 359);
            lblBorrowedBooksValue.Name = "lblBorrowedBooksValue";
            lblBorrowedBooksValue.Size = new Size(111, 69);
            lblBorrowedBooksValue.TabIndex = 3;
            lblBorrowedBooksValue.Text = "0";
            lblBorrowedBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLateReturnBooks
            // 
            lblLateReturnBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLateReturnBooks.Location = new Point(208, 315);
            lblLateReturnBooks.Name = "lblLateReturnBooks";
            lblLateReturnBooks.Size = new Size(157, 23);
            lblLateReturnBooks.TabIndex = 4;
            lblLateReturnBooks.Text = "⏰ Late Return Books:";
            // 
            // lblLateReturnBooksValue
            // 
            lblLateReturnBooksValue.BackColor = Color.SeaShell;
            lblLateReturnBooksValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLateReturnBooksValue.Location = new Point(231, 359);
            lblLateReturnBooksValue.Name = "lblLateReturnBooksValue";
            lblLateReturnBooksValue.Size = new Size(111, 69);
            lblLateReturnBooksValue.TabIndex = 5;
            lblLateReturnBooksValue.Text = "0";
            lblLateReturnBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembers.Location = new Point(984, 83);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(186, 23);
            lblTotalMembers.TabIndex = 6;
            lblTotalMembers.Text = "👥 Total Members";
            lblTotalMembers.Click += lblTotalMembers_Click;
            // 
            // lblTotalMembersValue
            // 
            lblTotalMembersValue.BackColor = Color.SeaShell;
            lblTotalMembersValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembersValue.Location = new Point(1018, 124);
            lblTotalMembersValue.Name = "lblTotalMembersValue";
            lblTotalMembersValue.Size = new Size(111, 69);
            lblTotalMembersValue.TabIndex = 7;
            lblTotalMembersValue.Text = "0";
            lblTotalMembersValue.TextAlign = ContentAlignment.MiddleCenter;
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
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(label1);
            rightPanel.Controls.Add(lblTotalBooks);
            rightPanel.Controls.Add(lblTotalBooksValue);
            rightPanel.Controls.Add(lblBorrowedBooks);
            rightPanel.Controls.Add(lblBorrowedBooksValue);
            rightPanel.Controls.Add(lblLateReturnBooks);
            rightPanel.Controls.Add(lblLateReturnBooksValue);
            rightPanel.Controls.Add(lblTotalMembers);
            rightPanel.Controls.Add(lblTotalMembersValue);
            rightPanel.Controls.Add(roundedLabel1);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1528, 1181);
            rightPanel.TabIndex = 0;
            rightPanel.Paint += rightPanel_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(231, 124);
            label2.Name = "label2";
            label2.Size = new Size(111, 69);
            label2.TabIndex = 9;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(208, 89);
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
            roundedLabel1.Location = new Point(160, 35);
            roundedLabel1.Name = "roundedLabel1";
            roundedLabel1.Size = new Size(1036, 427);
            roundedLabel1.TabIndex = 10;
            roundedLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            ResumeLayout(false);
        }
        private Label label2;
        private Label label1;
        private LibraryManagementSystem.RoundedLabel roundedLabel1;
    }
}
