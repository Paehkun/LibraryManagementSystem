namespace LibraryManagement
{
    partial class DeleteMemberForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblmember;
        private TextBox txtmember;
        private Button btnDelete;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblmember = new Label();
            txtmember = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblmember
            // 
            lblmember.Location = new Point(12, 76);
            lblmember.Name = "lblmember";
            lblmember.Size = new Size(77, 23);
            lblmember.TabIndex = 0;
            lblmember.Text = "Member ID:";
            // 
            // txtmember
            // 
            txtmember.BackColor = Color.Beige;
            txtmember.Location = new Point(86, 73);
            txtmember.Name = "txtmember";
            txtmember.Size = new Size(146, 23);
            txtmember.TabIndex = 1;
            txtmember.TextChanged += txtmember_TextChanged;
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
            label1.Text = "Enter the member id that need to be delete";
            label1.Click += label1_Click;
            // 
            // DeleteMemberForm
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(295, 208);
            Controls.Add(label1);
            Controls.Add(lblmember);
            Controls.Add(txtmember);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Name = "DeleteMemberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Book";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}