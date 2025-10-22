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
            lblBookRow = new Label();
            label1 = new Label();
            roundedLabel1 = new RoundedLabel();
            roundedLabel2 = new RoundedLabel();
            roundedLabel3 = new RoundedLabel();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // ==============================
            // 📌 LEFT PANEL
            // ==============================
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(btnBookManagement);
            leftPanel.Controls.Add(btnMemberRecords);
            leftPanel.Controls.Add(btnBookCatalog);
            leftPanel.Controls.Add(btnReports);
            leftPanel.Controls.Add(btnBorrowReturn);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Size = new Size(250, 1181);
            leftPanel.Name = "leftPanel";

            // Welcome label
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Size = new Size(220, 35);
            lblWelcome.Text = "Welcome, Librarian";

            // Sidebar buttons (uniform styling)
            int btnWidth = 200;
            int btnHeight = 40;
            int startY = 80;
            int spacing = 60;

            Button[] buttons = { btnBookManagement, btnMemberRecords, btnBookCatalog, btnReports, btnBorrowReturn, btnLogout };
            string[] texts = { "📖 Book Management", "👥 Member Management", "📚 Catalog", "📊 Reports", "🔁 Borrow / Return", "🚪 Logout" };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.White;
                buttons[i].Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                buttons[i].Size = new Size(btnWidth, btnHeight);
                buttons[i].Location = new Point(20, startY + (i * spacing));
                buttons[i].Text = texts[i];
                buttons[i].UseVisualStyleBackColor = true;
            }

            btnBookManagement.Click += btnBookManagement_Click;
            btnMemberRecords.Click += btnMemberRecords_Click;
            btnBookCatalog.Click += btnBookCatalog_Click;
            btnReports.Click += btnReports_Click;
            btnBorrowReturn.Click += btnBorrowReturn_Click;
            btnLogout.Click += btnLogout_Click;

            // ==============================
            // 📌 RIGHT PANEL (DASHBOARD)
            // ==============================
            rightPanel.BackColor = Color.WhiteSmoke;  // clean background like Book Management
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Controls.Add(dataGridView2);
            rightPanel.Controls.Add(dataGridView1);
            rightPanel.Controls.Add(lblBookRow);
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

            // ==============================
            // 📊 CARD 1 — Total Books
            // ==============================
            roundedLabel1.BackColor = Color.White;
            roundedLabel1.BorderColor = Color.White;
            roundedLabel1.BorderRadius = 30;
            roundedLabel1.BorderSize = 0;
            roundedLabel1.Location = new Point(150, 50);
            roundedLabel1.Size = new Size(400, 160);

            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.BackColor = Color.White;
            label1.Location = new Point(270, 80);
            label1.Size = new Size(200, 30);
            label1.Text = "📚 Total Books";

            lblBookRow.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblBookRow.BackColor = Color.White;
            lblBookRow.Location = new Point(310, 120);
            lblBookRow.Size = new Size(120, 60);
            lblBookRow.TextAlign = ContentAlignment.MiddleCenter;
            lblBookRow.Text = "0";

            // ==============================
            // 📊 CARD 2 — Total Book Copies
            // ==============================
            lblTotalBooks.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBooks.BackColor = Color.White;
            lblTotalBooks.Location = new Point(730, 80);
            lblTotalBooks.Size = new Size(220, 30);
            lblTotalBooks.Text = "📚 Total Book Copies";

            lblTotalBooksValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalBooksValue.BackColor = Color.White;
            lblTotalBooksValue.Location = new Point(780, 120);
            lblTotalBooksValue.Size = new Size(120, 60);
            lblTotalBooksValue.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalBooksValue.Text = "0";

            roundedLabel2.BackColor = Color.White;
            roundedLabel2.BorderColor = Color.White;
            roundedLabel2.BorderRadius = 30;
            roundedLabel2.BorderSize = 0;
            roundedLabel2.Location = new Point(700, 50);
            roundedLabel2.Size = new Size(300, 160);

            // ==============================
            // 📊 CARD 3 — Total Members
            // ==============================
            lblTotalMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalMembers.BackColor = Color.White;
            lblTotalMembers.Location = new Point(1120, 80);
            lblTotalMembers.Size = new Size(220, 30);
            lblTotalMembers.Text = "👥 Total Members";

            lblTotalMembersValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalMembersValue.BackColor = Color.White;
            lblTotalMembersValue.Location = new Point(1160, 120);
            lblTotalMembersValue.Size = new Size(120, 60);
            lblTotalMembersValue.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalMembersValue.Text = "0";

            roundedLabel3.BackColor = Color.White;
            roundedLabel3.BorderColor = Color.White;
            roundedLabel3.BorderRadius = 30;
            roundedLabel3.BorderSize = 0;
            roundedLabel3.Location = new Point(1100, 50);
            roundedLabel3.Size = new Size(300, 160);

            // ==============================
            // 📋 Data Grids (Optional Section)
            // ==============================
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Location = new Point(120, 300);
            dataGridView1.Size = new Size(700, 400);

            dataGridView2.Location = new Point(900, 300);
            dataGridView2.Size = new Size(700, 400);

            // ==============================
            // 📌 FORM SETTINGS
            // ==============================
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
    }
}
