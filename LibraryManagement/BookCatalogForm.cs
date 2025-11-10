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
                    // Create a custom Form for the details
                    Form detailsForm = new Form
                    {
                        Text = "📘 Book Details",
                        Size = new Size(550, 650),
                        StartPosition = FormStartPosition.CenterParent,
                        BackColor = Color.White
                    };

                    PictureBox pic = new PictureBox
                    {
                        Image = img,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 300,
                        Height = 350,
                        Location = new Point((detailsForm.ClientSize.Width - 300) / 2, 20),
                        Anchor = AnchorStyles.Top
                    };

                    Label lblTitle = new Label
                    {
                        Text = row["title"].ToString(),
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        ForeColor = Color.FromArgb(30, 60, 90),
                        AutoSize = false,
                        Width = detailsForm.ClientSize.Width - 40,
                        Location = new Point(20, 370),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label lblAuthor = new Label
                    {
                        Text = $"By: {row["author"]}",
                        Font = new Font("Segoe UI", 11, FontStyle.Italic),
                        ForeColor = Color.DimGray,
                        AutoSize = false,
                        Width = detailsForm.ClientSize.Width - 40,
                        Location = new Point(20, 410),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label lblIsbn = new Label
                    {
                        Text = $"ISBN: {row["isbn"]}",
                        Font = new Font("Segoe UI", 11, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = false,
                        Width = detailsForm.ClientSize.Width - 40,
                        Location = new Point(20, 450),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label lblCategory = new Label
                    {
                        Text = $"Category: {row["category"]}",
                        Font = new Font("Segoe UI", 11, FontStyle.Regular),
                        ForeColor = Color.Black,
                        AutoSize = false,
                        Width = detailsForm.ClientSize.Width - 40,
                        Location = new Point(20, 490),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Button btnClose = new Button
                    {
                        Text = "Close",
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        FlatStyle = FlatStyle.Flat,
                        Width = 100,
                        Height = 35,
                        Location = new Point((detailsForm.ClientSize.Width - 100) / 2, 520)
                    };
                    btnClose.Click += (s2, e2) => detailsForm.Close();

                    detailsForm.Controls.Add(pic);
                    detailsForm.Controls.Add(lblTitle);
                    detailsForm.Controls.Add(lblAuthor);
                    detailsForm.Controls.Add(lblIsbn);
                    detailsForm.Controls.Add(lblCategory);
                   // detailsForm.Controls.Add(linkImage);
                    detailsForm.Controls.Add(btnClose);

                    detailsForm.ShowDialog();
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
