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
        private FlowLayoutPanel categoryPanel;
        private Button btnBack;

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
            topPanel = new Panel();
            btn_back = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            flowPanel = new FlowLayoutPanel();
            btnBack = new Button();
            categoryPanel = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.RoyalBlue;
            topPanel.Controls.Add(btn_back);
            topPanel.Controls.Add(lblSearch);
            topPanel.Controls.Add(txtSearch);
            topPanel.Controls.Add(btnSearch);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20, 10, 20, 10);
            topPanel.Size = new Size(1564, 60);
            topPanel.TabIndex = 1;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.RoyalBlue;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(13, 13);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(97, 30);
            btn_back.TabIndex = 3;
            btn_back.Text = "⬅️ Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(234, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(296, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.System;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(713, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.WhiteSmoke;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(0, 60);
            flowPanel.Name = "flowPanel";
            flowPanel.Padding = new Padding(150, 70, 0, 100);
            flowPanel.Size = new Size(1564, 1121);
            flowPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // categoryPanel
            // 
            categoryPanel.AutoScroll = true;
            categoryPanel.BackColor = Color.LightGray;
            categoryPanel.Dock = DockStyle.Top;
            categoryPanel.Location = new Point(0, 60);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Padding = new Padding(80, 10, 20, 10);
            categoryPanel.Size = new Size(1564, 70);
            categoryPanel.TabIndex = 0;
            // 
            // BookCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1564, 1181);
            Controls.Add(categoryPanel);
            Controls.Add(flowPanel);
            Controls.Add(topPanel);
            Controls.Add(btnBack);
            Name = "BookCatalogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "📚 Book Catalog";
            WindowState = FormWindowState.Maximized;
            Load += BookCatalogForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
        private Button btn_back;
    }
}
