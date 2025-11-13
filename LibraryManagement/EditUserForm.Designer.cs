namespace LibraryManagement
{
    partial class EditUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Label lblID;
        private Label lblName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;

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
            txtID = new TextBox();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            lblID = new Label();
            lblName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Location = new Point(142, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(70, 23);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(142, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 23);
            txtName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(142, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(168, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(142, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.White;
            txtRole.Location = new Point(142, 173);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(168, 23);
            txtRole.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.Location = new Point(42, 33);
            lblID.Name = "lblID";
            lblID.Size = new Size(90, 23);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblName
            // 
            lblName.Location = new Point(42, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(42, 106);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(90, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username::";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(42, 141);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            lblRole.Location = new Point(42, 176);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(90, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
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
            // EditUserForm
            // 
            BackColor = Color.FromArgb(33, 150, 243);
            ClientSize = new Size(356, 434);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblRole);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit User";
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}