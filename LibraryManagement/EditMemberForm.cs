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
using LibraryManagementSystem.Domain.Repository;

namespace LibraryManagement
{
    public partial class EditMemberForm : Form
    {
        private int _memberId;
        private MemberRepository _memberRepo;
        public EditMemberForm(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;
            DBConnection db = new DBConnection();
            _memberRepo = new MemberRepository(db);
        }
        public EditMemberForm()
        {
            InitializeComponent();
            DBConnection db = new DBConnection();
            _memberRepo = new MemberRepository(db);
        }


        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            if (_memberId > 0)
            {
                LoadMemberData(_memberId);
                txtMemberID.ReadOnly = false;
            }
        }

        private void lblMembershipDate_Click(object sender, EventArgs e)
        {

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberID.Text.Trim(), out int memberId))
            {
                MessageBox.Show("Please enter a valid Member ID.");
                return;
            }

            if (!_memberRepo.MemberExists(memberId))
            {
                MessageBox.Show("No member found with this ID.");
                return;
            }

            LoadMemberData(memberId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMemberID.Text.Trim(), out int memberId) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            try
            {
                _memberRepo.EditMember(
                    memberId,
                    txtName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim()
                );

                MessageBox.Show("Member data updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadMemberData(int memberId)
        {
            try
            {
                DataRow member = _memberRepo.GetMemberById(memberId);

                if (member == null)
                {
                    MessageBox.Show("No member found with this ID.");
                    return;
                }

                txtMemberID.Text = member["memberid"].ToString();
                txtName.Text = member["name"].ToString();
                txtEmail.Text = member["email"].ToString();
                txtPhone.Text = member["phone"].ToString();
                txtAddress.Text = member["address"].ToString();
                dtpMembershipDate.Value = Convert.ToDateTime(member["membershipdate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member: " + ex.Message);
            }
        }

    }
}
