namespace LibraryManagement
{
    partial class borrowANDreturn
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            btnBack = new Button();
            btnAdd = new Button();
            btnReturnBook = new Button();
            btnSelectMember = new Button();
            btnSelectBooks = new Button();
            lblBorrowDays = new Label();
            txtBorrowDays = new TextBox();
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            dataGridView1 = new DataGridView();
            listBoxSelectedBooks = new ListBox();
            lblTitle = new Label();
            topPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RoyalBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(509, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 38);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕ Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.White;
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatStyle = FlatStyle.System;
            btnReturnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturnBook.ForeColor = Color.Black;
            btnReturnBook.Location = new Point(726, 12);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(150, 38);
            btnReturnBook.TabIndex = 4;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnSelectMember
            // 
            btnSelectMember.Location = new Point(0, 0);
            btnSelectMember.Name = "btnSelectMember";
            btnSelectMember.Size = new Size(75, 23);
            btnSelectMember.TabIndex = 0;
            // 
            // btnSelectBooks
            // 
            btnSelectBooks.Location = new Point(0, 0);
            btnSelectBooks.Name = "btnSelectBooks";
            btnSelectBooks.Size = new Size(75, 23);
            btnSelectBooks.TabIndex = 0;
            // 
            // lblBorrowDays
            // 
            lblBorrowDays.Location = new Point(0, 0);
            lblBorrowDays.Name = "lblBorrowDays";
            lblBorrowDays.Size = new Size(100, 23);
            lblBorrowDays.TabIndex = 0;
            // 
            // txtBorrowDays
            // 
            txtBorrowDays.Location = new Point(0, 0);
            txtBorrowDays.Name = "txtBorrowDays";
            txtBorrowDays.Size = new Size(100, 23);
            txtBorrowDays.TabIndex = 0;
            // 
            // lblMemberID
            // 
            lblMemberID.Location = new Point(0, 0);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(100, 23);
            lblMemberID.TabIndex = 0;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(0, 0);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(100, 23);
            txtMemberID.TabIndex = 0;
            // 
            // lblISBN
            // 
            lblISBN.Location = new Point(0, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(100, 23);
            lblISBN.TabIndex = 0;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(0, 0);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(250, 250, 251);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(242, 207);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 56;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(2200, 909);
            dataGridView1.TabIndex = 0;
            // 
            // listBoxSelectedBooks
            // 
            listBoxSelectedBooks.Font = new Font("Segoe UI", 10F);
            listBoxSelectedBooks.Location = new Point(900, 5);
            listBoxSelectedBooks.Name = "listBoxSelectedBooks";
            listBoxSelectedBooks.Size = new Size(400, 80);
            listBoxSelectedBooks.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(171, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(277, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📊 Borrow And Return";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.RoyalBlue;
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(btnReturnBook);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAdd);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20, 10, 20, 10);
            topPanel.Size = new Size(2645, 60);
            topPanel.TabIndex = 5;
            // 
            // borrowANDreturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2645, 1181);
            Controls.Add(topPanel);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "borrowANDreturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow & Return";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBorrowDays;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtBorrowDays;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Button btnSelectBooks;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.ListBox listBoxSelectedBooks;
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private Label lblTitle;
        private Panel topPanel;
    }
}
