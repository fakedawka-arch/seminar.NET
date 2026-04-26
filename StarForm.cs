using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Tyrtyvshin
{
    public partial class StarForm : Form
    {
        // string connStr = "server=localhost;port=3310;database=movie;uid=root;pwd=Turuu76#;";
        string connStr = "server=localhost;port=3306;database=gf;uid=root;pwd=;";
        private bool _searchPlaceholderActive = false; // ← ЭНЭНИЙГ НЭМ

        public StarForm()
        {
            InitializeComponent();
        }

        MySqlConnection GetConnection()

        {
            ApplyFilter();
            return new MySqlConnection(connStr);
        }
        private DataTable _fullData = new DataTable();


        private void dgvstar1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvstar1.Rows[e.RowIndex];

                foreach (DataGridViewRow r in dgvstar1.Rows)
                    r.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

                row.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

                string movie = row.Cells["Нэр"].Value?.ToString() ?? "";
                string reviewer = row.Cells["Үзэгч"].Value?.ToString() ?? "";
                string stars = row.Cells["Од"].Value?.ToString() ?? "";
                string date = row.Cells["Огноо"].Value?.ToString() ?? "";


            }
        }

        private void StarForm_Load(object sender, EventArgs e)
        {
            // ✅ 1. Эхлээд Event-үүдийг түр унтрааx
            dtpFrom.ValueChanged -= dtpFrom_ValueChanged;
            dtpTo.ValueChanged -= dtpTo_ValueChanged;

            // ✅ 2. Огноо тохируулах (Event ажиллахгүй)
            dtpFrom.Value = new DateTime(2020, 1, 1);
            dtpTo.Value = DateTime.Today;

            // ✅ 3. Database-ээс өгөгдөл татах
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = @"
    SELECT 
        R.movieID       AS movieID,
        M.title         AS title,
        M.director      AS director,
        R.reviewerID    AS reviewerID,
        V.rName         AS rName,
        R.ratingDate    AS ratingDate,
        R.stars         AS stars
    FROM rating AS R
    INNER JOIN movie    AS M ON R.movieID    = M.movieID
    INNER JOIN reviewer AS V ON R.reviewerID = V.reviewerID";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    _fullData = new DataTable();
                    da.Fill(_fullData);

                    _fullData.Columns["movieID"].ColumnName = "Кино ID";
                    _fullData.Columns["title"].ColumnName = "Нэр";
                    _fullData.Columns["director"].ColumnName = "Продюсер";
                    _fullData.Columns["reviewerID"].ColumnName = "Үзэгч ID";
                    _fullData.Columns["rName"].ColumnName = "Үзэгч";
                    _fullData.Columns["ratingDate"].ColumnName = "Огноо";
                    _fullData.Columns["stars"].ColumnName = "Од";

                    dgvstar1.DataSource = _fullData.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ✅ 4. Event-үүдийг буцааж асаах
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            dtpTo.ValueChanged += dtpTo_ValueChanged;

            // ✅ 5. Өгөгдөл татсаны ДАРАА filter хийх
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string search = txtSearch.Text.Trim();
            string fromStr = dtpFrom.Value.Date.ToString("MM/dd/yyyy");
            string toStr = dtpTo.Value.Date.ToString("MM/dd/yyyy");
            int minStar = (int)nudMin.Value;  // ← Хамгийн бага од
            int maxStar = (int)nudMax.Value;  // ← Хамгийн их од

            // ✅ Огноо + Од filter нэгтгэсэн
            string filter = $"Огноо >= #{fromStr}# AND Огноо <= #{toStr}# " +
                            $"AND Од >= {minStar} AND Од <= {maxStar}";

            if (!string.IsNullOrEmpty(search))
                filter += $" AND (Нэр LIKE '%{search}%' OR Үзэгч LIKE '%{search}%')";

            try
            {
                _fullData.DefaultView.RowFilter = filter;
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter алдаа: " + ex.Message);
            }
        }


        // DateTimePicker Events
        private void dtpFrom_ValueChanged(object sender, EventArgs e) => ApplyFilter();
        private void dtpTo_ValueChanged(object sender, EventArgs e) => ApplyFilter();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // ↑ txtSearch дээр үсэг бичих бүрт ажиллана

            string search = txtSearch.Text.Trim();
            // ↑ Хайх үгийг авах, хоосон зай арилгах

            if (string.IsNullOrEmpty(search))
            {
                _fullData.DefaultView.RowFilter = "";
                // ↑ Хайлт хоосон бол filter арилгана (бүгдийг харуулна)
            }
            else
            {
                _fullData.DefaultView.RowFilter =
                    $"Нэр LIKE '%{search}%' OR Үзэгч LIKE '%{search}%'";
                // ↑ "Нэр" эсвэл "Үзэгч" баганаас хайна
                //   % гэдэг нь "ямар ч тэмдэгт байж болно" гэсэн утга
            }


            // ↑ Хэдэн бичлэг олдсоныг label дээр харуулна
            ApplyFilter(); // ← Шууд ApplyFilter дуудна
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}