using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel rightPanel;
        private Label lblTitle;
        private DataGridView dgvMembers;
        private FlowLayoutPanel flowMembers;
        private TextBox txtSearch;

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            rightPanel = new Panel();
            topPanel = new Panel();
            btnBack = new Button();
            btnDeleteMember = new Button();
            btnAddMember = new Button();
            btnEditMember = new Button();
            lblTitle = new Label();
            dgvMembers = new DataGridView();
            txtSearch = new TextBox();
            rightPanel.SuspendLayout();
            topPanel.SuspendLayout();
            ((ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(245, 247, 250);
            rightPanel.Controls.Add(topPanel);
            rightPanel.Controls.Add(dgvMembers);
            rightPanel.Controls.Add(txtSearch);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1900, 1100);
            rightPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.RoyalBlue;
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(btnDeleteMember);
            topPanel.Controls.Add(btnAddMember);
            topPanel.Controls.Add(btnEditMember);
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20, 10, 20, 10);
            topPanel.Size = new Size(1900, 60);
            topPanel.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RoyalBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 43);
            btnBack.TabIndex = 7;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.BackColor = Color.White;
            btnDeleteMember.FlatAppearance.BorderSize = 0;
            btnDeleteMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnDeleteMember.FlatStyle = FlatStyle.System;
            btnDeleteMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteMember.ForeColor = Color.Black;
            btnDeleteMember.Location = new Point(706, 12);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(143, 40);
            btnDeleteMember.TabIndex = 4;
            btnDeleteMember.Text = "🗑️ Delete User";
            btnDeleteMember.UseVisualStyleBackColor = false;
            btnDeleteMember.Click += btnDeleteMember_Click_1;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.White;
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnAddMember.FlatStyle = FlatStyle.System;
            btnAddMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddMember.ForeColor = Color.Black;
            btnAddMember.Location = new Point(355, 12);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(143, 40);
            btnAddMember.TabIndex = 6;
            btnAddMember.Text = "➕ Add User";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click_1;
            // 
            // btnEditMember
            // 
            btnEditMember.BackColor = Color.White;
            btnEditMember.FlatAppearance.BorderSize = 0;
            btnEditMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnEditMember.FlatStyle = FlatStyle.System;
            btnEditMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditMember.ForeColor = Color.Black;
            btnEditMember.Location = new Point(533, 12);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new Size(143, 40);
            btnEditMember.TabIndex = 5;
            btnEditMember.Text = "✏️ Edit User";
            btnEditMember.UseVisualStyleBackColor = false;
            btnEditMember.Click += btnEditMember_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(146, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(152, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "👤 User List";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(225, 235, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.GridColor = Color.FromArgb(240, 240, 240);
            dgvMembers.Location = new Point(345, 138);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowTemplate.Height = 45;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1222, 950);
            dgvMembers.TabIndex = 0;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(345, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search User 🔍";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1100);
            Controls.Add(rightPanel);
            Name = "UserManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - User Management";
            WindowState = FormWindowState.Maximized;
            Load += UserManagementForm_Load;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }
        private Button btnAddMember;
        private Button btnDeleteMember;
        private Button btnEditMember;
        private Button btnBack;
        private Panel topPanel;
    }
}
