namespace LibraryManagementSystem
{
    partial class AdminHomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWelcome;
        private Button btnManageBooks;
        private Button btnManageUsers;
        private Button btnViewReports;
        private Button btnLogout;

        // Dashboard labels
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
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label lblBookRow;
        private Label label1;

        private RoundedLabel roundedLabel1;
        private RoundedLabel roundedLabel2;
        private RoundedLabel roundedLabel3;
        private RoundedLabel roundedLabel4;
        private RoundedLabel roundedLabel5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnManageBooks = new Button();
            btnManageUsers = new Button();
            btnViewReports = new Button();
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            lblBookRow = new Label();
            label1 = new Label();

            roundedLabel1 = new RoundedLabel();
            roundedLabel2 = new RoundedLabel();
            roundedLabel3 = new RoundedLabel();
            roundedLabel4 = new RoundedLabel();
            roundedLabel5 = new RoundedLabel();

            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();

            // ==============================
            // LEFT PANEL
            // ==============================
            leftPanel.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            leftPanel.Controls.Add(lblWelcome);
            leftPanel.Controls.Add(btnManageBooks);
            leftPanel.Controls.Add(btnManageUsers);
            leftPanel.Controls.Add(btnViewReports);
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Size = new System.Drawing.Size(250, 900);

            // Welcome label
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.Black;
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            lblWelcome.Size = new System.Drawing.Size(220, 35);
            lblWelcome.Text = "Welcome, Admin";

            // Sidebar buttons
            Button[] buttons = { btnManageBooks, btnManageUsers, btnViewReports, btnLogout };
            string[] texts = { "📚 Manage Books", "👤 Manage Users", "📊 View Reports", "🚪 Logout" };
            int btnWidth = 200, btnHeight = 40, startY = 80, spacing = 68;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = System.Drawing.Color.White;
                buttons[i].Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                buttons[i].Size = new System.Drawing.Size(btnWidth, btnHeight);
                buttons[i].Location = new System.Drawing.Point(20, startY + i * spacing);
                buttons[i].Text = texts[i];
                buttons[i].UseVisualStyleBackColor = false;
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].ForeColor = System.Drawing.Color.Black;
                buttons[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }

            btnManageBooks.Click += btnManageBooks_Click;
            btnManageUsers.Click += btnManageUsers_Click;
            btnViewReports.Click += btnViewReports_Click;
            btnLogout.Click += btnLogout_Click;

            // ==============================
            // RIGHT PANEL (Dashboard)
            // ==============================
            rightPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            rightPanel.Dock = DockStyle.Fill;
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

            // ==============================
            // CARD 1 — Total Books
            // ==============================
            roundedLabel1.BackColor = System.Drawing.Color.White;
            roundedLabel1.BorderColor = System.Drawing.Color.White;
            roundedLabel1.BorderRadius = 30;
            roundedLabel1.BorderSize = 0;
            roundedLabel1.Location = new System.Drawing.Point(290, 50);
            roundedLabel1.Size = new System.Drawing.Size(300, 160);

            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label1.BackColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(350, 80);
            label1.Size = new System.Drawing.Size(200, 30);
            label1.Text = "📚 Total Books";

            lblBookRow.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblBookRow.BackColor = System.Drawing.Color.White;
            lblBookRow.Location = new System.Drawing.Point(350, 120);
            lblBookRow.Size = new System.Drawing.Size(120, 60);
            lblBookRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblBookRow.Text = "0";

            // ==============================
            // CARD 2 — Total Book Copies
            // ==============================
            lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTotalBooks.BackColor = System.Drawing.Color.White;
            lblTotalBooks.Location = new System.Drawing.Point(730, 80);
            lblTotalBooks.Size = new System.Drawing.Size(220, 30);
            lblTotalBooks.Text = "📚 Total Book Copies";

            lblTotalBooksValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblTotalBooksValue.BackColor = System.Drawing.Color.White;
            lblTotalBooksValue.Location = new System.Drawing.Point(780, 120);
            lblTotalBooksValue.Size = new System.Drawing.Size(120, 60);
            lblTotalBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTotalBooksValue.Text = "0";

            roundedLabel2.BackColor = System.Drawing.Color.White;
            roundedLabel2.BorderColor = System.Drawing.Color.White;
            roundedLabel2.BorderRadius = 30;
            roundedLabel2.BorderSize = 0;
            roundedLabel2.Location = new System.Drawing.Point(700, 50);
            roundedLabel2.Size = new System.Drawing.Size(300, 160);

            // ==============================
            // CARD 3 — Total Members
            // ==============================
            lblTotalMembers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTotalMembers.BackColor = System.Drawing.Color.White;
            lblTotalMembers.Location = new System.Drawing.Point(1120, 80);
            lblTotalMembers.Size = new System.Drawing.Size(220, 30);
            lblTotalMembers.Text = "👥 Total Members";

            lblTotalMembersValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblTotalMembersValue.BackColor = System.Drawing.Color.White;
            lblTotalMembersValue.Location = new System.Drawing.Point(1160, 120);
            lblTotalMembersValue.Size = new System.Drawing.Size(120, 60);
            lblTotalMembersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTotalMembersValue.Text = "0";

            roundedLabel3.BackColor = System.Drawing.Color.White;
            roundedLabel3.BorderColor = System.Drawing.Color.White;
            roundedLabel3.BorderRadius = 30;
            roundedLabel3.BorderSize = 0;
            roundedLabel3.Location = new System.Drawing.Point(1100, 50);
            roundedLabel3.Size = new System.Drawing.Size(300, 160);

            // ==============================
            // CARD 4 — Borrowed Books
            // ==============================
            lblBorrowedBooks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblBorrowedBooks.BackColor = System.Drawing.Color.White;
            lblBorrowedBooks.Location = new System.Drawing.Point(320, 270);
            lblBorrowedBooks.Size = new System.Drawing.Size(250, 30);
            lblBorrowedBooks.Text = "👥 Total Borrowed Books";

            lblBorrowedBooksValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblBorrowedBooksValue.BackColor = System.Drawing.Color.White;
            lblBorrowedBooksValue.Location = new System.Drawing.Point(370, 320);
            lblBorrowedBooksValue.Size = new System.Drawing.Size(120, 60);
            lblBorrowedBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblBorrowedBooksValue.Text = "0";

            roundedLabel4.BackColor = System.Drawing.Color.White;
            roundedLabel4.BorderColor = System.Drawing.Color.White;
            roundedLabel4.BorderRadius = 30;
            roundedLabel4.BorderSize = 0;
            roundedLabel4.Location = new System.Drawing.Point(290, 250);
            roundedLabel4.Size = new System.Drawing.Size(300, 160);

            // ==============================
            // CARD 5 — Late Return Books
            // ==============================
            lblLateReturnBooks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblLateReturnBooks.BackColor = System.Drawing.Color.White;
            lblLateReturnBooks.Location = new System.Drawing.Point(1120, 280);
            lblLateReturnBooks.Size = new System.Drawing.Size(220, 30);
            lblLateReturnBooks.Text = "👥 Total Late Return";

            lblLateReturnBooksValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblLateReturnBooksValue.BackColor = System.Drawing.Color.White;
            lblLateReturnBooksValue.Location = new System.Drawing.Point(1160, 320);
            lblLateReturnBooksValue.Size = new System.Drawing.Size(120, 60);
            lblLateReturnBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblLateReturnBooksValue.Text = "0";

            roundedLabel5.BackColor = System.Drawing.Color.White;
            roundedLabel5.BorderColor = System.Drawing.Color.White;
            roundedLabel5.BorderRadius = 30;
            roundedLabel5.BorderSize = 0;
            roundedLabel5.Location = new System.Drawing.Point(1100, 250);
            roundedLabel5.Size = new System.Drawing.Size(300, 160);

            // ==============================
            // DataGridViews
            // ==============================
            dataGridView1.Location = new System.Drawing.Point(80, 430);
            dataGridView1.Size = new System.Drawing.Size(700, 400);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;

            dataGridView2.Location = new System.Drawing.Point(900, 430);
            dataGridView2.Size = new System.Drawing.Size(700, 400);
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;

            // ==============================
            // FORM SETTINGS
            // ==============================
            ClientSize = new System.Drawing.Size(1778, 900);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "AdminHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminHomeForm_Load;

            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }
    }
}
