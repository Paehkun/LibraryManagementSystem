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
        private TextBox txtISBN;
        private TextBox txtPublisher;
        private TextBox txtYear;
        private TextBox txtShelfLocation;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblCategory;
        private Label lblCopies;
        private Label lblISBN;
        private Label lblPublisher;
        private Label lblYear;
        private Label lblShelfLocation;

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtCategory = new TextBox();
            txtCopies = new TextBox();
            txtISBN = new TextBox();
            txtPublisher = new TextBox();
            txtYear = new TextBox();
            txtShelfLocation = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            lblCopies = new Label();
            lblISBN = new Label();
            lblPublisher = new Label();
            lblYear = new Label();
            lblShelfLocation = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Beige;
            txtTitle.Location = new Point(100, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 4;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.Beige;
            txtAuthor.Location = new Point(100, 60);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.Beige;
            txtCategory.Location = new Point(100, 100);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 6;
            // 
            // txtCopies
            // 
            txtCopies.BackColor = Color.Beige;
            txtCopies.Location = new Point(100, 140);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(100, 23);
            txtCopies.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.Beige;
            txtISBN.Location = new Point(223, 20);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 8;
            // 
            // txtPublisher
            // 
            txtPublisher.BackColor = Color.Beige;
            txtPublisher.Location = new Point(223, 60);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(100, 23);
            txtPublisher.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.Beige;
            txtYear.Location = new Point(223, 100);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 10;
            // 
            // txtShelfLocation
            // 
            txtShelfLocation.BackColor = Color.Beige;
            txtShelfLocation.Location = new Point(223, 143);
            txtShelfLocation.Name = "txtShelfLocation";
            txtShelfLocation.Size = new Size(100, 23);
            txtShelfLocation.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(109, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Location = new Point(233, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(20, 60);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.Location = new Point(20, 143);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(46, 15);
            lblCopies.TabIndex = 3;
            lblCopies.Text = "Copies:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(351, 20);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(35, 15);
            lblISBN.TabIndex = 4;
            lblISBN.Text = ":ISBN";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(351, 60);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(59, 15);
            lblPublisher.TabIndex = 5;
            lblPublisher.Text = ":Publisher";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(351, 100);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 6;
            lblYear.Text = ":Year";
            // 
            // lblShelfLocation
            // 
            lblShelfLocation.AutoSize = true;
            lblShelfLocation.Location = new Point(351, 143);
            lblShelfLocation.Name = "lblShelfLocation";
            lblShelfLocation.Size = new Size(85, 15);
            lblShelfLocation.TabIndex = 7;
            lblShelfLocation.Text = ":Shelf Location";
            // 
            // AddBookForm
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(470, 291);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblCategory);
            Controls.Add(lblCopies);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(txtCategory);
            Controls.Add(txtCopies);
            Controls.Add(txtISBN);
            Controls.Add(txtPublisher);
            Controls.Add(txtYear);
            Controls.Add(txtShelfLocation);
            Controls.Add(lblISBN);
            Controls.Add(lblPublisher);
            Controls.Add(lblYear);
            Controls.Add(lblShelfLocation);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Book";
            Load += AddBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
