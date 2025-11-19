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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panelFilter = new Panel();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFilter.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(3, 16);
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
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(170, 22);
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
            btnReturnBook.FlatStyle = FlatStyle.Flat;
            btnReturnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReturnBook.ForeColor = Color.Black;
            btnReturnBook.Location = new Point(419, 22);
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 251);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
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
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(140, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📊 Borrow And Return Books";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.AliceBlue;
            panelFilter.Controls.Add(btnAdd);
            panelFilter.Controls.Add(btnReturnBook);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 60);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(2645, 120);
            panelFilter.TabIndex = 5;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.SteelBlue;
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(btnBack);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(2645, 60);
            panelTop.TabIndex = 6;
            // 
            // borrowANDreturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2645, 1181);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "borrowANDreturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow & Return";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFilter.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
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
        private Panel panelFilter;
        private Panel panelTop;
    }
}
