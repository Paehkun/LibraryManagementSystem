using LibraryManagementSystem;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class SelectMemberForm : Form
    {
        public string SelectedMemberId { get; private set; }
        public string SelectedMemberName { get; private set; }
        public string SelectedMemberPhone {get; private set;}

        public SelectMemberForm()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void LoadMembers()
        {
            DataTable dt = DatabaseHelper.GetAllMembers(); // You already have this
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectedMemberId = dataGridView1.SelectedRows[0].Cells["memberid"].Value.ToString();
                SelectedMemberName = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please select a member.");
            }
        }
    }
}
