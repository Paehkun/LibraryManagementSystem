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
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblBorrowDays = new Label();
            txtBorrowDays = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            btnSelectMember = new Button();
            btnSelectBooks = new Button();
            dataGridView1 = new DataGridView();
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
            // panelTop
            // 
            // panelTop
            this.panelTop = new Panel();
            this.panelTop.BackColor = Color.WhiteSmoke;
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 80;
            this.panelTop.Padding = new Padding(20, 20, 0, 20);
            this.panelTop.TabIndex = 1;

            // btnBack
            this.btnBack = new Button();
            this.btnBack.Text = "← Back";
            this.btnBack.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnBack.BackColor = Color.LightGray;
            this.btnBack.ForeColor = Color.Black;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Size = new Size(100, 38);
            this.btnBack.Location = new Point(20, 20);
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            // btnSelectMember
            this.btnSelectMember = new Button();
            this.btnSelectMember.Text = "Select Member";
            this.btnSelectMember.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnSelectMember.BackColor = Color.SteelBlue;
            this.btnSelectMember.ForeColor = Color.White;
            this.btnSelectMember.FlatStyle = FlatStyle.Flat;
            this.btnSelectMember.FlatAppearance.BorderSize = 0;
            this.btnSelectMember.Size = new Size(150, 38);
            this.btnSelectMember.Location = new Point(140, 20);
            this.btnSelectMember.Click += new EventHandler(this.BtnSelectMember_Click);

            // btnSelectBooks
            this.btnSelectBooks = new Button();
            this.btnSelectBooks.Text = "Select Books";
            this.btnSelectBooks.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnSelectBooks.BackColor = Color.SteelBlue;
            this.btnSelectBooks.ForeColor = Color.White;
            this.btnSelectBooks.FlatStyle = FlatStyle.Flat;
            this.btnSelectBooks.FlatAppearance.BorderSize = 0;
            this.btnSelectBooks.Size = new Size(150, 38);
            this.btnSelectBooks.Location = new Point(310, 20);
            this.btnSelectBooks.Click += new EventHandler(this.BtnSelectBooks_Click);

            // btnAdd
            this.btnAdd = new Button();
            this.btnAdd.Text = "➕ Add Record";
            this.btnAdd.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.btnAdd.BackColor = Color.SteelBlue;
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Size = new Size(150, 38);
            this.btnAdd.Location = new Point(480, 20);
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // lblBorrowDays
            this.lblBorrowDays = new Label();
            this.lblBorrowDays.Text = "Borrow Days:";
            this.lblBorrowDays.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblBorrowDays.ForeColor = Color.Black;
            this.lblBorrowDays.AutoSize = true;
            this.lblBorrowDays.Location = new Point(660, 28);

            // txtBorrowDays
            this.txtBorrowDays = new TextBox();
            this.txtBorrowDays.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.txtBorrowDays.Size = new Size(80, 25);
            this.txtBorrowDays.Location = new Point(770, 25);

            // Add everything to the panel
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.btnSelectMember);
            this.panelTop.Controls.Add(this.btnSelectBooks);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.lblBorrowDays);
            this.panelTop.Controls.Add(this.txtBorrowDays);

            // Add panel after header
            this.Controls.Add(this.panelTop);


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
            dataGridView1.Location = new Point(273, 214);
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
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.DataGridView dataGridBooks;

    }
}
