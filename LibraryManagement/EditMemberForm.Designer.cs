namespace LibraryManagement
{
    partial class EditMemberForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtMemberID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private DateTimePicker dtpMembershipDate;
        private Label lblMemberID;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblMembershipDate;

        private Button btnLoad;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtMemberID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            lblMemberID = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblMembershipDate = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            dtpMembershipDate = new DateTimePicker();
            SuspendLayout();
            // 
            // txtMemberID
            // 
            txtMemberID.BackColor = Color.White;
            txtMemberID.Location = new Point(142, 30);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(70, 23);
            txtMemberID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(142, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 23);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(142, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Location = new Point(142, 138);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(168, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Location = new Point(142, 173);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(168, 23);
            txtAddress.TabIndex = 4;
            // 
            // lblMemberID
            // 
            lblMemberID.Location = new Point(42, 33);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(90, 23);
            lblMemberID.TabIndex = 0;
            lblMemberID.Text = "Member ID:";
            // 
            // lblName
            // 
            lblName.Location = new Point(42, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(42, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(42, 141);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(90, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(42, 176);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(90, 23);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblMembershipDate
            // 
            lblMembershipDate.AutoSize = true;
            lblMembershipDate.Location = new Point(42, 210);
            lblMembershipDate.Name = "lblMembershipDate";
            lblMembershipDate.Size = new Size(34, 15);
            lblMembershipDate.TabIndex = 4;
            lblMembershipDate.Text = "Date:";
            lblMembershipDate.Click += lblMembershipDate_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.Location = new Point(232, 30);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(82, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Location = new Point(192, 317);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpMembershipDate
            // 
            dtpMembershipDate.Format = DateTimePickerFormat.Short;
            dtpMembershipDate.Location = new Point(143, 208);
            dtpMembershipDate.Name = "dtpMembershipDate";
            dtpMembershipDate.Size = new Size(150, 23);
            dtpMembershipDate.TabIndex = 8;
            // 
            // EditMemberForm
            // 
            BackColor = Color.FromArgb(33, 150, 243);
            ClientSize = new Size(356, 434);
            Controls.Add(lblMemberID);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblMembershipDate);
            Controls.Add(txtMemberID);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(dtpMembershipDate);
            Name = "EditMemberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Member";
            Load += EditMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}