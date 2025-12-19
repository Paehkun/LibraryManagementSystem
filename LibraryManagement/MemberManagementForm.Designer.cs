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
            topPanel = new System.Windows.Forms.Panel();
            mainPanel = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            btnAddMember = new System.Windows.Forms.Button();
            btnEditMember = new System.Windows.Forms.Button();
            btnDeleteMember = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dgvMembers = new System.Windows.Forms.DataGridView();

            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();

            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddMember);
            topPanel.Controls.Add(btnEditMember);
            topPanel.Controls.Add(btnDeleteMember);
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
            lblTitle.Text = "👥 Member Management";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddMember.ForeColor = System.Drawing.Color.White;
            btnAddMember.Location = new System.Drawing.Point(1400, 15);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new System.Drawing.Size(150, 40);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "➕ Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddMember.Click += btnAddMember_Click;

            // 
            // btnEditMember
            // 
            btnEditMember.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            btnEditMember.FlatAppearance.BorderSize = 0;
            btnEditMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEditMember.ForeColor = System.Drawing.Color.White;
            btnEditMember.Location = new System.Drawing.Point(1570, 15);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new System.Drawing.Size(150, 40);
            btnEditMember.TabIndex = 3;
            btnEditMember.Text = "✏️ Edit Member";
            btnEditMember.UseVisualStyleBackColor = false;
            btnEditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditMember.Click += btnEditMember_Click;

            // 
            // btnDeleteMember
            // 
            btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteMember.FlatAppearance.BorderSize = 0;
            btnDeleteMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeleteMember.ForeColor = System.Drawing.Color.White;
            btnDeleteMember.Location = new System.Drawing.Point(1740, 15);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new System.Drawing.Size(160, 40);
            btnDeleteMember.TabIndex = 4;
            btnDeleteMember.Text = "🗑️ Delete Member";
            btnDeleteMember.UseVisualStyleBackColor = false;
            btnDeleteMember.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteMember.Click += btnDeleteMember_Click;

            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(txtSearch);
            mainPanel.Controls.Add(dgvMembers);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 70);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(40);
            mainPanel.Size = new System.Drawing.Size(1920, 1010);
            mainPanel.TabIndex = 1;

            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.White;
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            txtSearch.Location = new System.Drawing.Point(50, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by Name, Email, or Phone...";
            txtSearch.Size = new System.Drawing.Size(500, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.BackgroundColor = System.Drawing.Color.White;
            dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMembers.Location = new System.Drawing.Point(50, 80);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new System.Drawing.Size(1820, 880);
            dgvMembers.TabIndex = 1;

            // 
            // MemberManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Name = "MemberManagementForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "👥 Member Management - Library System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += MemberManagementForm_Load;

            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }
    }
}