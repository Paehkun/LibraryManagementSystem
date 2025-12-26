namespace LibraryManagementSystem
{
    partial class BookCatalogForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.FlowLayoutPanel paginationPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblItemsPerPage;
        private System.Windows.Forms.ComboBox cmbItemsPerPage;

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
            btnBack = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lblSort = new System.Windows.Forms.Label();
            cmbSort = new System.Windows.Forms.ComboBox();
            lblItemsPerPage = new System.Windows.Forms.Label();
            cmbItemsPerPage = new System.Windows.Forms.ComboBox();
            categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            paginationPanel = new System.Windows.Forms.FlowLayoutPanel();

            topPanel.SuspendLayout();
            SuspendLayout();

            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(txtSearch);
            topPanel.Controls.Add(btnSearch);
            topPanel.Controls.Add(lblSort);
            topPanel.Controls.Add(cmbSort);
            topPanel.Controls.Add(lblItemsPerPage);
            topPanel.Controls.Add(cmbItemsPerPage);
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
            lblTitle.Size = new System.Drawing.Size(250, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📚 Book Catalog";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSearch.Location = new System.Drawing.Point(420, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search books...";
            txtSearch.Size = new System.Drawing.Size(350, 27);
            txtSearch.TabIndex = 2;

            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnSearch.Location = new System.Drawing.Point(785, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.Click += btnSearch_Click;

            // 
            // lblSort
            // 
            lblSort.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSort.ForeColor = System.Drawing.Color.White;
            lblSort.Location = new System.Drawing.Point(920, 20);
            lblSort.Name = "lblSort";
            lblSort.Size = new System.Drawing.Size(70, 27);
            lblSort.TabIndex = 4;
            lblSort.Text = "Sort by:";
            lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new System.Drawing.Point(1000, 20);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new System.Drawing.Size(160, 25);
            cmbSort.TabIndex = 5;

            // 
            // lblItemsPerPage
            // 
            lblItemsPerPage.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblItemsPerPage.ForeColor = System.Drawing.Color.White;
            lblItemsPerPage.Location = new System.Drawing.Point(1190, 20);
            lblItemsPerPage.Name = "lblItemsPerPage";
            lblItemsPerPage.Size = new System.Drawing.Size(100, 27);
            lblItemsPerPage.TabIndex = 6;
            lblItemsPerPage.Text = "Items/Page:";
            lblItemsPerPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // cmbItemsPerPage
            // 
            cmbItemsPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbItemsPerPage.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbItemsPerPage.FormattingEnabled = true;
            cmbItemsPerPage.Location = new System.Drawing.Point(1295, 20);
            cmbItemsPerPage.Name = "cmbItemsPerPage";
            cmbItemsPerPage.Size = new System.Drawing.Size(80, 25);
            cmbItemsPerPage.TabIndex = 7;

            // 
            // categoryPanel
            // 
            categoryPanel.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            categoryPanel.AutoScroll = true;
            categoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            categoryPanel.Location = new System.Drawing.Point(0, 70);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            categoryPanel.Size = new System.Drawing.Size(1920, 70);
            categoryPanel.TabIndex = 1;

            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            flowPanel.Location = new System.Drawing.Point(0, 140);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new System.Windows.Forms.Padding(80, 30, 80, 30);
            flowPanel.Size = new System.Drawing.Size(1920, 880);
            flowPanel.TabIndex = 2;

            // 
            // paginationPanel
            // 
            paginationPanel.BackColor = System.Drawing.Color.White;
            paginationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            paginationPanel.Location = new System.Drawing.Point(0, 1020);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Padding = new System.Windows.Forms.Padding(700, 10, 0, 10);
            paginationPanel.Size = new System.Drawing.Size(1920, 60);
            paginationPanel.TabIndex = 3;

            // 
            // BookCatalogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(flowPanel);
            Controls.Add(paginationPanel);
            Controls.Add(categoryPanel);
            Controls.Add(topPanel);
            Name = "BookCatalogForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "📚 Book Catalog - Library System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += BookCatalogForm_Load;

            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}   