using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibrarianHomeForm : Form
    {
        private string username;

        public LibrarianHomeForm(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = $"Welcome, {username}";
        }

        private void LibrarianHomeForm_Load(object sender, EventArgs e)
        {
            // You can initialize anything here if needed
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Book Management Page");
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Borrow/Return Page");
        }

        private void btnMemberRecords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Member Records Page");
        }

        private void btnBookCatalog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Book Catalog Page");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Reports Page");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
