using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace Telefoncu
{
    public partial class Form1 : Form
    {
        private readonly string connStr = "Server=localhost;Database=telefoncu;Uid=root;Pwd=664821;Port=3307;";

        public Form1()
        {
            InitializeComponent();

            //btnGuncelle.Click += btnGuncelle_Click;

            this.Load += Form1_Load;
            //  btnEkle.Click += btnEkle_Click;
            
           
            btnUrunSil.Click += BtnUrunSil_Click;
            btnSatisFormAc.Click += btnSatisFormAc_Click;
            btnMusteriSil.Click += BtnMusteriSil_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriListele();
            MusteriListele();
            ToplamStokGuncelle();
            GunSonuHesapla();
        }

        private void UrunleriListele()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM urunler";
                using (var da = new MySqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUrunler.DataSource = dt;
                }
            }
        }

        private void MusteriListele()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM musteriler";
                using (var da = new MySqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMusteriler.DataSource = dt;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO urunler (marka, model, renk, stok, fiyat) VALUES (@marka, @model, @renk, @stok, @fiyat)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@marka", txtMarka.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@renk", txtRenk.Text);


                    cmd.ExecuteNonQuery();
                }
            }
            UrunleriListele();
            ToplamStokGuncelle();
        }

  

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow != null)
            {
                int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["urun_id"].Value);
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM urunler WHERE urun_id = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", urunId);
                        cmd.ExecuteNonQuery();
                    }
                }
                UrunleriListele();
                ToplamStokGuncelle();
            }
        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                int musteriId = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["musteri_id"].Value);

                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string kontrolSql = "SELECT COUNT(*) FROM satislar WHERE musteri_id = @musteriId";
                    using (var kontrolCmd = new MySqlCommand(kontrolSql, conn))
                    {
                        kontrolCmd.Parameters.AddWithValue("@musteriId", musteriId);
                        int satisSayisi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                        if (satisSayisi > 0)
                        {
                            MessageBox.Show("Bu müşteriye ait satış kaydı olduğu için silinemez. Önce satışları silmeniz gerekir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string sql = "DELETE FROM musteriler WHERE musteri_id = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", musteriId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MusteriListele();
                dgvMusteriler.AllowUserToAddRows = false;

            }
        }

        private void btnSatisFormAc_Click(object sender, EventArgs e)
        {
            SatisForm sf = new SatisForm();
            sf.ShowDialog();
            UrunleriListele();
            ToplamStokGuncelle();
            GunSonuHesapla();
        }

        private void ToplamStokGuncelle()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT SUM(stok) FROM urunler";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int toplamStok = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                }
            }
        }

        private void GunSonuHesapla()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT SUM(adet), SUM(toplam_fiyat) FROM satislar WHERE DATE(tarih) = CURDATE()";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int toplamAdet = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            decimal toplamFiyat = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                            lblGunSonu.Text = $"Bugünkü satış: {toplamAdet} adet - {toplamFiyat:0.00} ₺";
                        }
                    }
                }
            }
        }

        private void tabMusteriler_Click(object sender, EventArgs e)
        {
        }

        private void btnSatisFormAc_Click_1(object sender, EventArgs e)
        {

        }

        private void tabUrunler_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
    string.IsNullOrWhiteSpace(txtTelefon.Text) ||
    string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Lütfen tüm müşteri bilgilerini doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1️⃣ PROSEDÜRÜ YAZ: MySQL 'CREATE PROCEDURE' komutu
                    string createProc = @"
            DROP PROCEDURE IF EXISTS MusteriEkle;
            CREATE PROCEDURE MusteriEkle (
                IN p_adsoyad VARCHAR(100),
                IN p_telefon VARCHAR(20),
                IN p_adres TEXT
            )
            BEGIN
                INSERT INTO musteriler (ad_soyad, telefon, adres)
                VALUES (p_adsoyad, p_telefon, p_adres);
            END";

                    using (var createCmd = new MySqlCommand(createProc, conn))
                    {
                        createCmd.ExecuteNonQuery(); // ✅ prosedürü her seferinde yeniden oluşturur
                    }

                    // 2️⃣ PROSEDÜRÜ ÇAĞIR
                    using (var cmd = new MySqlCommand("CALL MusteriEkle(@ad, @telefon, @adres)", conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MusteriListele();

                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
                txtAdres.Text = "";
                txtAdSoyad.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            string marka = txtMarka.Text.Trim();
            string model = txtModel.Text.Trim();
            string renk = txtRenk.Text.Trim();

            int stok;
            decimal fiyat;

            if (!int.TryParse(txtStok.Text.Trim(), out stok))
            {
                MessageBox.Show("Stok alanı geçerli bir tam sayı olmalı.");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text.Trim().Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out fiyat))
            {
                MessageBox.Show("Fiyat alanı geçerli bir sayı olmalı.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("CALL UrunEkle(@marka, @model, @renk, @stok, @fiyat)", conn))
                    {
                        cmd.Parameters.AddWithValue("@marka", marka);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@renk", renk);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ürün başarıyla eklendi!");
                UrunleriListele();
                ToplamStokGuncelle();

                txtMarka.Text = "";
                txtModel.Text = "";
                txtRenk.Text = "";
                txtStok.Text = "";
                txtFiyat.Text = "";
                txtMarka.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtUrunAra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtUrunAra.Text.Trim().ToLower();

            if (dgvUrunler.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter =
                    $"marka LIKE '%{aranan}%' OR model LIKE '%{aranan}%' OR renk LIKE '%{aranan}%'";
            }
        }

 

   

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen fiyatını güncellemek istediğiniz ürünü seçiniz.");
                return;
            }

            int urunId = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urun_id"].Value);
            string marka = dgvUrunler.SelectedRows[0].Cells["marka"].Value.ToString();
            string model = dgvUrunler.SelectedRows[0].Cells["model"].Value.ToString();
            string mevcutFiyat = dgvUrunler.SelectedRows[0].Cells["fiyat"].Value.ToString();

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"{marka} {model} için yeni fiyat girin (mevcut: {mevcutFiyat})",
                "Fiyat Güncelle",
                mevcutFiyat
            );

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!decimal.TryParse(input.Replace(",", "."), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out decimal yeniFiyat))
            {
                MessageBox.Show("Geçerli bir fiyat giriniz.");
                return;
            }

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE urunler SET fiyat = @fiyat WHERE urun_id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fiyat", yeniFiyat);
                    cmd.Parameters.AddWithValue("@id", urunId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Fiyat başarıyla güncellendi!");
            UrunleriListele();
        }

        private void lblGunSonu_Click(object sender, EventArgs e)
        {

        }
    }
}