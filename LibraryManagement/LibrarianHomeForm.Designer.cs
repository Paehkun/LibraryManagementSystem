namespace LibraryManagementSystem
{
    partial class LibrarianHomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnBookManagement;
        private Button btnBorrowReturn;
        private Button btnMemberRecords;
        private Button btnBookCatalog;
        private Button btnReports;
        private Button btnLogout;

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
            btnBorrowReturn = new Button();
            btnMemberRecords = new Button();
            btnBookCatalog = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 35);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Librarian";
            // 
            // btnBookManagement
            // 
            btnBookManagement.Font = new Font("Segoe UI", 10F);
            btnBookManagement.Location = new Point(35, 80);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(200, 40);
            btnBookManagement.TabIndex = 1;
            btnBookManagement.Text = "📖 Book Management";
            btnBookManagement.UseVisualStyleBackColor = true;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnBorrowReturn
            // 
            btnBorrowReturn.Font = new Font("Segoe UI", 10F);
            btnBorrowReturn.Location = new Point(35, 130);
            btnBorrowReturn.Name = "btnBorrowReturn";
            btnBorrowReturn.Size = new Size(200, 40);
            btnBorrowReturn.TabIndex = 2;
            btnBorrowReturn.Text = "🔄 Borrow / Return";
            btnBorrowReturn.UseVisualStyleBackColor = true;
            btnBorrowReturn.Click += btnBorrowReturn_Click;
            // 
            // btnMemberRecords
            // 
            btnMemberRecords.Font = new Font("Segoe UI", 10F);
            btnMemberRecords.Location = new Point(35, 180);
            btnMemberRecords.Name = "btnMemberRecords";
            btnMemberRecords.Size = new Size(200, 40);
            btnMemberRecords.TabIndex = 3;
            btnMemberRecords.Text = "👥 Member Records";
            btnMemberRecords.UseVisualStyleBackColor = true;
            btnMemberRecords.Click += btnMemberRecords_Click;
            // 
            // btnBookCatalog
            // 
            btnBookCatalog.Font = new Font("Segoe UI", 10F);
            btnBookCatalog.Location = new Point(35, 230);
            btnBookCatalog.Name = "btnBookCatalog";
            btnBookCatalog.Size = new Size(200, 40);
            btnBookCatalog.TabIndex = 4;
            btnBookCatalog.Text = "🔍 Books Catalog";
            btnBookCatalog.UseVisualStyleBackColor = true;
            btnBookCatalog.Click += btnBookCatalog_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.Location = new Point(35, 280);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 40);
            btnReports.TabIndex = 5;
            btnReports.Text = "📊 Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.Location = new Point(35, 351);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "🚪 Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // LibrarianHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 435);
            Controls.Add(btnLogout);
            Controls.Add(btnBookCatalog);
            Controls.Add(btnMemberRecords);
            Controls.Add(btnBorrowReturn);
            Controls.Add(btnReports);
            Controls.Add(btnBookManagement);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LibrarianHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - Librarian Dashboard";
            Load += LibrarianHomeForm_Load;
            ResumeLayout(false);
        }
    }
}
