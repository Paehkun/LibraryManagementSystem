namespace LibraryManagementSystem
{
    partial class BookCatalogForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel paginationPanel;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmbItemsPerPage;
        private System.Windows.Forms.Label lblItemsPerPage;

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
            btn_back = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lblSort = new System.Windows.Forms.Label();
            cmbSort = new System.Windows.Forms.ComboBox();
            lblItemsPerPage = new System.Windows.Forms.Label();
            cmbItemsPerPage = new System.Windows.Forms.ComboBox();
            flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            btnBack = new System.Windows.Forms.Button();
            categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            paginationPanel = new System.Windows.Forms.FlowLayoutPanel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            topPanel.Controls.Add(btn_back);
            topPanel.Controls.Add(lblSearch);
            topPanel.Controls.Add(txtSearch);
            topPanel.Controls.Add(btnSearch);
            topPanel.Controls.Add(lblSort);
            topPanel.Controls.Add(cmbSort);
            topPanel.Controls.Add(lblItemsPerPage);
            topPanel.Controls.Add(cmbItemsPerPage);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            topPanel.Size = new System.Drawing.Size(1564, 60);
            topPanel.TabIndex = 1;
            // 
            // btn_back
            // 
            btn_back.BackColor = System.Drawing.Color.RoyalBlue;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_back.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn_back.ForeColor = System.Drawing.Color.White;
            btn_back.Location = new System.Drawing.Point(13, 13);
            btn_back.Name = "btn_back";
            btn_back.Size = new System.Drawing.Size(97, 30);
            btn_back.TabIndex = 3;
            btn_back.Text = "⬅️ Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSearch.ForeColor = System.Drawing.Color.White;
            lblSearch.Location = new System.Drawing.Point(234, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(56, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSearch.Location = new System.Drawing.Point(296, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(350, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.RoyalBlue;
            btnSearch.Location = new System.Drawing.Point(660, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSort.ForeColor = System.Drawing.Color.White;
            lblSort.Location = new System.Drawing.Point(790, 20);
            lblSort.Name = "lblSort";
            lblSort.Size = new System.Drawing.Size(59, 20);
            lblSort.TabIndex = 5;
            lblSort.Text = "Sort by:";
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new System.Drawing.Point(855, 17);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new System.Drawing.Size(150, 25);
            cmbSort.TabIndex = 6;
            // 
            // lblItemsPerPage
            // 
            lblItemsPerPage.AutoSize = true;
            lblItemsPerPage.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblItemsPerPage.ForeColor = System.Drawing.Color.White;
            lblItemsPerPage.Location = new System.Drawing.Point(1030, 20);
            lblItemsPerPage.Name = "lblItemsPerPage";
            lblItemsPerPage.Size = new System.Drawing.Size(84, 20);
            lblItemsPerPage.TabIndex = 7;
            lblItemsPerPage.Text = "Items/Page:";
            // 
            // cmbItemsPerPage
            // 
            cmbItemsPerPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbItemsPerPage.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbItemsPerPage.FormattingEnabled = true;
            cmbItemsPerPage.Location = new System.Drawing.Point(1120, 17);
            cmbItemsPerPage.Name = "cmbItemsPerPage";
            cmbItemsPerPage.Size = new System.Drawing.Size(80, 25);
            cmbItemsPerPage.TabIndex = 8;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            flowPanel.Location = new System.Drawing.Point(0, 130);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new System.Windows.Forms.Padding(150, 20, 0, 20);
            flowPanel.Size = new System.Drawing.Size(1564, 1001);
            flowPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.SteelBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(90, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // categoryPanel
            // 
            categoryPanel.AutoScroll = true;
            categoryPanel.BackColor = System.Drawing.Color.LightGray;
            categoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            categoryPanel.Location = new System.Drawing.Point(0, 60);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Padding = new System.Windows.Forms.Padding(80, 10, 20, 10);
            categoryPanel.Size = new System.Drawing.Size(1564, 70);
            categoryPanel.TabIndex = 0;
            // 
            // paginationPanel
            // 
            paginationPanel.BackColor = System.Drawing.Color.White;
            paginationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            paginationPanel.Location = new System.Drawing.Point(0, 1131);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Padding = new System.Windows.Forms.Padding(400, 10, 0, 10);
            paginationPanel.Size = new System.Drawing.Size(1564, 50);
            paginationPanel.TabIndex = 3;
            // 
            // BookCatalogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1564, 1181);
            Controls.Add(flowPanel);
            Controls.Add(paginationPanel);
            Controls.Add(categoryPanel);
            Controls.Add(topPanel);
            Controls.Add(btnBack);
            Name = "BookCatalogForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "📚 Book Catalog";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += BookCatalogForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}