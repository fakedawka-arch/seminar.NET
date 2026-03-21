using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyrtyvshin
{


    public partial class LoginForm : Form

    {
        string connStr = "server=localhost;port=3308;database=movie;uid=root;password=Turuu66#;";

        MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Хэрэглэгчийн нэр, нууц үг хоосон эсэхийг шалгах
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Мэдээллээ бүрэн бөглөнө үү!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string MySql = "SELECT * FROM reviewer WHERE rName=@user AND rPass=@pass";
                    MySqlCommand cmd = new MySqlCommand(MySql, conn);
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Амжилттай нэвтэрлээ!");

                            Mainform main = new Mainform();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Хэрэглэгчийн нэр эсвэл нууц үг буруу байна!");
                        }
                }
            }
            catch (Exception ex)
            {
                // image_38b917 дээрх шиг програм гацахаас сэргийлнэ
                MessageBox.Show("Холболтын алдаа: " + ex.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

