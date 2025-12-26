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
    
    public partial class DeleteMemberForm : Form
    {
        private MemberRepository _memberRepo;
        public DeleteMemberForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _memberRepo = new MemberRepository(db);

        }

        private void DeleteMemberForm_Load(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmember.Text.Trim(), out int memberID))
            {
                MessageBox.Show("Invalid Member ID. Please enter a number.");
                return;
            }

            try
            {

                if (!_memberRepo.MemberExists(memberID))
                {
                    MessageBox.Show("Member with this ID does not exist.");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this member?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                _memberRepo.SoftDeleteMember(memberID);

                MessageBox.Show("Member deleted successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmember_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
