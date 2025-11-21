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
            roundedLabel1 = new RoundedLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(853, 350);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Library Management System";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.White;
            lblUser.Location = new Point(908, 488);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 15);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(908, 506);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(180, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(908, 589);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(886, 650);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(227, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.RoyalBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(961, 698);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 28);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.White;
            lblPass.Location = new Point(908, 571);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // roundedLabel1
            // 
            roundedLabel1.BackColor = Color.White;
            roundedLabel1.BorderColor = Color.White;
            roundedLabel1.BorderRadius = 30;
            roundedLabel1.BorderSize = 0;
            roundedLabel1.ForeColor = Color.Black;
            roundedLabel1.Location = new Point(826, 331);
            roundedLabel1.Name = "roundedLabel1";
            roundedLabel1.Size = new Size(355, 416);
            roundedLabel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(955, 418);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 14;
            label1.Text = "Log In";
            // 
            // LoginForm
            // 
            BackColor = Color.Beige;
            ClientSize = new Size(1430, 787);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(roundedLabel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblPass;
        private RoundedLabel roundedLabel1;
        private Label label1;
    }
}
