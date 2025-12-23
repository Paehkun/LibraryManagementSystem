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
        private ComboBox cmbCategory;
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
            cmbCategory = new ComboBox();
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
            txtImg = new TextBox();
            lblimg = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Location = new Point(125, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Book Title";
            txtTitle.Size = new Size(198, 23);
            txtTitle.TabIndex = 4;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.White;
            txtAuthor.Location = new Point(125, 60);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author";
            txtAuthor.Size = new Size(198, 23);
            txtAuthor.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(125, 100);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(198, 23);
            cmbCategory.TabIndex = 6;
            // 
            // txtCopies
            // 
            txtCopies.BackColor = Color.White;
            txtCopies.Location = new Point(125, 140);
            txtCopies.Name = "txtCopies";
            txtCopies.PlaceholderText = "Copies";
            txtCopies.Size = new Size(198, 23);
            txtCopies.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.White;
            txtISBN.Location = new Point(125, 179);
            txtISBN.Name = "txtISBN";
            txtISBN.PlaceholderText = "ISBN Number";
            txtISBN.Size = new Size(198, 23);
            txtISBN.TabIndex = 8;
            // 
            // txtPublisher
            // 
            txtPublisher.BackColor = Color.White;
            txtPublisher.Location = new Point(125, 217);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.PlaceholderText = "Publisher";
            txtPublisher.Size = new Size(198, 23);
            txtPublisher.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.White;
            txtYear.Location = new Point(125, 256);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Year";
            txtYear.Size = new Size(198, 23);
            txtYear.TabIndex = 10;
            // 
            // txtShelfLocation
            // 
            txtShelfLocation.BackColor = Color.White;
            txtShelfLocation.Location = new Point(125, 296);
            txtShelfLocation.Name = "txtShelfLocation";
            txtShelfLocation.PlaceholderText = "Shelf Location";
            txtShelfLocation.Size = new Size(198, 23);
            txtShelfLocation.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.Location = new Point(137, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.Location = new Point(236, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 23);
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
            lblCategory.Location = new Point(20, 103);
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
            lblISBN.Location = new Point(20, 179);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(35, 15);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN:";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(20, 220);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(59, 15);
            lblPublisher.TabIndex = 5;
            lblPublisher.Text = "Publisher:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(20, 259);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 6;
            lblYear.Text = "Year:";
            // 
            // lblShelfLocation
            // 
            lblShelfLocation.AutoSize = true;
            lblShelfLocation.Location = new Point(20, 299);
            lblShelfLocation.Name = "lblShelfLocation";
            lblShelfLocation.Size = new Size(85, 15);
            lblShelfLocation.TabIndex = 7;
            lblShelfLocation.Text = "Shelf Location:";
            // 
            // txtImg
            // 
            txtImg.BackColor = Color.White;
            txtImg.Location = new Point(125, 336);
            txtImg.Name = "txtImg";
            txtImg.PlaceholderText = "Image URL";
            txtImg.Size = new Size(198, 23);
            txtImg.TabIndex = 12;
            // 
            // lblimg
            // 
            lblimg.AutoSize = true;
            lblimg.Location = new Point(20, 336);
            lblimg.Name = "lblimg";
            lblimg.Size = new Size(68, 15);
            lblimg.TabIndex = 15;
            lblimg.Text = "Image Link:";
            // 
            // AddBookForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(433, 496);
            Controls.Add(lblimg);
            Controls.Add(txtImg);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblCategory);
            Controls.Add(lblCopies);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(cmbCategory);
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
        private TextBox txtImg;
        private Label lblimg;
    }
}
