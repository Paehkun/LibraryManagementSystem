using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public partial class BookCatalogForm : Form
    {
        private string username;
        private static readonly HttpClient httpClient = new HttpClient();
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
            await LoadCategoryButtons(); // Load buttons for all categories
            await LoadBooks(); // Load all books initially
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianHomeForm home = new LibrarianHomeForm(username);
            home.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadBooks(txtSearch.Text.Trim());
        }

        // Load dynamic category buttons
        private async Task LoadCategoryButtons()
        {
            await Task.Run(() =>
            {
                List<string> categories = new List<string>();

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT DISTINCT category FROM books ORDER BY category ASC", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cat = reader["category"].ToString();
                            if (!string.IsNullOrWhiteSpace(cat))
                                categories.Add(cat);
                        }
                    }
                }

                Invoke(new Action(() =>
                {
                    categoryPanel.Controls.Clear();

                    // "View All" button
                    Button btnAll = new Button
                    {
                        Text = "View All",
                        Width = 150,
                        Height = 40,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Margin = new Padding(5)
                    };
                    btnAll.Click += async (s, e) => await LoadBooks();
                    categoryPanel.Controls.Add(btnAll);

                    // Buttons for each category
                    foreach (var cat in categories)
                    {
                        Button btn = new Button
                        {
                            Text = cat,
                            Width = 150,
                            Height = 40,
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            BackColor = Color.CadetBlue,
                            ForeColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            Margin = new Padding(5)
                        };
                        btn.Click += async (s, e) => await LoadBooksByCategory(cat);
                        categoryPanel.Controls.Add(btn);
                    }
                }));
            });
        }

        private async Task LoadBooksByCategory(string category)
        {
            flowPanel.Controls.Clear();

            Label loadingLabel = new Label
            {
                Text = $"Loading books in '{category}'...",
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                Margin = new Padding(20)
            };
            flowPanel.Controls.Add(loadingLabel);
            flowPanel.Refresh();

            DataTable dt = GetBooks("", category);
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

            await PopulateBookCards(dt);
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

            DataTable dt = GetBooks(search); // no category filter here
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

            await PopulateBookCards(dt);
        }

        // Generate book cards
        private async Task PopulateBookCards(DataTable dt)
        {
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

                btnDetails.Click += (s, e) => ShowBookDetails(row, img);

                card.Controls.Add(pic);
                card.Controls.Add(lblTitle);
                card.Controls.Add(lblAuthor);
                card.Controls.Add(lblCategory);
                card.Controls.Add(btnDetails);

                flowPanel.Controls.Add(card);
            }
        }

        // Show book detail dialog
        private void ShowBookDetails(DataRow row, Image img)
        {
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
            btnClose.Click += (s, e) => detailsForm.Close();

            detailsForm.Controls.Add(pic);
            detailsForm.Controls.Add(lblTitle);
            detailsForm.Controls.Add(lblAuthor);
            detailsForm.Controls.Add(lblIsbn);
            detailsForm.Controls.Add(lblCategory);
            detailsForm.Controls.Add(btnClose);

            detailsForm.ShowDialog();
        }

        private async Task<Image> GetCachedImageAsync(string imgUrl)
        {
            if (string.IsNullOrEmpty(imgUrl))
                return SystemIcons.Warning.ToBitmap();

            try
            {
                string hash = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(imgUrl)).Replace("=", "");
                string filePath = Path.Combine(cacheDir, hash + ".jpg");

                if (File.Exists(filePath))
                {
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        return Image.FromStream(fs);
                }

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

        private DataTable GetBooks(string search = "", string category = "All")
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT id, image, title, author, isbn, category
                    FROM books
                    WHERE 
                        (@search = '' 
                        OR title ILIKE @pattern 
                        OR author ILIKE @pattern 
                        OR isbn ILIKE @pattern 
                        OR category ILIKE @pattern)
                        AND (@category = 'All' OR category = @category)
                    ORDER BY id ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", search);
                    cmd.Parameters.AddWithValue("@pattern", "%" + search + "%");
                    cmd.Parameters.AddWithValue("@category", category);

                    using (var reader = cmd.ExecuteReader())
                        dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
