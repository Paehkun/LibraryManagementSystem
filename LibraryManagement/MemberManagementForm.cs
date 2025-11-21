using LibraryManagement;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MemberManagementForm : Form
    {
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=db123;Database=library_db;";
        private string username;
        private Font buttonFont = new Font("Segoe UI", 10, FontStyle.Bold);
        private Color textColor = Color.Black;
        public MemberManagementForm(string username)
        {
            InitializeComponent();
            this.username = UserSession.Username;
            dgvMembers.CellClick += dgvMembers_CellClick;
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            SetupDataGridView();
            
            foreach (DataGridViewColumn column in dgvMembers.Columns)
            {
                if (!string.IsNullOrEmpty(column.HeaderText))
                {
                    column.HeaderText = char.ToUpper(column.HeaderText[0]) + column.HeaderText.Substring(1);
                }
            }
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // Format column headers
            dgvMembers.Columns["memberid"].HeaderText = "Member ID";
            dgvMembers.Columns["name"].HeaderText = "Name";
            dgvMembers.Columns["email"].HeaderText = "Email";
            dgvMembers.Columns["phone"].HeaderText = "Phone";
            dgvMembers.Columns["address"].HeaderText = "Address";
            dgvMembers.Columns["membershipdate"].HeaderText = "Member Since";

            // Adjust column widths
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvMembers.Columns["memberid"].Width = 60;
            dgvMembers.Columns["name"].Width = 260;
            dgvMembers.Columns["email"].Width = 180;
            dgvMembers.Columns["phone"].Width = 150;
            dgvMembers.Columns["address"].Width = 120;
            dgvMembers.Columns["membershipdate"].Width = 180;
            LoadMembers();
            SetupDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "admin")
            {
                new AdminHomeForm(UserSession.Username).Show();
            }
            else
            {
                new LibrarianHomeForm(UserSession.Username).Show();
            }

            this.Hide();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            using (MemberForm memberForm = new MemberForm())
            {
                if (memberForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers();
                }
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["memberid"].Value);
                using (EditMemberForm editMemberForm = new EditMemberForm(memberId))
                {
                    if (editMemberForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadMembers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to edit.");
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteMemberForm())
            {
                if (deleteForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers();
                    ApplyCardStyle(); // 🔄
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMembers(txtSearch.Text.Trim());
        }

        // ✅ Style and base setup for DataGridView
        private void SetupDataGridView()
        {
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMembers.ColumnHeadersHeight = 40;
            dgvMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void ApplyCardStyle()
        {
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMembers.GridColor = Color.White;
            dgvMembers.RowHeadersVisible = false;

            dgvMembers.DefaultCellStyle.BackColor = Color.White;
            dgvMembers.DefaultCellStyle.ForeColor = Color.Black;
            dgvMembers.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvMembers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgvMembers.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMembers.DefaultCellStyle.Padding = new Padding(12, 10, 12, 10);

            //dgvMembers.RowTemplate.Height = 90;
            dgvMembers.RowTemplate.MinimumHeight = 60;
            dgvMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 250);

            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;

            dgvMembers.CellPainting -= DgvMembers_CellPainting; // avoid double subscription
            dgvMembers.CellPainting += DgvMembers_CellPainting;
        }

        private void DgvMembers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                Rectangle cardRect = e.CellBounds;
                cardRect.Inflate(-5, -5);

                bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;

                Color cardColor = isSelected ? Color.FromArgb(230, 240, 255) : e.CellStyle.BackColor;
                Color borderColor = isSelected ? Color.FromArgb(130, 170, 250) : Color.LightGray;

                using (SolidBrush brush = new SolidBrush(cardColor))
                using (Pen borderPen = new Pen(borderColor, 1))
                {
                    Graphics g = e.Graphics;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    int radius = 10;
                    using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedRectPath(cardRect, radius))
                    {
                        g.FillPath(brush, path);
                        g.DrawPath(borderPen, path);
                    }
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue?.ToString() ?? string.Empty,
                    e.CellStyle.Font,
                    cardRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter
                );
            }
        }
        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void LoadMembers(string search = "")
        {
            DataTable dt = DatabaseHelper.GetAllMembers(search);

            dgvMembers.Columns.Clear(); 
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.DataSource = dt;

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "memberid",
                HeaderText = "Member ID",
                Name = "memberid",
                Width = 100,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                HeaderText = "Name",
                Name = "name",
                Width = 250
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                HeaderText = "Email",
                Name = "email",
                Width = 250
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone",
                HeaderText = "Phone",
                Name = "phone",
                Width = 120
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "address",
                HeaderText = "Address",
                Name = "address",
                Width = 300
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "membershipdate",
                HeaderText = "Member Since",
                Name = "membershipdate",
                Width = 130,
                DefaultCellStyle = { Format = "yyyy-MM-dd", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // ✅ Make sure the style is applied (optional)
            ApplyCardStyle();

            // ✅ Adjust columns layout
           // dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.ColumnHeadersVisible = true;
            dgvMembers.ClearSelection();
        }


        //private void AddActionButtons()
        //{
        ////    if (dgvMembers.Columns.Contains("Edit")) dgvMembers.Columns.Remove("Edit");
        ////    if (dgvMembers.Columns.Contains("Delete")) dgvMembers.Columns.Remove("Delete");

        ////    DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
        ////    {
        ////        HeaderText = "Edit",
        ////        Name = "Edit",
        ////        Text = "Edit",
        ////        UseColumnTextForButtonValue = true,
        ////        FlatStyle = FlatStyle.Flat,
        ////        Width = 70,
        ////        DefaultCellStyle = {
        ////    BackColor = Color.LightSkyBlue,
        ////    ForeColor = Color.White,
        ////    Alignment = DataGridViewContentAlignment.MiddleCenter
        ////}
        ////    };

        ////    DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
        ////    {
        ////        HeaderText = "Delete",
        ////        Name = "Delete",
        ////        Text = "Delete",
        ////        UseColumnTextForButtonValue = true,
        ////        FlatStyle = FlatStyle.Flat,
        ////        Width = 70,
        ////        DefaultCellStyle = {
        ////    BackColor = Color.LightCoral,
        ////    ForeColor = Color.White,
        ////    Alignment = DataGridViewContentAlignment.MiddleCenter
        ////}
        ////    };

        ////    dgvMembers.Columns.Add(editBtn);
        ////    dgvMembers.Columns.Add(deleteBtn);
        //}


        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string col = dgvMembers.Columns[e.ColumnIndex].Name;
                if (col == "Edit") btnEditMember_Click(sender, e);
                else if (col == "Delete") btnDeleteMember_Click(sender, e);
            }
        }
    }
}
