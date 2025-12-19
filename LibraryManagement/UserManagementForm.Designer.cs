using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvUsers;

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
            btnAddUser = new System.Windows.Forms.Button();
            btnEditUser = new System.Windows.Forms.Button();
            btnDeleteUser = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dgvUsers = new System.Windows.Forms.DataGridView();

            topPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddUser);
            topPanel.Controls.Add(btnEditUser);
            topPanel.Controls.Add(btnDeleteUser);
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
            lblTitle.Size = new System.Drawing.Size(300, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "👤 User Management";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddUser.ForeColor = System.Drawing.Color.White;
            btnAddUser.Location = new System.Drawing.Point(1450, 15);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(140, 40);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "➕ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddUser.Click += btnAddUser_Click;

            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEditUser.ForeColor = System.Drawing.Color.White;
            btnEditUser.Location = new System.Drawing.Point(1610, 15);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new System.Drawing.Size(140, 40);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "✏️ Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditUser.Click += btnEditUser_Click;

            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDeleteUser.ForeColor = System.Drawing.Color.White;
            btnDeleteUser.Location = new System.Drawing.Point(1770, 15);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new System.Drawing.Size(140, 40);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "🗑️ Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDeleteUser.Click += btnDeleteUser_Click;

            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(txtSearch);
            mainPanel.Controls.Add(dgvUsers);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 70);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1920, 1010);
            mainPanel.TabIndex = 1;

            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.White;
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            txtSearch.Location = new System.Drawing.Point(710, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search by Name, Username, or Email...";
            txtSearch.Size = new System.Drawing.Size(500, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUsers.Location = new System.Drawing.Point(250, 100);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(1420, 860);
            dgvUsers.TabIndex = 1;

            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(mainPanel);
            Controls.Add(topPanel);
            Name = "UserManagementForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "👤 User Management - Library System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += UserManagementForm_Load;

            topPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }
    }
}