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

        // New Labels and TextBoxes
        private Label lblMemberID;
        private TextBox txtMemberID;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblMembershipDate;
        private TextBox txtMembershipDate;

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

            // New Label and TextBox objects
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblMembershipDate = new Label();
            txtMembershipDate = new TextBox();

            colMemberID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colMembershipDate = new DataGridViewTextBoxColumn();

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
            rightPanel.Controls.Add(lblMemberID);
            rightPanel.Controls.Add(txtMemberID);
            rightPanel.Controls.Add(lblName);
            rightPanel.Controls.Add(txtName);
            rightPanel.Controls.Add(lblEmail);
            rightPanel.Controls.Add(txtEmail);
            rightPanel.Controls.Add(lblPhone);
            rightPanel.Controls.Add(txtPhone);
            rightPanel.Controls.Add(lblAddress);
            rightPanel.Controls.Add(txtAddress);
            rightPanel.Controls.Add(lblMembershipDate);
            rightPanel.Controls.Add(txtMembershipDate);
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
            // Labels and TextBoxes for Member Info
            // 
            int labelX = 500, textX = 630, startY = 60, gapY = 40;

            lblMemberID.Location = new Point(labelX, startY);
            lblMemberID.Text = "Member ID:";
            lblMemberID.Size = new Size(120, 23);
            txtMemberID.Location = new Point(textX, startY);
            txtMemberID.Size = new Size(200, 23);

            lblName.Location = new Point(labelX, startY + gapY);
            lblName.Text = "Name:";
            lblName.Size = new Size(120, 23);
            txtName.Location = new Point(textX, startY + gapY);
            txtName.Size = new Size(200, 23);

            lblEmail.Location = new Point(labelX, startY + 2 * gapY);
            lblEmail.Text = "Email:";
            lblEmail.Size = new Size(120, 23);
            txtEmail.Location = new Point(textX, startY + 2 * gapY);
            txtEmail.Size = new Size(200, 23);

            lblPhone.Location = new Point(labelX, startY + 3 * gapY);
            lblPhone.Text = "Phone:";
            lblPhone.Size = new Size(120, 23);
            txtPhone.Location = new Point(textX, startY + 3 * gapY);
            txtPhone.Size = new Size(200, 23);

            lblAddress.Location = new Point(labelX, startY + 4 * gapY);
            lblAddress.Text = "Address:";
            lblAddress.Size = new Size(120, 23);
            txtAddress.Location = new Point(textX, startY + 4 * gapY);
            txtAddress.Size = new Size(200, 23);

            lblMembershipDate.Location = new Point(labelX, startY + 5 * gapY);
            lblMembershipDate.Text = "Membership Date:";
            lblMembershipDate.Size = new Size(130, 23);
            txtMembershipDate.Location = new Point(textX, startY + 5 * gapY);
            txtMembershipDate.Size = new Size(200, 23);

            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.AntiqueWhite;
            dgvMembers.Location = new Point(174, 320);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.Size = new Size(1356, 700);
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] {
                colMemberID,
                colName,
                colEmail,
                colPhone,
                colAddress,
                colMembershipDate
            });
            // 
            // dtpMembershipDate
            // 
            dtpMembershipDate = new DateTimePicker();
            dtpMembershipDate.Location = new Point(174, 210);   // adjust X,Y position as you like
            dtpMembershipDate.Size = new Size(246, 23);
            dtpMembershipDate.Format = DateTimePickerFormat.Short;
            rightPanel.Controls.Add(dtpMembershipDate);

            // 
            // DataGridView Columns
            // 
            colMemberID.HeaderText = "Member ID";
            colName.HeaderText = "Name";
            colEmail.HeaderText = "Email";
            colPhone.HeaderText = "Phone";
            colAddress.HeaderText = "Address";
            colMembershipDate.HeaderText = "Membership Date";

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

        private DataGridViewTextBoxColumn colMemberID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colMembershipDate;
        private DateTimePicker dtpMembershipDate;

    }
}
