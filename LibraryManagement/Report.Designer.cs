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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            // 
            // btnBack
            // 
            this.btnBack.Text = "← Back";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.Location = new System.Drawing.Point(20, 12);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "📊 Report - Returned Books";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(140, 15);
            this.lblTitle.AutoSize = true;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.AliceBlue;
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Height = 120;
            this.panelFilter.Controls.Add(this.btnExportPdf);
            this.panelFilter.Controls.Add(this.btnExportCsv);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.dtpEnd);
            this.panelFilter.Controls.Add(this.dtpStart);
            this.panelFilter.Controls.Add(this.txtBookTitle);
            this.panelFilter.Controls.Add(this.txtMemberName);
            this.panelFilter.Controls.Add(this.lblEnd);
            this.panelFilter.Controls.Add(this.lblStart);
            this.panelFilter.Controls.Add(this.lblBookTitle);
            this.panelFilter.Controls.Add(this.lblMember);
            // Filter controls (same as before)
            this.lblMember.Text = "Member Name:";
            this.lblMember.Location = new System.Drawing.Point(20, 20);
            this.lblMember.AutoSize = true;
            this.txtMemberName.Location = new System.Drawing.Point(120, 18);
            this.txtMemberName.Width = 150;
            this.lblBookTitle.Text = "📚 Book:";
            this.lblBookTitle.Location = new System.Drawing.Point(280, 20);
            this.lblBookTitle.AutoSize = true;
            this.txtBookTitle.Location = new System.Drawing.Point(340, 18);
            this.txtBookTitle.Width = 150;
            this.lblStart.Text = "📅 From:";
            this.lblStart.Location = new System.Drawing.Point(550, 20);
            this.lblStart.AutoSize = true;
            this.dtpStart.Location = new System.Drawing.Point(610, 18);
            this.dtpStart.Width = 170;
            this.lblEnd.Text = "To:";
            this.lblEnd.Location = new System.Drawing.Point(740, 20);
            this.lblEnd.AutoSize = true;
            this.dtpEnd.Location = new System.Drawing.Point(810, 18);
            this.dtpEnd.Width = 170;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(1000, 16);
            this.btnFilter.Size = new System.Drawing.Size(80, 30);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            this.btnExportCsv.Text = "⬇️ Export CSV";
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCsv.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Location = new System.Drawing.Point(20, 70);
            this.btnExportCsv.Size = new System.Drawing.Size(120, 30);
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            this.btnExportPdf.Text = "⬇️ Export PDF";
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.BackColor = System.Drawing.Color.DarkRed;
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.Location = new System.Drawing.Point(160, 70);
            this.btnExportPdf.Size = new System.Drawing.Size(120, 30);
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // dgvReport
            // 
            //this.dgvReport.Size = new System.Drawing.Size(1300, 500);
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
            this.dgvReport.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            //this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.RowHeadersVisible = false;
            //this.dgvReport.Location = new System.Drawing.Point((this.ClientSize.Width - this.dgvReport.Width) / 100, 180);
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            this.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvReport.ColumnHeadersHeight = 42;
            this.dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = Color.White;
            this.dgvReport.BorderStyle = BorderStyle.None;
            this.dgvReport.Location = new Point(320, 180);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.GridColor = Color.LightGray;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvReport.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            this.dgvReport.Size = new Size(480, 500);
            this.dgvReport.TabIndex = 0;
            //
            // Report Form
            //
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report - Returned Books";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
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
