namespace LibraryManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUser;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUser = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblPass = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Library Management System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(9, 132);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(63, 15);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(78, 132);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(180, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(65, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(165, 256);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 39);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(9, 178);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(60, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password:";
            // 
            // LoginForm
            // 
            ClientSize = new Size(342, 411);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblPass;
    }
}
