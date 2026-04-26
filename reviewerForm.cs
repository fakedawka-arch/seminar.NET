using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TyrtyvshinGl
{
    public partial class reviewerForm : Form
    {
        string connStr = "server=localhost;port=3306;database=gf;uid=root;pwd=;";
        private DataTable _fullData = new DataTable();

        public reviewerForm()
        {
            InitializeComponent();
            this.Load += reviewerForm_Load;
        }
        MySqlConnection GetConnection() => new MySqlConnection(connStr);


        private void LoadData()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    V.reviewerID                    AS reviewerID,
                    V.rName                         AS rName,
                    COUNT(R.movieID)                AS uzsen_too,
                    ROUND(AVG(R.stars), 1)          AS dundaj_od,
                    MAX(R.stars)                    AS max_od,
                    MIN(R.stars)                    AS min_od,
                    MAX(R.ratingDate)               AS suuliin_ogno
                FROM reviewer AS V
                LEFT JOIN rating AS R ON V.reviewerID = R.reviewerID
                GROUP BY V.reviewerID, V.rName
                ORDER BY uzsen_too DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    _fullData = new DataTable();
                    da.Fill(_fullData);

                    _fullData.Columns["reviewerID"].ColumnName = "Үзэгч ID";
                    _fullData.Columns["rName"].ColumnName = "Нэр";
                    _fullData.Columns["uzsen_too"].ColumnName = "Үзсэн тоо";
                    _fullData.Columns["dundaj_od"].ColumnName = "Дундаж ⭐";
                    _fullData.Columns["max_od"].ColumnName = "Хамгийн өндөр";
                    _fullData.Columns["min_od"].ColumnName = "Хамгийн бага";
                    _fullData.Columns["suuliin_ogno"].ColumnName = "Сүүлд үзсэн";

                    dgvReviewer.DataSource = _fullData.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStats()
        {
            int total = _fullData.Rows.Count;
            string best = _fullData.Rows.Count > 0
                              ? _fullData.Rows[0]["Нэр"].ToString()
                              : "-";
            lblStats.Text = $"Нийт үзэгч: {total}  |  " +
                              $"Хамгийн идэвхтэй: {best}";
        }


        private void reviewerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnADd_Click(object sender, EventArgs e)
        {
            {
                string id = txtID.Text.Trim();
                string name = txtName.Text.Trim();

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("ID болон Нэрийг оруулна уу!", "Анхааруулга",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        string sql = "INSERT INTO reviewer (reviewerID, rName) VALUES (@id, @name)";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Амжилттай нэмэгдлээ! ✅");
                    txtID.Clear();
                    txtName.Clear();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            {
                if (dgvReviewer.CurrentRow == null) return;

                string id = dgvReviewer.CurrentRow.Cells["Үзэгч ID"].Value?.ToString() ?? "";
                string newName = txtName.Text.Trim();

                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Шинэ нэрийг оруулна уу!");
                    return;
                }

                try
                {
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        string sql = "UPDATE reviewer SET rName = @name WHERE reviewerID = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@name", newName);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Амжилттай засагдлаа! ✅");
                    txtName.Clear();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (dgvReviewer.CurrentRow == null) return;

                string id = dgvReviewer.CurrentRow.Cells["Үзэгч ID"].Value?.ToString() ?? "";
                string name = dgvReviewer.CurrentRow.Cells["Нэр"].Value?.ToString() ?? "";

                var confirm = MessageBox.Show(
                    $"'{name}' үзэгчийг устгах уу?",
                    "Баталгаажуулах",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                try
                {
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        // Эхлээд rating-ийг устгана
                        string sql1 = "DELETE FROM rating   WHERE reviewerID = @id";
                        string sql2 = "DELETE FROM reviewer WHERE reviewerID = @id";

                        MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.ExecuteNonQuery();

                        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Амжилттай устгагдлаа! ✅");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvReviewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReviewer.CurrentRow == null) return;
            txtID.Text = dgvReviewer.CurrentRow.Cells["Үзэгч ID"].Value?.ToString() ?? "";
            txtName.Text = dgvReviewer.CurrentRow.Cells["Нэр"].Value?.ToString() ?? "";
        }
    }
}
