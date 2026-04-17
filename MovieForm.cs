using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Net.Mime;
using System.Drawing;







namespace Tyrtyvshin
{
    public partial class MovieForm : Form
    {
        string connStr = "server=localhost;port=3310;database=movie;uid=root;password=Turuu76#;";
        private string _posterPath = "";
        private bool _searchPlaceholderActive = false;
        private string? _pendingWebUrl;
        private bool _supportsTrailerId = true;
        // string connStr = "server=localhost;port=3306;database=gf;uid=root;pwd=;";





        public MovieForm()

        {
            InitializeComponent();
            InitializeSearchUi();

        }

        private void InitializeSearchUi()
        {
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

                   

                    if (dgvMovies.Columns.Contains("trailerId"))
                        dgvMovies.Columns["trailerId"].Visible = false;

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
            
        }

       
        private async System.Threading.Tasks.Task InitializeWebViewAsync()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
                webView21.CoreWebView2.Settings.AreDevToolsEnabled = true;
                webView21.CoreWebView2.Settings.IsZoomControlEnabled = true;

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
            string nextID = "M100";
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
                        int currentNumber = int.Parse(lastID.Substring(1));
                        nextID = "M" + (currentNumber + 1).ToString();
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
                dgvMovies.EnableHeadersVisualStyles = false;
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

                string query = Uri.EscapeDataString($"{movieTitle} trailer");
                string? trailerId = null;

                if (_supportsTrailerId && dgvMovies.Columns.Contains("trailerId"))
                    trailerId = row.Cells["trailerId"].Value?.ToString();

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

        private void webView21_Click(object sender, EventArgs e)
        {
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }
    }
}









