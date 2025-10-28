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
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(lblMemberID);
            panelTop.Controls.Add(txtMemberID);
            panelTop.Controls.Add(lblISBN);
            panelTop.Controls.Add(txtISBN);
            panelTop.Controls.Add(lblBorrowDays);
            panelTop.Controls.Add(txtBorrowDays);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnBack);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 56);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(2645, 112);
            panelTop.TabIndex = 1;
            // 
            // lblMemberID
            // 
            lblMemberID.Location = new Point(35, 28);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(88, 23);
            lblMemberID.TabIndex = 0;
            lblMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(122, 28);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(158, 23);
            txtMemberID.TabIndex = 1;
            // 
            // lblISBN
            // 
            lblISBN.Location = new Point(318, 28);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(52, 23);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(385, 28);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(158, 23);
            txtISBN.TabIndex = 3;
            // 
            // lblBorrowDays
            // 
            lblBorrowDays.Location = new Point(569, 28);
            lblBorrowDays.Name = "lblBorrowDays";
            lblBorrowDays.Size = new Size(88, 23);
            lblBorrowDays.TabIndex = 4;
            lblBorrowDays.Text = "Borrow Days:";
            // 
            // txtBorrowDays
            // 
            txtBorrowDays.Location = new Point(665, 28);
            txtBorrowDays.Name = "txtBorrowDays";
            txtBorrowDays.Size = new Size(70, 23);
            txtBorrowDays.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(770, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "➕ Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(928, 23);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            dataGridView1.Location = new Point(863, 377);
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
    }
}
