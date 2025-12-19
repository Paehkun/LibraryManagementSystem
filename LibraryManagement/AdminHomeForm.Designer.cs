namespace LibraryManagementSystem
{
    partial class AdminHomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookManagement;
        private System.Windows.Forms.Button btnMemberRecords;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnBookCatalog;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnToggleSidebar;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;

        // Stat cards
        private System.Windows.Forms.Panel cardTotalBooks;
        private System.Windows.Forms.Panel cardBookCopies;
        private System.Windows.Forms.Panel cardMembers;
        private System.Windows.Forms.Panel cardBorrowed;
        private System.Windows.Forms.Panel cardLateReturn;

        // Labels for stats
        private System.Windows.Forms.Label lblTotalBooksTitle;
        private System.Windows.Forms.Label lblBookRowValue;
        private System.Windows.Forms.Label lblBookCopiesTitle;
        private System.Windows.Forms.Label lblTotalBooksValue;
        private System.Windows.Forms.Label lblMembersTitle;
        private System.Windows.Forms.Label lblTotalMembersValue;
        private System.Windows.Forms.Label lblBorrowedTitle;
        private System.Windows.Forms.Label lblBorrowedBooksValue;
        private System.Windows.Forms.Label lblLateReturnTitle;
        private System.Windows.Forms.Label lblLateReturnBooksValue;

        // Section labels
        private System.Windows.Forms.Label lblBorrowedSection;
        private System.Windows.Forms.Label lblLateReturnSection;

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
            leftPanel = new System.Windows.Forms.Panel();
            rightPanel = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            btnToggleSidebar = new System.Windows.Forms.Button();
            btnBookManagement = new System.Windows.Forms.Button();
            btnMemberRecords = new System.Windows.Forms.Button();
            btnUserManagement = new System.Windows.Forms.Button();
            btnBookCatalog = new System.Windows.Forms.Button();
            btnReports = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnBookManagement.Click += btnBookManagement_Click;
            btnMemberRecords.Click += btnMemberRecords_Click;
            btnUserManagement.Click += btnUserManagement_Click;
            btnBookCatalog.Click += btnBookCatalog_Click;
            btnReports.Click += btnReports_Click;
            btnLogout.Click += btnLogout_Click;


            // Initialize stat cards
            cardTotalBooks = new System.Windows.Forms.Panel();
            cardBookCopies = new System.Windows.Forms.Panel();
            cardMembers = new System.Windows.Forms.Panel();
            cardBorrowed = new System.Windows.Forms.Panel();
            cardLateReturn = new System.Windows.Forms.Panel();

            // Initialize labels
            lblTotalBooksTitle = new System.Windows.Forms.Label();
            lblBookRowValue = new System.Windows.Forms.Label();
            lblBookCopiesTitle = new System.Windows.Forms.Label();
            lblTotalBooksValue = new System.Windows.Forms.Label();
            lblMembersTitle = new System.Windows.Forms.Label();
            lblTotalMembersValue = new System.Windows.Forms.Label();
            lblBorrowedTitle = new System.Windows.Forms.Label();
            lblBorrowedBooksValue = new System.Windows.Forms.Label();
            lblLateReturnTitle = new System.Windows.Forms.Label();
            lblLateReturnBooksValue = new System.Windows.Forms.Label();

            lblBorrowedSection = new System.Windows.Forms.Label();
            lblLateReturnSection = new System.Windows.Forms.Label();

            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();

            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            cardTotalBooks.SuspendLayout();
            cardBookCopies.SuspendLayout();
            cardMembers.SuspendLayout();
            cardBorrowed.SuspendLayout();
            cardLateReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();

            // 
            // leftPanel (Sidebar)
            // 
            leftPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            leftPanel.Controls.Add(btnToggleSidebar);
            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(btnBookManagement);
            leftPanel.Controls.Add(btnMemberRecords);
            leftPanel.Controls.Add(btnUserManagement);
            leftPanel.Controls.Add(btnBookCatalog);
            leftPanel.Controls.Add(btnReports);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftPanel.Location = new System.Drawing.Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new System.Drawing.Size(250, 1080);
            leftPanel.TabIndex = 0;

            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            btnToggleSidebar.ForeColor = System.Drawing.Color.White;
            btnToggleSidebar.Location = new System.Drawing.Point(5, 5);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new System.Drawing.Size(50, 50);
            btnToggleSidebar.TabIndex = 0;
            btnToggleSidebar.Text = "☰";
            btnToggleSidebar.UseVisualStyleBackColor = true;
            btnToggleSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleSidebar.Click += BtnToggleSidebar_Click;

            // 
            // lblWelcome
            // 
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.White;
            lblWelcome.Location = new System.Drawing.Point(15, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(220, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Librarian";
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // rightPanel (Main Content)
            // 
            rightPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            rightPanel.Controls.Add(cardTotalBooks);
            rightPanel.Controls.Add(cardBookCopies);
            rightPanel.Controls.Add(cardMembers);
            rightPanel.Controls.Add(cardBorrowed);
            rightPanel.Controls.Add(cardLateReturn);
            rightPanel.Controls.Add(lblBorrowedSection);
            rightPanel.Controls.Add(lblLateReturnSection);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.Add(dataGridView2);
            rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            rightPanel.Location = new System.Drawing.Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new System.Windows.Forms.Padding(30);
            rightPanel.Size = new System.Drawing.Size(1670, 1080);
            rightPanel.TabIndex = 1;

            // 
            // cardTotalBooks (First stat card)
            // 
            cardTotalBooks.BackColor = System.Drawing.Color.White;
            cardTotalBooks.Controls.Add(lblTotalBooksTitle);
            cardTotalBooks.Controls.Add(lblBookRowValue);
            cardTotalBooks.Location = new System.Drawing.Point(50, 40);
            cardTotalBooks.Name = "cardTotalBooks";
            cardTotalBooks.Size = new System.Drawing.Size(280, 140);
            cardTotalBooks.TabIndex = 0;

            // 
            // lblTotalBooksTitle
            // 
            lblTotalBooksTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTotalBooksTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblTotalBooksTitle.Location = new System.Drawing.Point(20, 20);
            lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            lblTotalBooksTitle.Size = new System.Drawing.Size(240, 30);
            lblTotalBooksTitle.TabIndex = 0;
            lblTotalBooksTitle.Text = "📚 Total Books";

            // 
            // lblBookRowValue
            // 
            lblBookRowValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblBookRowValue.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblBookRowValue.Location = new System.Drawing.Point(20, 50);
            lblBookRowValue.Name = "lblBookRowValue";
            lblBookRowValue.Size = new System.Drawing.Size(240, 70);
            lblBookRowValue.TabIndex = 1;
            lblBookRowValue.Text = "0";
            lblBookRowValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cardBookCopies (Second stat card)
            // 
            cardBookCopies.BackColor = System.Drawing.Color.White;
            cardBookCopies.Controls.Add(lblBookCopiesTitle);
            cardBookCopies.Controls.Add(lblTotalBooksValue);
            cardBookCopies.Location = new System.Drawing.Point(360, 40);
            cardBookCopies.Name = "cardBookCopies";
            cardBookCopies.Size = new System.Drawing.Size(280, 140);
            cardBookCopies.TabIndex = 1;

            // 
            // lblBookCopiesTitle
            // 
            lblBookCopiesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBookCopiesTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblBookCopiesTitle.Location = new System.Drawing.Point(20, 20);
            lblBookCopiesTitle.Name = "lblBookCopiesTitle";
            lblBookCopiesTitle.Size = new System.Drawing.Size(240, 30);
            lblBookCopiesTitle.TabIndex = 0;
            lblBookCopiesTitle.Text = "📖 Book Copies";

            // 
            // lblTotalBooksValue
            // 
            lblTotalBooksValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblTotalBooksValue.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            lblTotalBooksValue.Location = new System.Drawing.Point(20, 50);
            lblTotalBooksValue.Name = "lblTotalBooksValue";
            lblTotalBooksValue.Size = new System.Drawing.Size(240, 70);
            lblTotalBooksValue.TabIndex = 1;
            lblTotalBooksValue.Text = "0";
            lblTotalBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cardMembers (Third stat card)
            // 
            cardMembers.BackColor = System.Drawing.Color.White;
            cardMembers.Controls.Add(lblMembersTitle);
            cardMembers.Controls.Add(lblTotalMembersValue);
            cardMembers.Location = new System.Drawing.Point(670, 40);
            cardMembers.Name = "cardMembers";
            cardMembers.Size = new System.Drawing.Size(280, 140);
            cardMembers.TabIndex = 2;

            // 
            // lblMembersTitle
            // 
            lblMembersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblMembersTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblMembersTitle.Location = new System.Drawing.Point(20, 20);
            lblMembersTitle.Name = "lblMembersTitle";
            lblMembersTitle.Size = new System.Drawing.Size(240, 30);
            lblMembersTitle.TabIndex = 0;
            lblMembersTitle.Text = "👥 Total Members";

            // 
            // lblTotalMembersValue
            // 
            lblTotalMembersValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblTotalMembersValue.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            lblTotalMembersValue.Location = new System.Drawing.Point(20, 50);
            lblTotalMembersValue.Name = "lblTotalMembersValue";
            lblTotalMembersValue.Size = new System.Drawing.Size(240, 70);
            lblTotalMembersValue.TabIndex = 1;
            lblTotalMembersValue.Text = "0";
            lblTotalMembersValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cardBorrowed (Fourth stat card)
            // 
            cardBorrowed.BackColor = System.Drawing.Color.White;
            cardBorrowed.Controls.Add(lblBorrowedTitle);
            cardBorrowed.Controls.Add(lblBorrowedBooksValue);
            cardBorrowed.Location = new System.Drawing.Point(980, 40);
            cardBorrowed.Name = "cardBorrowed";
            cardBorrowed.Size = new System.Drawing.Size(280, 140);
            cardBorrowed.TabIndex = 3;

            // 
            // lblBorrowedTitle
            // 
            lblBorrowedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBorrowedTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblBorrowedTitle.Location = new System.Drawing.Point(20, 20);
            lblBorrowedTitle.Name = "lblBorrowedTitle";
            lblBorrowedTitle.Size = new System.Drawing.Size(240, 30);
            lblBorrowedTitle.TabIndex = 0;
            lblBorrowedTitle.Text = "📚 Borrowed Books";

            // 
            // lblBorrowedBooksValue
            // 
            lblBorrowedBooksValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblBorrowedBooksValue.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            lblBorrowedBooksValue.Location = new System.Drawing.Point(20, 50);
            lblBorrowedBooksValue.Name = "lblBorrowedBooksValue";
            lblBorrowedBooksValue.Size = new System.Drawing.Size(240, 70);
            lblBorrowedBooksValue.TabIndex = 1;
            lblBorrowedBooksValue.Text = "0";
            lblBorrowedBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cardLateReturn (Fifth stat card)
            // 
            cardLateReturn.BackColor = System.Drawing.Color.White;
            cardLateReturn.Controls.Add(lblLateReturnTitle);
            cardLateReturn.Controls.Add(lblLateReturnBooksValue);
            cardLateReturn.Location = new System.Drawing.Point(1290, 40);
            cardLateReturn.Name = "cardLateReturn";
            cardLateReturn.Size = new System.Drawing.Size(280, 140);
            cardLateReturn.TabIndex = 4;

            // 
            // lblLateReturnTitle
            // 
            lblLateReturnTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblLateReturnTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblLateReturnTitle.Location = new System.Drawing.Point(20, 20);
            lblLateReturnTitle.Name = "lblLateReturnTitle";
            lblLateReturnTitle.Size = new System.Drawing.Size(240, 30);
            lblLateReturnTitle.TabIndex = 0;
            lblLateReturnTitle.Text = "⚠️ Late Returns";

            // 
            // lblLateReturnBooksValue
            // 
            lblLateReturnBooksValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblLateReturnBooksValue.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            lblLateReturnBooksValue.Location = new System.Drawing.Point(20, 50);
            lblLateReturnBooksValue.Name = "lblLateReturnBooksValue";
            lblLateReturnBooksValue.Size = new System.Drawing.Size(240, 70);
            lblLateReturnBooksValue.TabIndex = 1;
            lblLateReturnBooksValue.Text = "0";
            lblLateReturnBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblBorrowedSection
            // 
            lblBorrowedSection.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblBorrowedSection.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblBorrowedSection.Location = new System.Drawing.Point(50, 220);
            lblBorrowedSection.Name = "lblBorrowedSection";
            lblBorrowedSection.Size = new System.Drawing.Size(900, 40);
            lblBorrowedSection.TabIndex = 5;
            lblBorrowedSection.Text = "📖 Currently Borrowed Books";

            // 
            // dataGridView1
            // 
            dataGridView1.Location = new System.Drawing.Point(50, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(900, 750);
            dataGridView1.TabIndex = 6;

            // 
            // lblLateReturnSection
            // 
            lblLateReturnSection.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblLateReturnSection.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblLateReturnSection.Location = new System.Drawing.Point(1000, 220);
            lblLateReturnSection.Name = "lblLateReturnSection";
            lblLateReturnSection.Size = new System.Drawing.Size(900, 40);
            lblLateReturnSection.TabIndex = 7;
            lblLateReturnSection.Text = "⚠️ Late Return Books";

            // 
            // dataGridView2
            // 
            dataGridView2.Location = new System.Drawing.Point(1000, 270);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(900, 750);
            dataGridView2.TabIndex = 8;

            // 
            // LibrarianHomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "AdminHomeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "📚 Librarian Dashboard - Library Management System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += AdminHomeForm_Load;

            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            cardTotalBooks.ResumeLayout(false);
            cardBookCopies.ResumeLayout(false);
            cardMembers.ResumeLayout(false);
            cardBorrowed.ResumeLayout(false);
            cardLateReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }
    }
}