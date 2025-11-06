namespace LibraryManagementSystem
{
    partial class EditBookForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtBookId;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtCategory;
        private TextBox txtPublisher;
        private TextBox txtYear;
        private TextBox txtCopies;
        private TextBox txtShelfLocation;

        private Label lblBookId;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblCategory;
        private Label lblPublisher;
        private Label lblYear;
        private Label lblCopies;
        private Label lblShelfLocation;

        private Button btnLoad;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtBookId = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtCategory = new TextBox();
            txtPublisher = new TextBox();
            txtYear = new TextBox();
            txtCopies = new TextBox();
            txtShelfLocation = new TextBox();
            lblBookId = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            lblCategory = new Label();
            lblPublisher = new Label();
            lblYear = new Label();
            lblCopies = new Label();
            lblShelfLocation = new Label();
            btnLoad = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtBookId
            // 
            txtBookId.BackColor = Color.White;
            txtBookId.Location = new Point(120, 17);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(70, 23);
            txtBookId.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Location = new Point(120, 55);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(168, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.White;
            txtAuthor.Location = new Point(120, 90);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(168, 23);
            txtAuthor.TabIndex = 2;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.White;
            txtISBN.Location = new Point(120, 125);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(168, 23);
            txtISBN.TabIndex = 3;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.White;
            txtCategory.Location = new Point(120, 160);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(168, 23);
            txtCategory.TabIndex = 4;
            // 
            // txtPublisher
            // 
            txtPublisher.BackColor = Color.White;
            txtPublisher.Location = new Point(120, 195);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(168, 23);
            txtPublisher.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.White;
            txtYear.Location = new Point(120, 230);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(168, 23);
            txtYear.TabIndex = 6;
            // 
            // txtCopies
            // 
            txtCopies.BackColor = Color.White;
            txtCopies.Location = new Point(120, 265);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(168, 23);
            txtCopies.TabIndex = 7;
            // 
            // txtShelfLocation
            // 
            txtShelfLocation.BackColor = Color.White;
            txtShelfLocation.Location = new Point(120, 300);
            txtShelfLocation.Name = "txtShelfLocation";
            txtShelfLocation.Size = new Size(168, 23);
            txtShelfLocation.TabIndex = 8;
            // 
            // lblBookId
            // 
            lblBookId.Location = new Point(20, 20);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(90, 23);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Book ID:";
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(20, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            lblAuthor.Location = new Point(20, 93);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 23);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author:";
            // 
            // lblISBN
            // 
            lblISBN.Location = new Point(20, 128);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(90, 23);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(20, 163);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 23);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            // 
            // lblPublisher
            // 
            lblPublisher.Location = new Point(20, 198);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(90, 23);
            lblPublisher.TabIndex = 5;
            lblPublisher.Text = "Publisher:";
            // 
            // lblYear
            // 
            lblYear.Location = new Point(20, 233);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(90, 23);
            lblYear.TabIndex = 6;
            lblYear.Text = "Year:";
            // 
            // lblCopies
            // 
            lblCopies.Location = new Point(20, 268);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(90, 23);
            lblCopies.TabIndex = 7;
            lblCopies.Text = "Copies:";
            // 
            // lblShelfLocation
            // 
            lblShelfLocation.Location = new Point(20, 303);
            lblShelfLocation.Name = "lblShelfLocation";
            lblShelfLocation.Size = new Size(90, 23);
            lblShelfLocation.TabIndex = 8;
            lblShelfLocation.Text = "Shelf Location:";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.Location = new Point(210, 17);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Location = new Point(60, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Location = new Point(170, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditBookForm
            // 
            BackColor = Color.FromArgb(33, 150, 243);
            ClientSize = new Size(330, 400);
            Controls.Add(lblBookId);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblISBN);
            Controls.Add(lblCategory);
            Controls.Add(lblPublisher);
            Controls.Add(lblYear);
            Controls.Add(lblCopies);
            Controls.Add(lblShelfLocation);
            Controls.Add(txtBookId);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(txtISBN);
            Controls.Add(txtCategory);
            Controls.Add(txtPublisher);
            Controls.Add(txtYear);
            Controls.Add(txtCopies);
            Controls.Add(txtShelfLocation);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Book";
            Load += EditBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
