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
            components = new Container();
            leftPanel = new Panel();
            btnBack = new Button();
            btnDeleteMember = new Button();
            btnEditMember = new Button();
            btnAddMember = new Button();
            rightPanel = new Panel();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            lblTitle = new Label();

            // 🎨 Theme Colors
            Color leftPanelColor = Color.FromArgb(33, 150, 243); // Blue left panel
            Color mainBg = Color.FromArgb(245, 247, 250);        // Light gray/white background
            Color textColor = Color.Black;
            Font buttonFont = new Font("Segoe UI", 10F, FontStyle.Bold);

            // ========== LEFT PANEL ==========
            leftPanel.BackColor = leftPanelColor;
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Size = new Size(250, 1181);
            leftPanel.Controls.AddRange(new Control[] { btnAddMember, btnEditMember, btnDeleteMember, btnBack });

            void StyleButton(Button btn, string text, int top)
            {
                btn.Text = text;
                btn.Font = buttonFont;
                btn.BackColor = Color.White;
                btn.ForeColor = textColor;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Location = new Point(25, top);
                btn.Size = new Size(200, 50);
            }

            StyleButton(btnAddMember, "➕ Add Member", 80);
            btnAddMember.Click += btnAddMember_Click;

            StyleButton(btnEditMember, "✏️ Edit Member", 150);
            btnEditMember.Click += btnEditMember_Click;

            StyleButton(btnDeleteMember, "🗑️ Delete Member", 220);
            btnDeleteMember.Click += btnDeleteMember_Click;

            StyleButton(btnBack, "⬅️ Back", 290);
            btnBack.Click += btnBack_Click;

            // ========== RIGHT PANEL ==========
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.BackColor = mainBg;
            rightPanel.Controls.AddRange(new Control[] { dgvMembers, txtSearch, lblTitle });

            // ========== TITLE ==========
            lblTitle.Text = "👤 Member List";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = textColor;
            lblTitle.Location = new Point(60, 30);
            lblTitle.AutoSize = true;

            // ========== SEARCH BOX ==========
            txtSearch.Location = new Point(65, 90);
            txtSearch.PlaceholderText = "Search Member 🔍";
            txtSearch.Size = new Size(300, 30);
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // ========== DATAGRIDVIEW ==========
            dgvMembers.Location = new Point(250, 140);
            dgvMembers.Size = new Size(1170, 980);
            dgvMembers.ReadOnly = true;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.RowTemplate.Height = 45; // ✅ Taller row height
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.GridColor = Color.FromArgb(240, 240, 240);
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.DefaultCellStyle.Padding = new Padding(10, 8, 10, 8);
            dgvMembers.DefaultCellStyle.BackColor = Color.White;
            dgvMembers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 235, 255);
            dgvMembers.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMembers.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvMembers.CellClick += dgvMembers_CellClick;


            // ========== FORM ==========
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1100);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
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
