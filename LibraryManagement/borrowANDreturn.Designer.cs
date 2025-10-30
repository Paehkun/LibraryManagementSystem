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
            lblHeader = new Label();
            panelTop = new Panel();
            btnBack = new Button();
            btnSelectMember = new Button();
            btnSelectBooks = new Button();
            btnAdd = new Button();
            lblBorrowDays = new Label();
            txtBorrowDays = new TextBox();
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            dataGridView1 = new DataGridView();
            listBoxSelectedBooks = new ListBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.SteelBlue;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(2645, 56);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "📚 Borrow & Return Management";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(btnBack);
            panelTop.Controls.Add(btnSelectMember);
            panelTop.Controls.Add(btnSelectBooks);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(lblBorrowDays);
            panelTop.Controls.Add(txtBorrowDays);
            panelTop.Controls.Add(listBoxSelectedBooks);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 56);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(20, 20, 0, 20);
            panelTop.Size = new Size(2645, 80);
            panelTop.TabIndex = 1;
            //
            //ListBoxSelectedBooks
            //
            listBoxSelectedBooks.Location = new Point(900, 5);
            listBoxSelectedBooks.Size = new Size(400, 80);
            listBoxSelectedBooks.Font = new Font("Segoe UI", 10);
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSelectMember
            // 
            btnSelectMember.BackColor = Color.SteelBlue;
            btnSelectMember.FlatAppearance.BorderSize = 0;
            btnSelectMember.FlatStyle = FlatStyle.Flat;
            btnSelectMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelectMember.ForeColor = Color.White;
            btnSelectMember.Location = new Point(140, 20);
            btnSelectMember.Name = "btnSelectMember";
            btnSelectMember.Size = new Size(150, 38);
            btnSelectMember.TabIndex = 1;
            btnSelectMember.Text = "Select Member";
            btnSelectMember.UseVisualStyleBackColor = false;
            btnSelectMember.Click += BtnSelectMember_Click;
            // 
            // btnSelectBooks
            // 
            btnSelectBooks.BackColor = Color.SteelBlue;
            btnSelectBooks.FlatAppearance.BorderSize = 0;
            btnSelectBooks.FlatStyle = FlatStyle.Flat;
            btnSelectBooks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelectBooks.ForeColor = Color.White;
            btnSelectBooks.Location = new Point(310, 20);
            btnSelectBooks.Name = "btnSelectBooks";
            btnSelectBooks.Size = new Size(150, 38);
            btnSelectBooks.TabIndex = 2;
            btnSelectBooks.Text = "Select Books";
            btnSelectBooks.UseVisualStyleBackColor = false;
            btnSelectBooks.Click += BtnSelectBooks_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(480, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 38);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕ Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBorrowDays
            // 
            lblBorrowDays.AutoSize = true;
            lblBorrowDays.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBorrowDays.ForeColor = Color.Black;
            lblBorrowDays.Location = new Point(660, 28);
            lblBorrowDays.Name = "lblBorrowDays";
            lblBorrowDays.Size = new Size(99, 19);
            lblBorrowDays.TabIndex = 4;
            lblBorrowDays.Text = "Borrow Days:";
            // 
            // txtBorrowDays
            // 
            txtBorrowDays.Font = new Font("Segoe UI", 10F);
            txtBorrowDays.Location = new Point(770, 25);
            txtBorrowDays.Name = "txtBorrowDays";
            txtBorrowDays.Size = new Size(80, 25);
            txtBorrowDays.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 251);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.Location = new Point(269, 500);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 56;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(2200, 938);
            dataGridView1.TabIndex = 0;
            // 
            // borrowANDreturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2645, 1181);
            Controls.Add(dataGridView1);
            Controls.Add(panelTop);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "borrowANDreturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow & Return";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelTop;
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
        private System.Windows.Forms.ListBox listBoxSelectedBooks;
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.DataGridView dataGridBooks;

    }
}
