namespace LibraryManagement
{
    partial class EditUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblID;
        private Label lblName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;

        private Button btnLoad;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox CMRole;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblID = new Label();
            lblName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            CMRole = new ComboBox();
            lblEmail = new Label();
            lblPhone = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Location = new Point(117, 30);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "User ID";
            txtID.Size = new Size(95, 23);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(117, 68);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(117, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(193, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(117, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(193, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.Location = new Point(42, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(54, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblName
            // 
            lblName.Location = new Point(42, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(42, 106);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username::";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(42, 141);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            lblRole.Location = new Point(42, 176);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Gainsboro;
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
            btnSave.BackColor = Color.Gainsboro;
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
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.Location = new Point(192, 317);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CMRole
            // 
            CMRole.ForeColor = Color.Gray;
            CMRole.FormattingEnabled = true;
            CMRole.Items.AddRange(new object[] { "Admin\t\t", "Librarian" });
            CMRole.Location = new Point(117, 176);
            CMRole.Name = "CMRole";
            CMRole.Size = new Size(193, 23);
            CMRole.TabIndex = 5;
            CMRole.Text = "User Role";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(42, 211);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(42, 243);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(118, 245);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone Number";
            txtPhone.Size = new Size(192, 23);
            txtPhone.TabIndex = 7;
            // 
            // EditUserForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(356, 434);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblRole);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(CMRole);
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit User";
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private ComboBox comboBox1;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtEmail;
        private TextBox txtPhone;
    }
}