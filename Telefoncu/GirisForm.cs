using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Telefoncu
{
    public partial class GirisForm : Form
    {
        string connStr = "Server=localhost;Database=telefoncu;Uid=root;Pwd=664821;Port=3307;";

        public GirisForm()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
{
    string kullanici = txtKullanici.Text.Trim();
    string sifre = txtSifre.Text.Trim();

    using (MySqlConnection conn = new MySqlConnection(connStr))
    {
        conn.Open();

        string query = "SELECT * FROM kullanicilar WHERE kullanici_adi = @kadi AND sifre = @sifre";

        using (MySqlCommand cmd = new MySqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@kadi", kullanici);
            cmd.Parameters.AddWithValue("@sifre", sifre);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Close(); // 🔥 ZORUNLU

                    //  TRIGGER CAGIRILIYOR 
                    using (MySqlCommand logCmd = new MySqlCommand("INSERT INTO kullanici_giris (kullanici_adi) VALUES (@kul)", conn))
                    {
                        logCmd.Parameters.AddWithValue("@kul", kullanici);
                        logCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Giriş başarılı!");
                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    reader.Close(); 
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }
        }
    }
}


        private void btnKayitEkrani_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm();
            kf.ShowDialog();
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {
            string kullanici = txtKullanici.Text.Trim().ToLower();

            if (kullanici == "admin")
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();

                        string sql = "INSERT INTO kullanici_giris (kullanici_adi) VALUES (@kul)";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@kul", kullanici);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // (İsteğe bağlı)
                    // MessageBox.Show("Admin tespit edildi, log atıldı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    }
}