using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tyrtyvshin
{
    public partial class MovieForm : Form
    {
        string connStr = "server=localhost;port=3310;database=movie;uid=root;password=Turuu76#;";
        private string _posterPath = ""; 

        public MovieForm()

        {
            InitializeComponent();
        }


        private void MovieForm_Load(object sender, EventArgs e)

        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT movieID, title, director, year1 FROM movie";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    dgvMovies.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа гарлаа: " + ex.Message);
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

                    LoadMovieData();
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

                    LoadMovieData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Алдаа: " + ex.Message); }
        }

        private void LoadMovieData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT movieID, title, director, year1 FROM movie";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMovies.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хүснэгтийг шинэчлэхэд алдаа гарлаа: " + ex.Message);
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

                        LoadMovieData();
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
            LoadMovieData();
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

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string foundPath = FindPoster(folderPath, movieTitle);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                if (foundPath != null)
                {
                    pctrbox1.Image = Image.FromFile(foundPath);
                    pctrbox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pctrbox1.Image = null;
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
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    using (OpenFileDialog ofj = new OpenFileDialog())
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
            }
        }
    }
}









