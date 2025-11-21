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
        private Button btnToggleSidebar;

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
            btnToggleSidebar = new Button();
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
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            lblBookRow = new Label();
            label1 = new Label();
            roundedLabel1 = new RoundedLabel();
            roundedLabel2 = new RoundedLabel();
            roundedLabel3 = new RoundedLabel();
            roundedLabel4 = new RoundedLabel();
            roundedLabel5 = new RoundedLabel();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(42, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(202, 35);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Librarian";
            // 
            // btnBookManagement
            // 
            btnBookManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBookManagement.Location = new Point(0, 0);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(75, 23);
            btnBookManagement.TabIndex = 1;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnMemberRecords
            // 
            btnMemberRecords.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMemberRecords.Location = new Point(0, 0);
            btnMemberRecords.Name = "btnMemberRecords";
            btnMemberRecords.Size = new Size(75, 23);
            btnMemberRecords.TabIndex = 2;
            btnMemberRecords.Click += btnMemberRecords_Click;
            // 
            // btnBookCatalog
            // 
            btnBookCatalog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBookCatalog.Location = new Point(0, 0);
            btnBookCatalog.Name = "btnBookCatalog";
            btnBookCatalog.Size = new Size(75, 23);
            btnBookCatalog.TabIndex = 3;
            btnBookCatalog.Click += btnBookCatalog_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReports.Location = new Point(0, 0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 23);
            btnReports.TabIndex = 4;
            btnReports.Click += btnReports_Click;
            // 
            // btnBorrowReturn
            // 
            btnBorrowReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrowReturn.Location = new Point(0, 0);
            btnBorrowReturn.Name = "btnBorrowReturn";
            btnBorrowReturn.Size = new Size(75, 23);
            btnBorrowReturn.TabIndex = 5;
            btnBorrowReturn.Click += btnBorrowReturn_Click;
            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatStyle = FlatStyle.Flat;
            btnToggleSidebar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnToggleSidebar.Location = new Point(5, 5);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new Size(50, 50);
            btnToggleSidebar.TabIndex = 7;
            btnToggleSidebar.Text = "≡";
            btnToggleSidebar.Click += BtnToggleSidebar_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 6;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.BackColor = Color.White;
            lblTotalBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBooks.Location = new Point(743, 80);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(220, 30);
            lblTotalBooks.TabIndex = 4;
            lblTotalBooks.Text = "📚 Total Book Copies";
            // 
            // lblTotalBooksValue
            // 
            lblTotalBooksValue.BackColor = Color.White;
            lblTotalBooksValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalBooksValue.Location = new Point(785, 120);
            lblTotalBooksValue.Name = "lblTotalBooksValue";
            lblTotalBooksValue.Size = new Size(120, 60);
            lblTotalBooksValue.TabIndex = 5;
            lblTotalBooksValue.Text = "0";
            lblTotalBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooks
            // 
            lblBorrowedBooks.BackColor = Color.White;
            lblBorrowedBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBorrowedBooks.Location = new Point(320, 279);
            lblBorrowedBooks.Name = "lblBorrowedBooks";
            lblBorrowedBooks.Size = new Size(250, 30);
            lblBorrowedBooks.TabIndex = 6;
            lblBorrowedBooks.Text = "👥 Total Borrowed Books";
            // 
            // lblBorrowedBooksValue
            // 
            lblBorrowedBooksValue.BackColor = Color.White;
            lblBorrowedBooksValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblBorrowedBooksValue.Location = new Point(379, 320);
            lblBorrowedBooksValue.Name = "lblBorrowedBooksValue";
            lblBorrowedBooksValue.Size = new Size(120, 60);
            lblBorrowedBooksValue.TabIndex = 7;
            lblBorrowedBooksValue.Text = "0";
            lblBorrowedBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLateReturnBooks
            // 
            lblLateReturnBooks.BackColor = Color.White;
            lblLateReturnBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLateReturnBooks.Location = new Point(1151, 279);
            lblLateReturnBooks.Name = "lblLateReturnBooks";
            lblLateReturnBooks.Size = new Size(195, 30);
            lblLateReturnBooks.TabIndex = 8;
            lblLateReturnBooks.Text = "👥 Total Late Return";
            // 
            // lblLateReturnBooksValue
            // 
            lblLateReturnBooksValue.BackColor = Color.White;
            lblLateReturnBooksValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblLateReturnBooksValue.Location = new Point(1192, 320);
            lblLateReturnBooksValue.Name = "lblLateReturnBooksValue";
            lblLateReturnBooksValue.Size = new Size(120, 60);
            lblLateReturnBooksValue.TabIndex = 9;
            lblLateReturnBooksValue.Text = "0";
            lblLateReturnBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.BackColor = Color.White;
            lblTotalMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembers.Location = new Point(1160, 80);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(176, 30);
            lblTotalMembers.TabIndex = 10;
            lblTotalMembers.Text = "👥 Total Members";
            // 
            // lblTotalMembersValue
            // 
            lblTotalMembersValue.BackColor = Color.White;
            lblTotalMembersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalMembersValue.Location = new Point(1192, 120);
            lblTotalMembersValue.Name = "lblTotalMembersValue";
            lblTotalMembersValue.Size = new Size(120, 60);
            lblTotalMembersValue.TabIndex = 11;
            lblTotalMembersValue.Text = "0";
            lblTotalMembersValue.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalMembersValue.Click += lblTotalMembersValue_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.RoyalBlue;
            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(btnBookManagement);
            leftPanel.Controls.Add(btnMemberRecords);
            leftPanel.Controls.Add(btnBookCatalog);
            leftPanel.Controls.Add(btnReports);
            leftPanel.Controls.Add(btnBorrowReturn);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnToggleSidebar);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(250, 1181);
            leftPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(245, 247, 250);
            rightPanel.Controls.Add(dataGridView2);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.Add(lblBookRow);
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
            rightPanel.Controls.Add(roundedLabel2);
            rightPanel.Controls.Add(roundedLabel3);
            rightPanel.Controls.Add(roundedLabel4);
            rightPanel.Controls.Add(roundedLabel5);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1528, 1181);
            rightPanel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Location = new Point(900, 430);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(700, 400);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Location = new Point(80, 430);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(700, 400);
            dataGridView1.TabIndex = 1;
            // 
            // lblBookRow
            // 
            lblBookRow.BackColor = Color.White;
            lblBookRow.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblBookRow.Location = new Point(379, 120);
            lblBookRow.Name = "lblBookRow";
            lblBookRow.Size = new Size(120, 60);
            lblBookRow.TabIndex = 2;
            lblBookRow.Text = "0";
            lblBookRow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(350, 80);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 3;
            label1.Text = "📚 Total Books";
            // 
            // roundedLabel1
            // 
            roundedLabel1.BackColor = Color.White;
            roundedLabel1.BorderColor = Color.White;
            roundedLabel1.BorderRadius = 30;
            roundedLabel1.BorderSize = 0;
            roundedLabel1.ForeColor = Color.Black;
            roundedLabel1.Location = new Point(290, 50);
            roundedLabel1.Name = "roundedLabel1";
            roundedLabel1.Size = new Size(300, 160);
            roundedLabel1.TabIndex = 12;
            // 
            // roundedLabel2
            // 
            roundedLabel2.BackColor = Color.White;
            roundedLabel2.BorderColor = Color.White;
            roundedLabel2.BorderRadius = 30;
            roundedLabel2.BorderSize = 0;
            roundedLabel2.ForeColor = Color.Black;
            roundedLabel2.Location = new Point(700, 50);
            roundedLabel2.Name = "roundedLabel2";
            roundedLabel2.Size = new Size(300, 160);
            roundedLabel2.TabIndex = 13;
            // 
            // roundedLabel3
            // 
            roundedLabel3.BackColor = Color.White;
            roundedLabel3.BorderColor = Color.White;
            roundedLabel3.BorderRadius = 30;
            roundedLabel3.BorderSize = 0;
            roundedLabel3.ForeColor = Color.Black;
            roundedLabel3.Location = new Point(1100, 50);
            roundedLabel3.Name = "roundedLabel3";
            roundedLabel3.Size = new Size(300, 160);
            roundedLabel3.TabIndex = 14;
            // 
            // roundedLabel4
            // 
            roundedLabel4.BackColor = Color.White;
            roundedLabel4.BorderColor = Color.White;
            roundedLabel4.BorderRadius = 30;
            roundedLabel4.BorderSize = 0;
            roundedLabel4.ForeColor = Color.Black;
            roundedLabel4.Location = new Point(290, 250);
            roundedLabel4.Name = "roundedLabel4";
            roundedLabel4.Size = new Size(300, 160);
            roundedLabel4.TabIndex = 15;
            // 
            // roundedLabel5
            // 
            roundedLabel5.BackColor = Color.White;
            roundedLabel5.BorderColor = Color.White;
            roundedLabel5.BorderRadius = 30;
            roundedLabel5.BorderSize = 0;
            roundedLabel5.ForeColor = Color.Black;
            roundedLabel5.Location = new Point(1100, 250);
            roundedLabel5.Name = "roundedLabel5";
            roundedLabel5.Size = new Size(300, 160);
            roundedLabel5.TabIndex = 16;
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

        private Label lblBookRow;
        private Label label1;
        private LibraryManagementSystem.RoundedLabel roundedLabel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private RoundedLabel roundedLabel2;
        private RoundedLabel roundedLabel3;
        private RoundedLabel roundedLabel4;
        private RoundedLabel roundedLabel5;

    }
}
