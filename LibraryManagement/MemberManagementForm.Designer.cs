using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    partial class MemberManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel rightPanel;
        private Button btnAddMember;
        private Button btnEditMember;
        private Button btnDeleteMember;
        private Button btnBack;
        private Label lblTitle;
        private DataGridView dgvMembers;
        private FlowLayoutPanel flowMembers;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAddMember = new Button();
            btnEditMember = new Button();
            btnDeleteMember = new Button();
            btnBack = new Button();
            rightPanel = new Panel();
            topPanel = new Panel();
            lblTitle = new Label();
            dgvMembers = new DataGridView();
            txtSearch = new TextBox();
            rightPanel.SuspendLayout();
            topPanel.SuspendLayout();
            ((ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.RoyalBlue;
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnAddMember.FlatStyle = FlatStyle.System;
            btnAddMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(365, 10);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(143, 42);
            btnAddMember.TabIndex = 0;
            btnAddMember.Text = "➕ Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnEditMember
            // 
            btnEditMember.BackColor = Color.RoyalBlue;
            btnEditMember.FlatAppearance.BorderSize = 0;
            btnEditMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnEditMember.FlatStyle = FlatStyle.System;
            btnEditMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditMember.ForeColor = Color.White;
            btnEditMember.Location = new Point(537, 10);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new Size(143, 41);
            btnEditMember.TabIndex = 0;
            btnEditMember.Text = "✏️ Edit Member";
            btnEditMember.UseVisualStyleBackColor = false;
            btnEditMember.Click += btnEditMember_Click;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.BackColor = Color.RoyalBlue;
            btnDeleteMember.FlatAppearance.BorderSize = 0;
            btnDeleteMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnDeleteMember.FlatStyle = FlatStyle.System;
            btnDeleteMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteMember.ForeColor = Color.White;
            btnDeleteMember.Location = new Point(712, 9);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(143, 43);
            btnDeleteMember.TabIndex = 0;
            btnDeleteMember.Text = "🗑️ Delete Member";
            btnDeleteMember.UseVisualStyleBackColor = false;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RoyalBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 43);
            btnBack.TabIndex = 0;
            btnBack.Text = "⬅️ Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(btnEditMember);
            topPanel.Controls.Add(btnAddMember);
            topPanel.Controls.Add(btnDeleteMember);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20, 10, 20, 10);
            topPanel.Size = new Size(1900, 60);
            topPanel.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(135, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "👤 Member List";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvMembers.Location = new Point(338, 136);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowTemplate.Height = 45;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1170, 980);
            dgvMembers.TabIndex = 0;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(338, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Member 🔍";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // MemberManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1100);
            Controls.Add(rightPanel);
            Name = "MemberManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - Member Management";
            WindowState = FormWindowState.Maximized;
            Load += MemberManagementForm_Load;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }


        // 🪄 Helper method to create a nice-looking card for a member
        private Panel CreateMemberCard(string name, string email, string phone)
        {
            Panel card = new Panel();
            card.Size = new Size(300, 150);
            card.Margin = new Padding(10);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            card.Padding = new Padding(10);

            // Top accent line
            Panel accent = new Panel();
            accent.BackColor = Color.LightSkyBlue;   // ✨ You can change this color
            accent.Dock = DockStyle.Top;
            accent.Height = 5;
            card.Controls.Add(accent);

            // Labels
            Label lblName = new Label();
            lblName.Text = $"👤 {name}";
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(10, 20);
            lblName.AutoSize = true;
            card.Controls.Add(lblName);

            Label lblEmail = new Label();
            lblEmail.Text = $"✉️ {email}";
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(10, 60);
            lblEmail.AutoSize = true;
            card.Controls.Add(lblEmail);

            Label lblPhone = new Label();
            lblPhone.Text = $"📞 {phone}";
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(10, 90);
            lblPhone.AutoSize = true;
            card.Controls.Add(lblPhone);

            // Hover effect
            card.MouseEnter += (s, e) => { card.BackColor = Color.AliceBlue; };
            card.MouseLeave += (s, e) => { card.BackColor = Color.White; };

            return card;
        }
        private Panel topPanel;
    }
}
