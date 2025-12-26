using LibraryManagement;
using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private UserRepository _userRepo;

        public LoginForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _userRepo = new UserRepository(db);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Users? user = _userRepo.Authenticate(username, password);
                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserSession.Username = user.Username;
                UserSession.Role = user.Role.ToLower();

                Form nextForm = user.Role.ToLower() == "admin"
                                ? new AdminHomeForm(user.Username)
                                : new LibrarianHomeForm(user.Username);

                this.Hide();
                nextForm.FormClosed += (s, args) => this.Close();
                nextForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
