namespace LibraryManagement
{
    partial class SelectBooksForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Select Books";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(25, 55);
            this.dataGridView1.Size = new System.Drawing.Size(640, 300);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.MultiSelect = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 
            // btnSelect
            // 
            this.btnSelect.Text = "Select";
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.Size = new System.Drawing.Size(100, 35);
            this.btnSelect.Location = new System.Drawing.Point(445, 370);
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Location = new System.Drawing.Point(565, 370);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Books";
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
