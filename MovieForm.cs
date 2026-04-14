using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;





namespace Tyrtyvshin
{
    public partial class MovieForm : Form
    {
        //string connStr = "server=localhost;port=3310;database=movie;uid=root;password=Turuu76#;";
        private string _posterPath = "";
        private bool _searchPlaceholderActive = false;
        private string? _pendingWebUrl;
        private bool _supportsTrailerId = true;
        string connStr = "server=localhost;port=3306;database=gf;uid=root;pwd=;";





        public MovieForm()

        {
            InitializeComponent();
            InitializeSearchUi();
            ApplyModernUi();
        }

        private static class UiTheme
        {
            public static readonly Color Background = Color.FromArgb(11, 16, 32);  // #0B1020
            public static readonly Color Surface = Color.FromArgb(17, 26, 46);     // #111A2E
            public static readonly Color Surface2 = Color.FromArgb(15, 23, 48);    // #0F1730
            public static readonly Color Accent = Color.FromArgb(124, 58, 237);    // #7C3AED
            public static readonly Color Text = Color.FromArgb(229, 231, 235);     // #E5E7EB
            public static readonly Color Muted = Color.FromArgb(156, 163, 175);    // #9CA3AF
            public static readonly Color Border = Color.FromArgb(31, 41, 55);      // #1F2937
        }

        private void ApplyModernUi()
        {
            SuspendLayout();

            // Global form styling
            DoubleBuffered = true;
            BackColor = UiTheme.Background;
            ForeColor = UiTheme.Text;
            Font = new Font("Segoe UI", 10.5f, FontStyle.Regular);

            // Re-layout into a modern 2-column page layout (left details, right grid+trailer).
            ApplyModernLayout();

            // Apply visual styles after layout is stabilized.
            ApplyModernStyles();

            ResumeLayout(true);
        }

        private void ApplyModernLayout()
        {
            // Build a root table layout and re-parent existing controls into it.
            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Background,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(16),
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 520));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var left = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Surface,
                Padding = new Padding(16),
            };

            var right = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Background,
            };

            // Right side: top section (search + grid) and bottom section (trailer).
            var rightLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Background,
                ColumnCount = 1,
                RowCount = 2,
            };
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55));

            var gridCard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Surface,
                Padding = new Padding(16),
            };

            var trailerCard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Surface,
                Padding = new Padding(16),
            };

            // Search bar container
            var searchBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = UiTheme.Surface,
            };

            label5.Text = "Search";
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Padding = new Padding(0, 12, 10, 0);

            txtsearch.Dock = DockStyle.Fill;
            txtsearch.Margin = new Padding(0);

            searchBar.Controls.Clear();
            searchBar.Controls.Add(txtsearch);
            searchBar.Controls.Add(label5);

            // Grid
            dgvMovies.Dock = DockStyle.Fill;
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            gridCard.Controls.Clear();
            gridCard.Controls.Add(dgvMovies);
            gridCard.Controls.Add(searchBar);

            // Trailer (keep existing groupBox/webview/button inside, but dock them)
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Padding = new Padding(12);
            groupBox1.Text = "Trailer";

            webView21.Dock = DockStyle.Fill;
            button1.Dock = DockStyle.Bottom;
            button1.Height = 40;

            trailerCard.Controls.Clear();
            trailerCard.Controls.Add(groupBox1);

            rightLayout.Controls.Clear();
            rightLayout.Controls.Add(gridCard, 0, 0);
            rightLayout.Controls.Add(trailerCard, 0, 1);
            right.Controls.Clear();
            right.Controls.Add(rightLayout);

            // Left side: poster (top) + details form (bottom)
            var leftLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Surface,
                ColumnCount = 1,
                RowCount = 2,
            };
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 360));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var posterCard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Surface2,
                Padding = new Padding(12),
            };

            pctrbox1.Dock = DockStyle.Fill;
            pctrbox1.Margin = new Padding(0);

            posterCard.Controls.Clear();
            posterCard.Controls.Add(pctrbox1);

            var detailsCard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = UiTheme.Surface,
                Padding = new Padding(4),
            };

            // Form grid for labels + inputs
            var formGrid = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                BackColor = UiTheme.Surface,
                ColumnCount = 2,
                RowCount = 4,
                AutoSize = true,
            };
            formGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            formGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            for (int i = 0; i < 4; i++)
                formGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));

            void AddField(int row, Label label, Control input)
            {
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Padding = new Padding(0, 0, 8, 0);

                input.Dock = DockStyle.Fill;
                input.Margin = new Padding(0);

                formGrid.Controls.Add(label, 0, row);
                formGrid.Controls.Add(input, 1, row);
            }

            label1.Text = "Movie ID";
            label2.Text = "Title";
            label3.Text = "Director";
            label4.Text = "Year";

            AddField(0, label1, movieID);
            AddField(1, label2, title);
            AddField(2, label3, director);
            AddField(3, label4, year1);

            var actionsRow = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 48,
                BackColor = UiTheme.Surface,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(0),
            };
            actionsRow.Controls.Add(btnSave);
            actionsRow.Controls.Add(btnupdate);
            actionsRow.Controls.Add(btndelete);
            actionsRow.Controls.Add(Clear);

            detailsCard.Controls.Clear();
            detailsCard.Controls.Add(actionsRow);
            detailsCard.Controls.Add(formGrid);

            leftLayout.Controls.Add(posterCard, 0, 0);
            leftLayout.Controls.Add(detailsCard, 0, 1);

            left.Controls.Clear();
            left.Controls.Add(leftLayout);

            root.Controls.Add(left, 0, 0);
            root.Controls.Add(right, 1, 0);

            // Replace the existing form controls with the new root layout panel
            Controls.Clear();
            Controls.Add(root);
        }

        private void ApplyModernStyles()
        {
            // Labels
            void StyleLabel(Label lbl)
            {
                lbl.ForeColor = UiTheme.Muted;
                lbl.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            }

            StyleLabel(label1);
            StyleLabel(label2);
            StyleLabel(label3);
            StyleLabel(label4);
            StyleLabel(label5);

            // TextBoxes
            void StyleInput(TextBox tb, bool readOnly = false)
            {
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.BackColor = UiTheme.Surface2;
                tb.ForeColor = UiTheme.Text;
                tb.Font = new Font("Segoe UI", 10.5f, FontStyle.Regular);
                tb.ReadOnly = readOnly;
            }

            StyleInput(movieID, readOnly: true);
            StyleInput(title);
            StyleInput(director);
            StyleInput(year1);
            StyleInput(txtsearch);

            // Buttons
            void StyleBtn(Button b, string text, Color back)
            {
                b.Text = text;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = back;
                b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                b.Height = 40;
                b.Width = 118;
                b.Margin = new Padding(0, 0, 10, 0);
                b.Cursor = Cursors.Hand;
            }

            StyleBtn(btnSave, "SAVE", UiTheme.Accent);
            StyleBtn(btnupdate, "UPDATE", Color.FromArgb(37, 99, 235));   // blue
            StyleBtn(btndelete, "DELETE", Color.FromArgb(220, 38, 38));   // red
            StyleBtn(Clear, "CLEAR", UiTheme.Surface2);

            // Trailer open button
            StyleBtn(button1, "OPEN IN BROWSER", UiTheme.Surface2);
            button1.Width = 220;
            button1.Margin = new Padding(0);

            // DataGridView
            dgvMovies.BorderStyle = BorderStyle.None;
            dgvMovies.BackgroundColor = UiTheme.Surface;
            dgvMovies.GridColor = UiTheme.Border;
            dgvMovies.EnableHeadersVisualStyles = false;
            dgvMovies.RowHeadersVisible = true;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovies.DefaultCellStyle.BackColor = UiTheme.Surface;
            dgvMovies.DefaultCellStyle.ForeColor = UiTheme.Text;
            dgvMovies.DefaultCellStyle.SelectionBackColor = UiTheme.Accent;
            dgvMovies.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMovies.DefaultCellStyle.Font = new Font("Segoe UI", 10f);
            dgvMovies.AlternatingRowsDefaultCellStyle.BackColor = UiTheme.Surface2;
            dgvMovies.ColumnHeadersDefaultCellStyle.BackColor = UiTheme.Surface2;
            dgvMovies.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMovies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            // GroupBox / WebView2
            groupBox1.ForeColor = UiTheme.Text;
            groupBox1.BackColor = UiTheme.Surface;
            webView21.DefaultBackgroundColor = UiTheme.Background;
        }

        private void InitializeSearchUi()
        {
            // Keep Designer clean; manage placeholder behavior here.
            txtsearch.Text = "";
            txtsearch.ForeColor = SystemColors.WindowText;
            _searchPlaceholderActive = false;

            txtsearch.Enter += (s, e) =>
            {
                if (_searchPlaceholderActive)
                {
                    _searchPlaceholderActive = false;
                    txtsearch.Text = "";
                    txtsearch.ForeColor = SystemColors.WindowText;
                }
            };

            txtsearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtsearch.Text))
                {
                    _searchPlaceholderActive = true;
                    txtsearch.Text = "Search title...";
                    txtsearch.ForeColor = SystemColors.GrayText;
                }
            };

            // Force initial placeholder if empty on startup
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                _searchPlaceholderActive = true;
                txtsearch.Text = "Search title...";
                txtsearch.ForeColor = SystemColors.GrayText;
            }
        }

        private async void MovieForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMovies(null);
                LoadMovieData();
                await InitializeWebViewAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа гарлаа: " + ex.Message);
            }

        }

        private void LoadMovies(string? titleFilter)
        {
            using MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            bool hasFilter = !string.IsNullOrWhiteSpace(titleFilter);
            DataTable dt = new DataTable();

            // Prefer trailerId if the DB has it; fall back gracefully if not.
            if (_supportsTrailerId)
            {
                try
                {
                    string queryWithTrailer = hasFilter
                        ? "SELECT movieID, title, director, year1, trailerId FROM movie WHERE title LIKE @s"
                        : "SELECT movieID, title, director, year1, trailerId FROM movie";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(queryWithTrailer, conn);
                    if (hasFilter)
                        adapter.SelectCommand.Parameters.AddWithValue("@s", "%" + titleFilter + "%");

                    adapter.Fill(dt);
                    dgvMovies.DataSource = dt;

                    ConfigureMovieGridColumns();

                    if (dgvMovies.Columns.Contains("trailerId"))
                        dgvMovies.Columns["trailerId"].Visible = false; // keep UI clean

                    return;
                }
                catch
                {
                    _supportsTrailerId = false;
                    dt = new DataTable();
                }
            }

            string query = hasFilter
                ? "SELECT movieID, title, director, year1 FROM movie WHERE title LIKE @s"
                : "SELECT movieID, title, director, year1 FROM movie";

            MySqlDataAdapter fallbackAdapter = new MySqlDataAdapter(query, conn);
            if (hasFilter)
                fallbackAdapter.SelectCommand.Parameters.AddWithValue("@s", "%" + titleFilter + "%");

            fallbackAdapter.Fill(dt);
            dgvMovies.DataSource = dt;
            ConfigureMovieGridColumns();
        }

        private void ConfigureMovieGridColumns()
        {
            try
            {
                dgvMovies.AutoGenerateColumns = true;
                dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvMovies.AllowUserToAddRows = false;
                dgvMovies.AllowUserToResizeRows = false;
                dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                void Ensure(string name, string header, int displayIndex, int minWidth)
                {
                    if (!dgvMovies.Columns.Contains(name)) return;
                    var col = dgvMovies.Columns[name];
                    col.Visible = true;
                    col.HeaderText = header;
                    col.DisplayIndex = displayIndex;
                    col.MinimumWidth = minWidth;
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                Ensure("movieID", "Movie ID", 0, 80);
                Ensure("title", "Title", 1, 180);
                Ensure("director", "Director", 2, 160);
                Ensure("year1", "Year", 3, 70);

                // Hide any helper columns if present
                if (dgvMovies.Columns.Contains("trailerId"))
                    dgvMovies.Columns["trailerId"].Visible = false;
            }
            catch
            {
                // No-op: avoid breaking UI if grid is not ready yet
            }
        }

        private async System.Threading.Tasks.Task InitializeWebViewAsync()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
                webView21.CoreWebView2.Settings.AreDevToolsEnabled = true;
                webView21.CoreWebView2.Settings.IsZoomControlEnabled = true;

                // If something queued before initialization, navigate there; otherwise show a safe default page.
                string url = _pendingWebUrl ?? "https://www.youtube.com/";
                _pendingWebUrl = null;
                webView21.Source = new Uri(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("WebView2 асахгүй байна: " + ex.Message);
            }
        }


        private string GetNextID()
        {
            string nextID = "M100"; // Хэрэв бааз бүр хоосон бол эхний утга
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT MAX(movieID) FROM movie";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string lastID = result.ToString() ?? "";
                    if (lastID.Length > 1)
                    {
                        int currentNumber = int.Parse(lastID.Substring(1)); // 105
                        nextID = "M" + (currentNumber + 1).ToString(); // "M106"
                    }
                }
            }
            return nextID;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string nextID = GetNextID();

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO movie (movieID, title, director, year1) VALUES (@id, @t, @d, @y)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", nextID);
                    cmd.Parameters.AddWithValue("@t", title.Text);
                    cmd.Parameters.AddWithValue("@d", director.Text);
                    cmd.Parameters.AddWithValue("@y", year1.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Амжилттай нэмэгдлээ! Шинэ ID: " + nextID);

                    LoadMovies(null);
                    Clear_Click(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show("Алдаа: " + ex.Message); }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "UPDATE movie SET title=@t, director=@d, year1=@y WHERE movieID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", movieID.Text);
                    cmd.Parameters.AddWithValue("@t", title.Text);
                    cmd.Parameters.AddWithValue("@d", director.Text);
                    cmd.Parameters.AddWithValue("@y", year1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Мэдээлэл засагдлаа!");

                    LoadMovies(null);
                }
            }
            catch (Exception ex) { MessageBox.Show("Алдаа: " + ex.Message); }
        }

        private void LoadMovieData()
        {
            {
                // Keep for backward compatibility (styles are now applied in ApplyModernUi()).
                dgvMovies.EnableHeadersVisualStyles = false;
            }



        }

        private void StyleLabelsRecursive(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = Color.FromArgb(199, 170, 255);
                    lbl.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else
                {
                    StyleLabelsRecursive(c);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string query = "DELETE FROM movie WHERE movieID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlParameter mySqlParameter = cmd.Parameters.AddWithValue("@id", movieID.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Устгагдлаа!");

                        LoadMovies(null);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Алдаа: " + ex.Message); }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            movieID.Clear();
            title.Clear();
            director.Clear();
            year1.Clear();
            LoadMovies(null);
        }

        private void StyleButton(Button btn, string text, Color color)
        {
            btn.Text = text;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 36;
        }

        private void StyleTextBox(TextBox tb)
        {
            tb.BackColor = Color.FromArgb(30, 25, 50);
            tb.ForeColor = Color.FromArgb(220, 200, 255);
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("Segoe UI", 10f);
        }



        private void DgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                
            {
                DataGridViewRow row = dgvMovies.Rows[e.RowIndex];

                movieID.Text = row.Cells["movieID"].Value?.ToString();
                title.Text = row.Cells["title"].Value?.ToString();
                director.Text = row.Cells["director"].Value?.ToString();
                year1.Text = row.Cells["year1"].Value?.ToString();

                string movieTitle = row.Cells["title"].Value?.ToString() ?? "";
                string folderPath = Application.StartupPath;

                // 🖼️ Зураг
                string? foundPath = FindPoster(folderPath, movieTitle);
                if (foundPath != null)
                {
                    pctrbox1.Image = Image.FromFile(foundPath);
                    pctrbox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pctrbox1.Image = null;
                }

                // WebView2: show YouTube search results for selected movie (trailer).
                string query = Uri.EscapeDataString($"{movieTitle} trailer");
                string? trailerId = null;

                if (_supportsTrailerId && dgvMovies.Columns.Contains("trailerId"))
                    trailerId = row.Cells["trailerId"].Value?.ToString();

                // If we have a trailerId, show a big embedded player for that exact video.
                // Otherwise, fall back to YouTube search results (more compatible).
                string url = !string.IsNullOrWhiteSpace(trailerId)
                    ? $"https://www.youtube-nocookie.com/embed/{trailerId}?autoplay=1&rel=0&modestbranding=1"
                    : $"https://www.youtube.com/results?search_query={query}";

                if (webView21.CoreWebView2 != null)
                {
                    webView21.Source = new Uri(url);
                }
                else
                {
                    _pendingWebUrl = url;
                }
            }
        }









        private string? FindPoster(string folderPath, string movieTitle)
        {
            string[] extensions = { ".jpg", ".png", ".jpeg", ".jfif" };

            string[] allFiles = Directory.GetFiles(folderPath, "*.*");

            foreach (string file in allFiles)
            {
                string ext = Path.GetExtension(file).ToLower();

                if (!new[] { ".jpg", ".png", ".jpeg", ".jfif" }.Contains(ext))
                    continue;

                string fileName = Path.GetFileNameWithoutExtension(file);

                string normalizedFile = fileName.Replace("_", " ").Replace("-", " ").ToLower().Trim();
                string normalizedTitle = movieTitle.Replace("_", " ").Replace("-", " ").ToLower().Trim();

                if (normalizedFile == normalizedTitle)
                {
                    return file;
                }
            }

            return null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Постер сонгох";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _posterPath = ofd.FileName;
                    pctrbox1.Image = Image.FromFile(ofd.FileName);
                    pctrbox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }


        private string? FindTrailer(string folderPath, string movieTitle)
        {
            if (!Directory.Exists(folderPath)) return null;
            string[] allFiles = Directory.GetFiles(folderPath, "*.*");

            foreach (string file in allFiles)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (!new[] { ".mp4", ".wav", ".avi", ".mkv" }.Contains(ext)) continue; // ← жижиг үсэг

                string fileName = Path.GetFileNameWithoutExtension(file);
                string normalizedFile = fileName.Replace("_", " ").Replace("-", " ").ToLower().Trim();
                string normalizedTitle = movieTitle.Replace("_", " ").Replace("-", " ").ToLower().Trim();

                if (normalizedFile == normalizedTitle)
                    return file;
            }
            return null;
        }

        private void movieID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnwatchtrailer_Click(object sender, EventArgs e)
        {
            {
                string movieTitle = title.Text;
                string folderPath = Application.StartupPath;

                string? trailerPath = FindTrailer(folderPath, movieTitle);
                if (trailerPath != null)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = trailerPath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("Трейлер олдсонгүй: " + movieTitle);
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (_searchPlaceholderActive) return;

            try
            {
                string term = txtsearch.Text.Trim();
                if (string.IsNullOrEmpty(term))
                    LoadMovies(null);
                else
                    LoadMovies(term);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search алдаа: " + ex.Message);
            }
        }

        private void webView_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {
            // No-op: navigation is handled on load + row selection.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var uri = webView21.Source;
                if (uri == null) return;
                Process.Start(new ProcessStartInfo { FileName = uri.ToString(), UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Browser нээхэд алдаа: " + ex.Message);
            }
        }
    }
}









