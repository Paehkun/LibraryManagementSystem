using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class MemberManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel leftPanel;
        private Panel rightPanel;
        private Button btnAddMember;
        private Button btnEditMember;
        private Button btnDeleteMember;
        private Button btnBack;
        private Label lblTitle;
        private DataGridView dgvMembers;
        private TextBox txtSearch;

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
            leftPanel = new Panel();
            btnBack = new Button();
            btnDeleteMember = new Button();
            btnEditMember = new Button();
            btnAddMember = new Button();
            rightPanel = new Panel();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            lblTitle = new Label();

            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();

            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();

            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Beige;
            leftPanel.Controls.Add(btnBack);
            leftPanel.Controls.Add(btnDeleteMember);
            leftPanel.Controls.Add(btnEditMember);
            leftPanel.Controls.Add(btnAddMember);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(250, 1181);
            leftPanel.TabIndex = 1;

            // 
            // Buttons
            // 
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.Location = new Point(25, 280);
            btnBack.Size = new Size(200, 35);
            btnBack.Text = "⬅️ Back";
            btnBack.Click += btnBack_Click;

            btnDeleteMember.BackColor = Color.White;
            btnDeleteMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteMember.Location = new Point(25, 200);
            btnDeleteMember.Size = new Size(200, 40);
            btnDeleteMember.Text = "🗑️ Delete Member";
            btnDeleteMember.Click += btnDeleteMember_Click;

            btnEditMember.BackColor = Color.White;
            btnEditMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditMember.Location = new Point(25, 140);
            btnEditMember.Size = new Size(200, 40);
            btnEditMember.Text = "✏️ Edit Member";
            btnEditMember.Click += btnEditMember_Click;

            btnAddMember.BackColor = Color.White;
            btnAddMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddMember.Location = new Point(25, 80);
            btnAddMember.Size = new Size(200, 40);
            btnAddMember.Text = "➕ Add Member";
            btnAddMember.Click += btnAddMember_Click;

            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.PeachPuff;
            rightPanel.Controls.Add(txtSearch);
            rightPanel.Controls.Add(dgvMembers);
            rightPanel.Controls.Add(lblTitle);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(250, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1758, 1181);
            rightPanel.TabIndex = 0;

            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(400, 35);
            lblTitle.Text = "👤 Member List";

            // 
            // Search Box
            // 
            txtSearch.Location = new Point(174, 91);
            txtSearch.Size = new Size(246, 23);
            txtSearch.PlaceholderText = "Search Member 🔍";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.AntiqueWhite;
            dgvMembers.Location = new Point(174, 140);
            dgvMembers.Name = "dgvBooks";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.Size = new Size(1356, 872);
            dgvMembers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // MemberManagementForm
            // 
            ClientSize = new Size(2008, 1181);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "MemberManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - Member Management";
            WindowState = FormWindowState.Maximized;
            Load += MemberManagementForm_Load;
            leftPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;


    }
}
