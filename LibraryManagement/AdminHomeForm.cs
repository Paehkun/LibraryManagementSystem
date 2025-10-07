using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        private string _username;

        public AdminHomeForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_username} (Admin)";
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Manage Books page (to be implemented).");
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Manage Users page (to be implemented).");
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Reports page (to be implemented).");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Go back to login form
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
