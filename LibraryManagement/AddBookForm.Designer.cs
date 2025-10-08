using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtCategory;
        private TextBox txtCopies;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblCategory;
        private Label lblCopies;

        private void InitializeComponent()
        {
            this.txtTitle = new TextBox();
            this.txtAuthor = new TextBox();
            this.txtCategory = new TextBox();
            this.txtCopies = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.lblTitle = new Label();
            this.lblAuthor = new Label();
            this.lblCategory = new Label();
            this.lblCopies = new Label();

            // Labels
            lblTitle.Text = "Title:";
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;

            lblAuthor.Text = "Author:";
            lblAuthor.Location = new Point(20, 60);
            lblAuthor.AutoSize = true;

            lblCategory.Text = "Category:";
            lblCategory.Location = new Point(20, 100);
            lblCategory.AutoSize = true;

            lblCopies.Text = "Copies:";
            lblCopies.Location = new Point(20, 140);
            lblCopies.AutoSize = true;

            // Textboxes
            txtTitle.Location = new Point(100, 20);
            txtAuthor.Location = new Point(100, 60);
            txtCategory.Location = new Point(100, 100);
            txtCopies.Location = new Point(100, 140);

            // Buttons
            btnSave.Text = "Save";
            btnSave.Location = new Point(50, 190);
            btnSave.Click += new EventHandler(btnSave_Click);

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(150, 190);
            btnCancel.Click += new EventHandler(btnCancel_Click);

            // Form
            this.Text = "Add New Book";
            this.ClientSize = new Size(300, 250);
            this.StartPosition = FormStartPosition.CenterParent;

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblAuthor);
            this.Controls.Add(lblCategory);
            this.Controls.Add(lblCopies);
            this.Controls.Add(txtTitle);
            this.Controls.Add(txtAuthor);
            this.Controls.Add(txtCategory);
            this.Controls.Add(txtCopies);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
        }
    }
}
