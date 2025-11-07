using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LibraryManagementSystem
{
    public partial class BookCatalogForm : Form
    {
        private string username;
        private static readonly HttpClient httpClient = new HttpClient(); // Reuse for all image requests
        private readonly string cacheDir = Path.Combine(Application.StartupPath, "image_cache");

        public BookCatalogForm(string username)
        {
            InitializeComponent();
            this.username = username;

            if (!Directory.Exists(cacheDir))
                Directory.CreateDirectory(cacheDir);
        }

        private async void BookCatalogForm_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

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
            btnBack.Location = new Point(txtSearch.Left - btnBack.Width - 10, txtSearch.Top);
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);

            await LoadBooks();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm home = new LibrarianHomeForm(username);
            home.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadBooks(txtSearch.Text.Trim());
        }

        private async Task LoadBooks(string search = "")
        {
            flowPanel.Controls.Clear();

            Label loadingLabel = new Label
            {
                Text = "Loading books...",
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Margin = new Padding(20)
            };
            flowPanel.Controls.Add(loadingLabel);
            flowPanel.Refresh();

            DataTable dt = GetBooks(search);
            flowPanel.Controls.Clear();

            if (dt.Rows.Count == 0)
            {
                flowPanel.Controls.Add(new Label
                {
                    Text = "No books found.",
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                });
                return;
            }

            // Download or load all images in parallel
            var imageTasks = new List<Task<Image>>();
            foreach (DataRow row in dt.Rows)
            {
                string imgUrl = row["image"].ToString();
                imageTasks.Add(GetCachedImageAsync(imgUrl));
            }

            var images = await Task.WhenAll(imageTasks);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                Image img = images[i];

                Panel card = new Panel
                {
                    Width = 250,
                    Height = 330,
                    BackColor = Color.White,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox pic = new PictureBox
                {
                    Width = 220,
                    Height = 180,
                    Location = new Point(15, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = img
                };

                Label lblTitle = new Label
                {
                    Text = row["title"].ToString(),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 60, 90),
                    AutoSize = false,
                    Width = 220,
                    Height = 30,
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
                    Text = row["category"].ToString(),
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
                        $"Title: {row["title"]}\n" +
                        $"Author: {row["author"]}\n" +
                        $"ISBN: {row["isbn"]}\n" +
                        $"Category: {row["category"]}\n",
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
        }

        private async Task<Image> GetCachedImageAsync(string imgUrl)
        {
            if (string.IsNullOrEmpty(imgUrl))
                return SystemIcons.Warning.ToBitmap();

            try
            {
                // Create hashed local filename
                string hash = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(imgUrl)).Replace("=", "");
                string filePath = Path.Combine(cacheDir, hash + ".jpg");

                // Return cached file if exists
                if (File.Exists(filePath))
                {
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        return Image.FromStream(fs);
                }

                // Otherwise download and cache
                byte[] data = await httpClient.GetByteArrayAsync(imgUrl);
                await File.WriteAllBytesAsync(filePath, data);

                using (var ms = new MemoryStream(data))
                    return Image.FromStream(ms);
            }
            catch
            {
                return SystemIcons.Warning.ToBitmap();
            }
        }

        private DataTable GetBooks(string search = "")
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT id, image, title, author, isbn, category
                    FROM books
                    WHERE (@search = '' 
                        OR title ILIKE @pattern 
                        OR author ILIKE @pattern 
                        OR isbn ILIKE @pattern 
                        OR category ILIKE @pattern)
                    ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@pattern", "%" + search + "%");

                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);
                }
            }
            return dt;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm home = new LibrarianHomeForm(username);
            home.Show();
        }
    }
}
