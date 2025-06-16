using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Telefoncu
{
    public partial class SatisForm : Form
    {
        private readonly string connStr =
            "Server=localhost;Database=telefoncu;Uid=root;Pwd=664821;Port=3307;";

        public SatisForm()
        {
            InitializeComponent();

            this.Load += SatisForm_Load;
            cboUrunler.SelectedValueChanged += CboUrunler_SelectedValueChanged;
            numAdet.ValueChanged += (s, e) => HesaplaToplam();
            btnSatisYap.Click += BtnSatisYap_Click;
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            DoldurComboBoxlar();
            numAdet.Minimum = 1;
            numAdet.Value = 1;

            if (cboUrunler.Items.Count > 0)
                cboUrunler.SelectedIndex = 0;

            SatislariListele();
        }

        private void DoldurComboBoxlar()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                var da1 = new MySqlDataAdapter(
                    "SELECT musteri_id, ad_soyad FROM musteriler ORDER BY ad_soyad", conn);
                var dt1 = new DataTable(); da1.Fill(dt1);
                cboMusteriler.DisplayMember = "ad_soyad";
                cboMusteriler.ValueMember = "musteri_id";
                cboMusteriler.DataSource = dt1;

                var da2 = new MySqlDataAdapter(
                    "SELECT urun_id, CONCAT(marka,' ',model) AS urunadi FROM urunler ORDER BY marka,model", conn);
                var dt2 = new DataTable(); da2.Fill(dt2);
                cboUrunler.DisplayMember = "urunadi";
                cboUrunler.ValueMember = "urun_id";
                cboUrunler.DataSource = dt2;
            }
        }

        private void CboUrunler_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboUrunler.SelectedValue is int urunId)
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT fiyat FROM urunler WHERE urun_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", urunId);
                    var result = cmd.ExecuteScalar();
                    txtBirimFiyat.Text = result != null ? result.ToString() : "0.00";
                }
            }
            else
            {
                txtBirimFiyat.Text = "0.00";
            }

            HesaplaToplam();
        }

        private void HesaplaToplam()
        {
            if (decimal.TryParse(txtBirimFiyat.Text, out var birim))
            {
                int adet = (int)numAdet.Value;
                txtToplam.Text = (birim * adet).ToString("0.00");
            }
            else
            {
                txtToplam.Text = "0.00";
            }
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            if (!(cboMusteriler.SelectedValue is int mid) ||
                !(cboUrunler.SelectedValue is int uid))
            {
                MessageBox.Show("Lütfen önce müşteri ve ürün seçin.");
                return;
            }

            int adet = (int)numAdet.Value;
            if (!decimal.TryParse(txtToplam.Text, out var toplam) || toplam <= 0)
            {
                MessageBox.Show("Geçerli bir adet girin.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    var cmd = new MySqlCommand("CALL SatisEkle(@m,@u,@a,@t)", conn);
                    cmd.Parameters.AddWithValue("@m", mid);
                    cmd.Parameters.AddWithValue("@u", uid);
                    cmd.Parameters.AddWithValue("@a", adet);
                    cmd.Parameters.AddWithValue("@t", toplam);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Satış başarıyla kaydedildi!");
                SatislariListele();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void SatislariListele()
        {
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var da = new MySqlDataAdapter(@"
                    SELECT 
                        s.satis_id AS 'Satış No',
                        m.ad_soyad AS 'Müşteri',
                        CONCAT(u.marka,' ',u.model) AS 'Ürün',
                        s.adet AS 'Adet',
                        s.toplam_fiyat AS 'Toplam (₺)',
                        s.tarih AS 'Tarih'
                    FROM satislar s
                    JOIN musteriler m ON m.musteri_id = s.musteri_id
                    JOIN urunler u ON u.urun_id = s.urun_id
                    ORDER BY s.tarih DESC", conn);
                var dt = new DataTable(); da.Fill(dt);
                dgvSatislar.DataSource = dt;
                dgvSatislar.AutoResizeColumns();
            }
        }

        private void SatisForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            if (dgvSatislar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satışı seçiniz.");
                return;
            }

            int satisId = Convert.ToInt32(dgvSatislar.SelectedRows[0].Cells[0].Value);

            DialogResult dialogResult = MessageBox.Show("Seçili satışı silmek istediğinize emin misiniz?", "Satış Sil", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string connStr = "Server=localhost;Database=telefoncu;Uid=root;Pwd=664821;Port=3307;";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = "DELETE FROM satislar WHERE satis_id = @satisId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@satisId", satisId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Satış silindi.");

                    SatislariListele(); // Satışları yeniler
                }
            }
        }

        private void btnSatisYap_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

