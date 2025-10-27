using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace LibraryManagementSystem
{
    public partial class BookCatalogForm : Form
    {
        public BookCatalogForm()
        {
            InitializeComponent();
        }

        private void BookCatalogForm_Load(object sender, EventArgs e)
        {
            // Create Back button
            btnBack = new Button
            {
                Text = "← Back",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 90,
                Height = 32
            };
            btnBack.FlatAppearance.BorderSize = 0;

            // Position: left side of the search TextBox
            // Assuming your txtSearch is near top-right area — we'll align accordingly
            btnBack.Location = new Point(txtSearch.Left - btnBack.Width - 10, txtSearch.Top);

            // Add click event
            btnBack.Click += BtnBack_Click;

            // Add button to the form
            this.Controls.Add(btnBack);
            LoadBooks();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm librarianHome = new LibrarianHomeForm("Librarian");
            librarianHome.Show();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBooks(txtSearch.Text.Trim());
        }

        private void LoadBooks(string search = "")
        {
            flowPanel.Controls.Clear();
            DataTable dt = GetBooks(search);

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel
                {
                    Width = 250,
                    Height = 330,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Book Cover (image from URL)
                PictureBox pic = new PictureBox
                {
                    Width = 220,
                    Height = 180,
                    Location = new Point(15, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var imgUrl = row["image"].ToString();

                if (!string.IsNullOrEmpty(imgUrl))
                {
                    // Load the image asynchronously to avoid freezing the UI
                    Task.Run(() =>
                    {
                        try
                        {
                            using (var client = new WebClient())
                            {
                                byte[] data = client.DownloadData(imgUrl);
                                using (var ms = new System.IO.MemoryStream(data))
                                {
                                    var img = Image.FromStream(ms);
                                    pic.Invoke((MethodInvoker)(() => pic.Image = img));
                                }
                            }
                        }
                        catch
                        {
                            pic.Invoke((MethodInvoker)(() => pic.Image = SystemIcons.Warning.ToBitmap()));
                        }
                    });
                }
                else
                {
                    // If no image URL provided
                    pic.Image = SystemIcons.Warning.ToBitmap();
                }


                Label lblTitle = new Label
                {
                    Text = row["name"].ToString(),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 60, 90),
                    AutoSize = false,
                    Width = 220,
                    Height = 40,
                    Location = new Point(15, 200)
                };

                Label lblAuthor = new Label
                {
                    Text = $"By {row["author"]}",
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = false,
                    Width = 220,
                    Height = 25,
                    Location = new Point(15, 235)
                };

                Label lblCategory = new Label
                {
                    Text = $"{row["category"]}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.DimGray,
                    AutoSize = false,
                    Width = 220,
                    Height = 20,
                    Location = new Point(15, 260)
                };

                Button btnDetails = new Button
                {
                    Text = "View Details",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    BackColor = Color.SteelBlue,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Width = 110,
                    Height = 30,
                    Location = new Point(15, 285)
                };

                btnDetails.Click += (s, e) =>
                {
                    MessageBox.Show(
                        $"Title: {row["name"]}\n" +
                        $"Author: {row["author"]}\n" +
                        $"ISBN: {row["isbn"]}\n" +
                        $"Category: {row["category"]}\n" +
                        $"Image Path: {row["img_paths"]}",
                        "Book Details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                };

                card.Controls.Add(pic);
                card.Controls.Add(lblTitle);
                card.Controls.Add(lblAuthor);
                card.Controls.Add(lblCategory);
                card.Controls.Add(btnDetails);

                flowPanel.Controls.Add(card);
            }

            if (dt.Rows.Count == 0)
            {
                Label noData = new Label
                {
                    Text = "No books found.",
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowPanel.Controls.Add(noData);
            }
        }

        private DataTable GetBooks(string search = "")
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT id, image, name, author, isbn, category, img_paths
                    FROM book_catalog
                    WHERE (@search = '' 
                        OR name ILIKE @pattern 
                        OR author ILIKE @pattern 
                        OR isbn ILIKE @pattern 
                        OR category ILIKE @pattern)
                    ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@pattern", "%" + search + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm librarianHome = new LibrarianHomeForm("Librarian");
            librarianHome.Show();

        }
    }
}
