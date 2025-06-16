using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Telefoncu
{
    public partial class KayitForm : Form
    {
        string connStr = "Server=localhost;Database=telefoncu;Uid=root;Pwd=664821;Port=3307;";

        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullanici = txtYeniKullanici.Text.Trim();
            string sifre = txtYeniSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullanici) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Boş bırakma.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Kullanıcı daha önce kayıtlı mı kontrol
                using (MySqlCommand kontrolCmd = new MySqlCommand("SELECT KullaniciVarMi(@kadi)", conn))
                {
                    kontrolCmd.Parameters.AddWithValue("@kadi", kullanici);
                    int varMi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu kullanıcı zaten kayıtlı!");
                        return;
                    }
                }

                // Yeni kullanıcıyı kayıt
                string query = "INSERT INTO kullanicilar (kullanici_adi, sifre) VALUES (@kadi, @sifre)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kadi", kullanici);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı!");
                this.Close();
            }
    }
}