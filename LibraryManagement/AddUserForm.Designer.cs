namespace LibraryManagement
{

    partial class AddUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label lblName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;
        private Label lblMembershipDate;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            comboBox1 = new ComboBox();
            lblPhone = new Label();
            lblEmail = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(100, 20);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(140, 23);
            txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(100, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(140, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(100, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(140, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.Location = new Point(79, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.Location = new Point(202, 281);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 212);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role:";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Librarian" });
            comboBox1.Location = new Point(100, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "User Role";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 136);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 175);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(100, 133);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(140, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(140, 23);
            txtEmail.TabIndex = 8;
            // 
            // AddUserForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(394, 375);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(comboBox1);
            Controls.Add(lblName);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblRole);
            Controls.Add(txtName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
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
        private ComboBox comboBox1;
        private Label lblPhone;
        private Label lblEmail;
        private TextBox txtPhone;
        private TextBox txtEmail;
    }
}