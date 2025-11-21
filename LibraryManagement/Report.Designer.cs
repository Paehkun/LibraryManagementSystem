using System.Windows.Forms;

namespace LibraryManagement
{
    partial class Report
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelTop = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            panelFilter = new Panel();
            btnExportPdf = new Button();
            btnExportCsv = new Button();
            btnFilter = new Button();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            txtBookTitle = new TextBox();
            txtMemberName = new TextBox();
            lblEnd = new Label();
            lblStart = new Label();
            lblBookTitle = new Label();
            lblMember = new Label();
            dgvReport = new DataGridView();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.RoyalBlue;
            panelTop.Controls.Add(btnBack);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 60);
            panelTop.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RoyalBlue;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(20, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 35);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(140, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📊 Report Returned Books";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.AliceBlue;
            panelFilter.Controls.Add(btnExportPdf);
            panelFilter.Controls.Add(btnExportCsv);
            panelFilter.Controls.Add(btnFilter);
            panelFilter.Controls.Add(dtpEnd);
            panelFilter.Controls.Add(dtpStart);
            panelFilter.Controls.Add(txtBookTitle);
            panelFilter.Controls.Add(txtMemberName);
            panelFilter.Controls.Add(lblEnd);
            panelFilter.Controls.Add(lblStart);
            panelFilter.Controls.Add(lblBookTitle);
            panelFilter.Controls.Add(lblMember);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 60);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1100, 120);
            panelFilter.TabIndex = 1;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.DarkRed;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(160, 70);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(120, 30);
            btnExportPdf.TabIndex = 0;
            btnExportPdf.Text = "⬇️ Export PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.ForestGreen;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportCsv.ForeColor = Color.White;
            btnExportCsv.Location = new Point(20, 70);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(120, 30);
            btnExportCsv.TabIndex = 1;
            btnExportCsv.Text = "⬇️ Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.SteelBlue;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(1000, 16);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 30);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(810, 18);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(170, 23);
            dtpEnd.TabIndex = 3;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(610, 18);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(170, 23);
            dtpStart.TabIndex = 4;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(340, 18);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(150, 23);
            txtBookTitle.TabIndex = 5;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(120, 18);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(150, 23);
            txtMemberName.TabIndex = 6;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(740, 20);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(22, 15);
            lblEnd.TabIndex = 7;
            lblEnd.Text = "To:";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(550, 20);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(53, 15);
            lblStart.TabIndex = 8;
            lblStart.Text = "📅 From:";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(280, 20);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(52, 15);
            lblBookTitle.TabIndex = 9;
            lblBookTitle.Text = "📚 Book:";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Location = new Point(20, 20);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(90, 15);
            lblMember.TabIndex = 10;
            lblMember.Text = "Member Name:";
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.ColumnHeadersHeight = 42;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle4;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.LightGray;
            dgvReport.Location = new Point(320, 180);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.Size = new Size(480, 500);
            dgvReport.TabIndex = 0;
            // 
            // Report
            // 
            ClientSize = new Size(1100, 700);
            Controls.Add(dgvReport);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report - Returned Books";
            WindowState = FormWindowState.Maximized;
            Load += Report_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }


        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}
