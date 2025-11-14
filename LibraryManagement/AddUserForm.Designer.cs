namespace LibraryManagement
{

    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private DateTimePicker dtpMembershipDate;
        private Button btnSave;
        private Button btnCancel;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblMembershipDate;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            dtpMembershipDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblMembershipDate = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(100, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(100, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Location = new Point(100, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Location = new Point(100, 140);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 7;
            // 
            // dtpMembershipDate
            // 
            dtpMembershipDate.Format = DateTimePickerFormat.Short;
            dtpMembershipDate.Location = new Point(100, 182);
            dtpMembershipDate.Name = "dtpMembershipDate";
            dtpMembershipDate.Size = new Size(150, 23);
            dtpMembershipDate.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(100, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Location = new Point(223, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Username:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Password:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(20, 143);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Role:";
            // 
            // MemberForm
            // 
            BackColor = Color.FromArgb(33, 150, 243);
            ClientSize = new Size(470, 378);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New User";
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}