using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tyrtyvshin
{
    public partial class StarForm : Form
    {
        string connStr = "server=localhost;port=3308;database=movie;uid=root;pwd=Turuu66#;";                    

        public StarForm()
        {
            InitializeComponent();
        }

        MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        void LoadData()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(
                        "SELECT R.movieID, M.title, M.director, R.reviewerID, V.rName, R.ratingDate, R.stars " +
                        "FROM (rating AS R INNER JOIN movie AS M ON R.movieID = M.movieID) " +
                        "INNER JOIN reviewer AS V ON R.reviewerID = V.reviewerID", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvstar1.DataSource = dt;

                    dgvstar1.Columns["movieID"].HeaderText = "Кино ID";
                    dgvstar1.Columns["title"].HeaderText = "Киноны нэр";
                    dgvstar1.Columns["director"].HeaderText = "Продюсер";
                    dgvstar1.Columns["reviewerID"].HeaderText = "Үзэгч ID";
                    dgvstar1.Columns["rName"].HeaderText = "Үзэгч";
                    dgvstar1.Columns["ratingDate"].HeaderText = "Огноо";
                    dgvstar1.Columns["stars"].HeaderText = "Од";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvstar1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void StarForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
