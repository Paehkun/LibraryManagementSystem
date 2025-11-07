using Npgsql;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        private string name;
        private string username;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";

        public AdminHomeForm(string username)
        {
            InitializeComponent();
            this.username = username;
            FetchFullNameFromDB();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {name}";
        }

        private void FetchFullNameFromDB()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT name FROM users WHERE username = @username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        name = result.ToString();
                    }
                }
            }
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
