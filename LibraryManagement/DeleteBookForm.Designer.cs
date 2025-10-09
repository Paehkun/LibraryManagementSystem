namespace LibraryManagement
{
    partial class DeleteBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblISBN;
        private TextBox txtISBN;
        private Button btnDelete;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblISBN = new Label();
            txtISBN = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblISBN
            // 
            lblISBN.Location = new Point(12, 76);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(43, 23);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.Beige;
            txtISBN.Location = new Point(61, 73);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(180, 23);
            txtISBN.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(52, 117);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Location = new Point(156, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(271, 33);
            label1.TabIndex = 4;
            label1.Text = "Enter the ISBN number of the book that need to be delete";
            // 
            // DeleteBookForm
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(295, 208);
            Controls.Add(label1);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Name = "DeleteBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Book";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
