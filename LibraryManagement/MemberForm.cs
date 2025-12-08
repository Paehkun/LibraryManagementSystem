using LibraryManagement.Domain.Model;
using LibraryManagementSystem.Domain.Repository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MemberForm : Form
    {
        private MemberRepository _memberRepo;
        public MemberForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _memberRepo = new MemberRepository(db);
        }

        private void lblMembershipDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            var member = new Member
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                MembershipDate = dtpMembershipDate.Value
            };

            try
            {
                _memberRepo.AddMember(member); // using repository
                MessageBox.Show("Member added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
