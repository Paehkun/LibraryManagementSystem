namespace LibraryManagement
{
    partial class borrowANDreturn
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridView dgvBorrowReturn;

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
            topPanel = new System.Windows.Forms.Panel();
            mainPanel = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnReturnBook = new System.Windows.Forms.Button();
            dgvBorrowReturn = new System.Windows.Forms.DataGridView();

            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowReturn).BeginInit();
            SuspendLayout();

            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAdd);
            topPanel.Controls.Add(btnReturnBook);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1920, 70);
            topPanel.TabIndex = 0;

            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(20, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(100, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.Click += btnBack_Click;

            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(140, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(350, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "🔄 Borrow & Return";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(1550, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(160, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "➕ Add Record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Click += btnAdd_Click;

            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnReturnBook.ForeColor = System.Drawing.Color.White;
            btnReturnBook.Location = new System.Drawing.Point(1730, 15);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new System.Drawing.Size(160, 40);
            btnReturnBook.TabIndex = 3;
            btnReturnBook.Text = "🔙 Return Book";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReturnBook.Click += btnReturnBook_Click;

            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(dgvBorrowReturn);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 70);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(50);
            mainPanel.Size = new System.Drawing.Size(1920, 1010);
            mainPanel.TabIndex = 1;

            // 
            // dgvBorrowReturn
            // 
            dgvBorrowReturn.AllowUserToAddRows = false;
            dgvBorrowReturn.AllowUserToDeleteRows = false;
            dgvBorrowReturn.BackgroundColor = System.Drawing.Color.White;
            dgvBorrowReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvBorrowReturn.Location = new System.Drawing.Point(50, 30);
            dgvBorrowReturn.Name = "dgvBorrowReturn";
            dgvBorrowReturn.ReadOnly = true;
            dgvBorrowReturn.RowHeadersVisible = false;
            dgvBorrowReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowReturn.Size = new System.Drawing.Size(1820, 930);
            dgvBorrowReturn.TabIndex = 0;

            // 
            // borrowANDreturn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Name = "borrowANDreturn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "🔄 Borrow & Return - Library System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += borrowANDreturn_Load;

            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowReturn).EndInit();
            ResumeLayout(false);
        }
    }
}