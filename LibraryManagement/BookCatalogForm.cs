using LibraryManagement.Domain.Repository;
using LibraryManagementSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookCatalogForm : Form
    {
        private string username;
        private CategoryRepository _categoryRepo;
        private BookRepository _bookRepo;
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string cacheDir = Path.Combine(Application.StartupPath, "image_cache");

        // Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 12;
        private int totalPages = 1;
        private int totalBooks = 0;
        private string currentSearch = "";
        private string currentCategory = "All";
        private string currentSortBy = "title ASC";

        public BookCatalogForm(string username)
        {
            InitializeComponent();
            this.username = username;

            DBConnection db = new DBConnection();
            _categoryRepo = new CategoryRepository(db);
            _bookRepo = new BookRepository(db);

            if (!Directory.Exists(cacheDir))
                Directory.CreateDirectory(cacheDir);

            InitializePaginationPanel();
            InitializeSortComboBox();
            InitializeItemsPerPageComboBox();
        }

        private void InitializeSortComboBox()
        {
            cmbSort.Items.AddRange(new object[] {
                "Title (A-Z)",
                "Title (Z-A)",
                "Author (A-Z)",
                "Author (Z-A)",
                "Category"
            });
            cmbSort.SelectedIndex = 0;
            cmbSort.SelectedIndexChanged += async (s, e) => await OnSortChanged();
        }

        private void InitializeItemsPerPageComboBox()
        {
            cmbItemsPerPage.Items.AddRange(new object[] {
                "12",
                "24",
                "36",
                "48"
            });
            cmbItemsPerPage.SelectedIndex = 0; // Default to 12
            cmbItemsPerPage.SelectedIndexChanged += async (s, e) => await OnItemsPerPageChanged();
        }

        private async Task OnItemsPerPageChanged()
        {
            itemsPerPage = int.Parse(cmbItemsPerPage.SelectedItem.ToString());
            currentPage = 1; // Reset to first page
            await LoadBooks(currentSearch);
        }

        private async Task OnSortChanged()
        {
            switch (cmbSort.SelectedIndex)
            {
                case 0: currentSortBy = "title ASC"; break;
                case 1: currentSortBy = "title DESC"; break;
                case 2: currentSortBy = "author ASC"; break;
                case 3: currentSortBy = "author DESC"; break;
                case 4: currentSortBy = "category ASC"; break;
            }
            currentPage = 1;
            await LoadBooks(currentSearch);
        }

        private void InitializePaginationPanel()
        {
            paginationPanel.Controls.Clear();

            Button btnFirst = new Button
            {
                Text = "⏮ First",
                Width = 80,
                Height = 35,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnFirst.Click += async (s, e) => await GoToPage(1);
            paginationPanel.Controls.Add(btnFirst);

            Button btnPrev = new Button
            {
                Text = "◀ Prev",
                Width = 80,
                Height = 35,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(5, 0, 5, 0)
            };
            btnPrev.Click += async (s, e) => await GoToPage(currentPage - 1);
            paginationPanel.Controls.Add(btnPrev);

            Label lblPageInfo = new Label
            {
                Name = "lblPageInfo",
                Text = "Page 1 of 1",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                AutoSize = true,
                Margin = new Padding(10, 8, 10, 0),
                ForeColor = Color.Black
            };
            paginationPanel.Controls.Add(lblPageInfo);

            Button btnNext = new Button
            {
                Text = "Next ▶",
                Width = 80,
                Height = 35,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(5, 0, 5, 0)
            };
            btnNext.Click += async (s, e) => await GoToPage(currentPage + 1);
            paginationPanel.Controls.Add(btnNext);

            Button btnLast = new Button
            {
                Text = "Last ⏭",
                Width = 80,
                Height = 35,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnLast.Click += async (s, e) => await GoToPage(totalPages);
            paginationPanel.Controls.Add(btnLast);
        }

        private void UpdatePaginationControls()
        {
            var lblPageInfo = paginationPanel.Controls["lblPageInfo"] as Label;
            if (lblPageInfo != null)
            {
                lblPageInfo.Text = $"Page {currentPage} of {totalPages} ({totalBooks} books)";
            }

            foreach (Control ctrl in paginationPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn.Text.Contains("First") || btn.Text.Contains("Prev"))
                    {
                        btn.Enabled = currentPage > 1;
                    }
                    else if (btn.Text.Contains("Next") || btn.Text.Contains("Last"))
                    {
                        btn.Enabled = currentPage < totalPages;
                    }
                }
            }
        }

        private async Task GoToPage(int page)
        {
            if (page < 1 || page > totalPages) return;
            currentPage = page;
            await LoadBooks(currentSearch);
        }

        private async void BookCatalogForm_Load(object sender, EventArgs e)
        {
            await LoadCategoryButtons();
            await LoadBooks();
        }

        private void btn_back_Click(object sender, EventArgs e)
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            currentSearch = txtSearch.Text.Trim();
            await LoadBooks(currentSearch);
        }

        private async Task LoadCategoryButtons()
        {
            await Task.Run(() =>
            {
                List<string> categories = _categoryRepo.GetAllCategories();

                Invoke(new Action(() =>
                {
                    categoryPanel.Controls.Clear();

                    Button btnAll = new Button
                    {
                        Text = "View All",
                        Width = 110,
                        Height = 40,
                        Font = new Font("Segoe UI", 9, FontStyle.Regular),
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Margin = new Padding(3)
                    };
                    btnAll.Click += async (s, e) =>
                    {
                        currentCategory = "All";
                        currentPage = 1;
                        await LoadBooks();
                    };
                    categoryPanel.Controls.Add(btnAll);

                    foreach (var cat in categories)
                    {
                        Button btn = new Button
                        {
                            Text = cat,
                            Width = 110,
                            Height = 40,
                            Font = new Font("Segoe UI", 9, FontStyle.Regular),
                            BackColor = Color.CadetBlue,
                            ForeColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            Margin = new Padding(3)
                        };
                        btn.Click += async (s, e) =>
                        {
                            currentCategory = cat;
                            currentPage = 1;
                            await LoadBooksByCategory(cat);
                        };
                        categoryPanel.Controls.Add(btn);
                    }
                }));
            });
        }

        private async Task LoadBooksByCategory(string category)
        {
            currentCategory = category;
            currentSearch = "";
            currentPage = 1;
            await LoadBooks("", category);
        }

        private async Task LoadBooks(string search = "", string category = "All")
        {
            if (category != "All")
                currentCategory = category;

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

            // Use repository to get count
            totalBooks = _bookRepo.GetBookCount(search, currentCategory);
            totalPages = (int)Math.Ceiling((double)totalBooks / itemsPerPage);

            if (totalPages == 0) totalPages = 1;

            // Use repository to get paginated data
            DataTable dt = _bookRepo.GetBooksPaginated(
                search,
                currentCategory,
                currentPage,
                itemsPerPage,
                currentSortBy);

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
                UpdatePaginationControls();
                return;
            }

            await PopulateBookCards(dt);
            UpdatePaginationControls();
        }

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

                Panel card = CreateBookCard(row, img);
                flowPanel.Controls.Add(card);
            }
        }

        private Panel CreateBookCard(DataRow row, Image img)
        {
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
                BorderStyle = BorderStyle.None,
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

            return card;
        }

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
    }
}