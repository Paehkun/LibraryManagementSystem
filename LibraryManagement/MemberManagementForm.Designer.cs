using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class MemberManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMembers;

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
            btnBack = new Button();
            lblTitle = new Label();
            btnAddMember = new Button();
            btnEditMember = new Button();
            btnDeleteMember = new Button();
            mainPanel = new Panel();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddMember);
            topPanel.Controls.Add(btnEditMember);
            topPanel.Controls.Add(btnDeleteMember);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1680, 66);
            topPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(18, 14);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(122, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "👥 Member Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(46, 204, 113);
            btnAddMember.Cursor = Cursors.Hand;
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(1225, 14);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(131, 38);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "➕ Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnEditMember
            // 
            btnEditMember.BackColor = Color.FromArgb(241, 196, 15);
            btnEditMember.Cursor = Cursors.Hand;
            btnEditMember.FlatAppearance.BorderSize = 0;
            btnEditMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 156, 18);
            btnEditMember.FlatStyle = FlatStyle.Flat;
            btnEditMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditMember.ForeColor = Color.White;
            btnEditMember.Location = new Point(1374, 14);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new Size(131, 38);
            btnEditMember.TabIndex = 3;
            btnEditMember.Text = "✏️ Edit Member";
            btnEditMember.UseVisualStyleBackColor = false;
            btnEditMember.Click += btnEditMember_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteMember.Cursor = Cursors.Hand;
            btnDeleteMember.FlatAppearance.BorderSize = 0;
            btnDeleteMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnDeleteMember.FlatStyle = FlatStyle.Flat;
            btnDeleteMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteMember.ForeColor = Color.White;
            btnDeleteMember.Location = new Point(1522, 14);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(146, 38);
            btnDeleteMember.TabIndex = 4;
            btnDeleteMember.Text = "🗑️ Delete Member";
            btnDeleteMember.UseVisualStyleBackColor = false;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(txtSearch);
            mainPanel.Controls.Add(dgvMembers);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 66);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(35, 38, 35, 38);
            mainPanel.Size = new Size(1680, 946);
            mainPanel.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(52, 73, 94);
            txtSearch.Location = new Point(44, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by Name, Email, or Phone...";
            txtSearch.Size = new Size(438, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.Location = new Point(44, 75);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1592, 825);
            dgvMembers.TabIndex = 1;
            // 
            // MemberManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 1012);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Name = "MemberManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "👥 Member Management - Library System";
            WindowState = FormWindowState.Maximized;
            Load += MemberManagementForm_Load;
            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }
    }
}