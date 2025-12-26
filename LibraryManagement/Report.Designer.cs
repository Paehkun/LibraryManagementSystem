using System.Windows.Forms;
using System.Drawing;

namespace LibraryManagement
{
    partial class Report
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.DataGridView dgvReport;

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
            filterPanel = new System.Windows.Forms.Panel();
            mainPanel = new System.Windows.Forms.Panel();
            btnBack = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            lblMemberName = new System.Windows.Forms.Label();
            lblBookTitle = new System.Windows.Forms.Label();
            lblStartDate = new System.Windows.Forms.Label();
            lblEndDate = new System.Windows.Forms.Label();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtBookTitle = new System.Windows.Forms.TextBox();
            dtpStart = new System.Windows.Forms.DateTimePicker();
            dtpEnd = new System.Windows.Forms.DateTimePicker();
            btnFilter = new System.Windows.Forms.Button();
            btnExportCsv = new System.Windows.Forms.Button();
            btnExportPdf = new System.Windows.Forms.Button();
            dgvReport = new System.Windows.Forms.DataGridView();

            topPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();

            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            topPanel.Controls.Add(btnBack);
            topPanel.Controls.Add(lblTitle);
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
            lblTitle.Size = new System.Drawing.Size(400, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📊 Returned Books Report";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // filterPanel
            // 
            filterPanel.BackColor = System.Drawing.Color.White;
            filterPanel.Controls.Add(lblMemberName);
            filterPanel.Controls.Add(txtMemberName);
            filterPanel.Controls.Add(lblBookTitle);
            filterPanel.Controls.Add(txtBookTitle);
            filterPanel.Controls.Add(lblStartDate);
            filterPanel.Controls.Add(dtpStart);
            filterPanel.Controls.Add(lblEndDate);
            filterPanel.Controls.Add(dtpEnd);
            filterPanel.Controls.Add(btnFilter);
            filterPanel.Controls.Add(btnExportCsv);
            filterPanel.Controls.Add(btnExportPdf);
            filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            filterPanel.Location = new System.Drawing.Point(0, 70);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            filterPanel.Size = new System.Drawing.Size(1920, 120);
            filterPanel.TabIndex = 1;

            // 
            // lblMemberName
            // 
            lblMemberName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblMemberName.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblMemberName.Location = new System.Drawing.Point(50, 25);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new System.Drawing.Size(120, 25);
            lblMemberName.TabIndex = 0;
            lblMemberName.Text = "👤 Member:";
            lblMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtMemberName
            // 
            txtMemberName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtMemberName.Location = new System.Drawing.Point(170, 25);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.PlaceholderText = "Search by member name...";
            txtMemberName.Size = new System.Drawing.Size(200, 25);
            txtMemberName.TabIndex = 1;

            // 
            // lblBookTitle
            // 
            lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblBookTitle.Location = new System.Drawing.Point(400, 25);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new System.Drawing.Size(100, 25);
            lblBookTitle.TabIndex = 2;
            lblBookTitle.Text = "📚 Book:";
            lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtBookTitle.Location = new System.Drawing.Point(500, 25);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Search by book title...";
            txtBookTitle.Size = new System.Drawing.Size(200, 25);
            txtBookTitle.TabIndex = 3;

            // 
            // lblStartDate
            // 
            lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblStartDate.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblStartDate.Location = new System.Drawing.Point(730, 25);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(80, 25);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "📅 From:";
            lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dtpStart
            // 
            dtpStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpStart.Location = new System.Drawing.Point(810, 25);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new System.Drawing.Size(180, 25);
            dtpStart.TabIndex = 5;

            // 
            // lblEndDate
            // 
            lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblEndDate.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblEndDate.Location = new System.Drawing.Point(1010, 25);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(50, 25);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "To:";
            lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dtpEnd
            // 
            dtpEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpEnd.Location = new System.Drawing.Point(1060, 25);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new System.Drawing.Size(180, 25);
            dtpEnd.TabIndex = 7;

            // 
            // btnFilter
            // 
            btnFilter.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnFilter.ForeColor = System.Drawing.Color.White;
            btnFilter.Location = new System.Drawing.Point(1270, 22);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(100, 32);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "🔍 Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFilter.Click += btnFilter_Click;

            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnExportCsv.FlatAppearance.BorderSize = 0;
            btnExportCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnExportCsv.ForeColor = System.Drawing.Color.White;
            btnExportCsv.Location = new System.Drawing.Point(50, 70);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new System.Drawing.Size(140, 35);
            btnExportCsv.TabIndex = 9;
            btnExportCsv.Text = "📥 Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportCsv.Click += btnExportCsv_Click;

            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnExportPdf.ForeColor = System.Drawing.Color.White;
            btnExportPdf.Location = new System.Drawing.Point(210, 70);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new System.Drawing.Size(140, 35);
            btnExportPdf.TabIndex = 10;
            btnExportPdf.Text = "📥 Export PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportPdf.Click += btnExportPdf_Click;

            // 
            // mainPanel
            // 
            mainPanel.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            mainPanel.Controls.Add(dgvReport);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 190);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(50);
            mainPanel.Size = new System.Drawing.Size(1920, 890);
            mainPanel.TabIndex = 2;

            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.BackgroundColor = System.Drawing.Color.White;
            dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dgvReport.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvReport.ColumnHeadersHeight = 45;
            dgvReport.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvReport.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvReport.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dgvReport.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dgvReport.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvReport.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);
            dgvReport.Location = new System.Drawing.Point(50, 30);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowTemplate.Height = 45;
            dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new System.Drawing.Size(1820, 810);
            dgvReport.TabIndex = 0;
            dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // Report
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1920, 1080);
            Controls.Add(mainPanel);
            Controls.Add(filterPanel);
            Controls.Add(topPanel);
            Name = "Report";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "📊 Returned Books Report - Library System";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Report_Load;

            topPanel.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }
    }
}