namespace LibraryManagementSystem
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSidebar;
        private Panel panelHeader;
        private Label lblTitle;
        private Button btnBooks;
        private Button btnMembers;
        private Button btnBorrowReturn;
        private Button btnReports;
        private Button btnLogout;
        private Panel panelMain;

        private void InitializeComponent()
        {
            this.panelSidebar = new Panel();
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.btnBooks = new Button();
            this.btnMembers = new Button();
            this.btnBorrowReturn = new Button();
            this.btnReports = new Button();
            this.btnLogout = new Button();
            this.panelMain = new Panel();
            this.SuspendLayout();

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 180;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnBorrowReturn);
            this.panelSidebar.Controls.Add(this.btnMembers);
            this.panelSidebar.Controls.Add(this.btnBooks);

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(35, 35, 50);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.Text = "Library Management System";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);

            // btnBooks
            this.btnBooks.Text = "Books";
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(70, 70, 90);
            this.btnBooks.FlatStyle = FlatStyle.Flat;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.Location = new System.Drawing.Point(10, 40);
            this.btnBooks.Size = new System.Drawing.Size(160, 40);

            // btnMembers
            this.btnMembers.Text = "Members";
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.BackColor = System.Drawing.Color.FromArgb(70, 70, 90);
            this.btnMembers.FlatStyle = FlatStyle.Flat;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.Location = new System.Drawing.Point(10, 90);
            this.btnMembers.Size = new System.Drawing.Size(160, 40);

            // btnBorrowReturn
            this.btnBorrowReturn.Text = "Borrow / Return";
            this.btnBorrowReturn.ForeColor = System.Drawing.Color.White;
            this.btnBorrowReturn.BackColor = System.Drawing.Color.FromArgb(70, 70, 90);
            this.btnBorrowReturn.FlatStyle = FlatStyle.Flat;
            this.btnBorrowReturn.FlatAppearance.BorderSize = 0;
            this.btnBorrowReturn.Location = new System.Drawing.Point(10, 140);
            this.btnBorrowReturn.Size = new System.Drawing.Size(160, 40);

            // btnReports
            this.btnReports.Text = "Reports";
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(70, 70, 90);
            this.btnReports.FlatStyle = FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.Location = new System.Drawing.Point(10, 190);
            this.btnReports.Size = new System.Drawing.Size(160, 40);

            // btnLogout
            this.btnLogout.Text = "Logout";
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(70, 70, 90);
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location = new System.Drawing.Point(10, 400);
            this.btnLogout.Size = new System.Drawing.Size(160, 40);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelMain
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;

            // HomeForm
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
        }
    }
}
