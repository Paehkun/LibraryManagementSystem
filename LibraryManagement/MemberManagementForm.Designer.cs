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
            leftPanel = new Panel();
            btnBack = new Button();
            btnDeleteMember = new Button();
            btnEditMember = new Button();
            btnAddMember = new Button();
            rightPanel = new Panel();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            lblTitle = new Label();
            flowMembers = new FlowLayoutPanel();

            // 🎨 Theme Colors
            Color backgroundColor = Color.White;
            Color buttonColor = Color.White;
            Color buttonBorderColor = Color.Black;
            Color textColor = Color.Black;

            // ========== LEFT PANEL ==========
            leftPanel.BackColor = backgroundColor;
            leftPanel.Controls.Add(btnBack);
            leftPanel.Controls.Add(btnDeleteMember);
            leftPanel.Controls.Add(btnEditMember);
            leftPanel.Controls.Add(btnAddMember);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Size = new Size(250, 1181);

            // 🔸 Reusable button styling method
            void StyleButton(Button btn, string text, int top)
            {
                btn.BackColor = buttonColor;
                btn.ForeColor = textColor;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Location = new Point(25, top);
                btn.Size = new Size(200, 40);
                btn.Text = text;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = buttonBorderColor;
                btn.UseVisualStyleBackColor = false;
            }

            StyleButton(btnAddMember, "➕ Add Member", 80);
            btnAddMember.Click += btnAddMember_Click;

            StyleButton(btnEditMember, "✏️ Edit Member", 140);
            btnEditMember.Click += btnEditMember_Click;

            StyleButton(btnDeleteMember, "🗑️ Delete Member", 200);
            btnDeleteMember.Click += btnDeleteMember_Click;

            StyleButton(btnBack, "⬅️ Back", 280);
            btnBack.Click += btnBack_Click;

            // ========== RIGHT PANEL ==========
            rightPanel.BackColor = backgroundColor;
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Controls.Add(txtSearch);
            rightPanel.Controls.Add(flowMembers);
            rightPanel.Controls.Add(lblTitle);

            // ========== SEARCH BOX ==========
            txtSearch.Location = new Point(174, 91);
            txtSearch.PlaceholderText = "Search Member 🔍";
            txtSearch.Size = new Size(246, 23);
            txtSearch.ForeColor = textColor;
            txtSearch.BackColor = backgroundColor;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // ========== FLOW PANEL ==========
            flowMembers.Location = new Point(174, 140);
            flowMembers.Size = new Size(1356, 872);
            flowMembers.AutoScroll = true;
            flowMembers.BackColor = Color.White;
            flowMembers.WrapContents = true;
            flowMembers.FlowDirection = FlowDirection.LeftToRight;
            flowMembers.Padding = new Padding(10);
            flowMembers.AutoScrollMargin = new Size(10, 10);

            // ========== TITLE ==========
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = textColor;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Size = new Size(400, 35);
            lblTitle.Text = "👤 Member List";

            // ========== DATAGRIDVIEW (optional) ==========
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.ForeColor = Color.Black;
            dgvMembers.GridColor = Color.Black;
            dgvMembers.DefaultCellStyle.ForeColor = textColor;
            dgvMembers.DefaultCellStyle.BackColor = backgroundColor;
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = textColor;
            dgvMembers.EnableHeadersVisualStyles = false;

            // ========== FORM ==========
            BackColor = backgroundColor;
            ClientSize = new Size(2008, 1181);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "MemberManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management - Member Management";
            WindowState = FormWindowState.Maximized;
            Load += MemberManagementForm_Load;
        }

        // 🪄 Helper method to create a nice-looking card for a member
        private Panel CreateMemberCard(string name, string email, string phone)
        {
            Panel card = new Panel();
            card.Size = new Size(300, 150);
            card.Margin = new Padding(10);
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;

            // Add soft shadow (fake by panel border)
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
    }
}
