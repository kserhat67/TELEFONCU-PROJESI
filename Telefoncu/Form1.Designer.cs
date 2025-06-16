namespace Telefoncu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnSatisFormAc = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUrunler = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGunSonu = new System.Windows.Forms.Label();
            this.tabMusteriler = new System.Windows.Forms.TabPage();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabUrunler.SuspendLayout();
            this.tabMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(250, 220);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(120, 30);
            this.btnFiyatGuncelle.TabIndex = 0;
            this.btnFiyatGuncelle.Text = "Fiyat Güncelle";
            // 
            // lblMarka
            // 
            this.lblMarka.Location = new System.Drawing.Point(20, 20);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(54, 23);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(80, 20);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(20, 50);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 23);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(80, 50);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // lblRenk
            // 
            this.lblRenk.Location = new System.Drawing.Point(20, 80);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(54, 23);
            this.lblRenk.TabIndex = 4;
            this.lblRenk.Text = "Renk:";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(80, 80);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 5;
            // 
            // lblStok
            // 
            this.lblStok.Location = new System.Drawing.Point(20, 110);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(54, 23);
            this.lblStok.TabIndex = 6;
            this.lblStok.Text = "Stok:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(80, 110);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.Location = new System.Drawing.Point(20, 140);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(54, 23);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(80, 140);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 180);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ürünü Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(266, 233);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 11;
            this.btnUrunSil.Text = "Ürün Sil";
            // 
            // btnSatisFormAc
            // 
            this.btnSatisFormAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisFormAc.Location = new System.Drawing.Point(972, 435);
            this.btnSatisFormAc.Name = "btnSatisFormAc";
            this.btnSatisFormAc.Size = new System.Drawing.Size(269, 95);
            this.btnSatisFormAc.TabIndex = 12;
            this.btnSatisFormAc.Text = "Satış Formu";
            this.btnSatisFormAc.Click += new System.EventHandler(this.btnSatisFormAc_Click_1);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.Location = new System.Drawing.Point(250, 27);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(1000, 200);
            this.dgvUrunler.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUrunler);
            this.tabControl1.Controls.Add(this.tabMusteriler);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 720);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUrunler
            // 
            this.tabUrunler.Controls.Add(this.label7);
            this.tabUrunler.Controls.Add(this.label6);
            this.tabUrunler.Controls.Add(this.label5);
            this.tabUrunler.Controls.Add(this.txtUrunAra);
            this.tabUrunler.Controls.Add(this.label4);
            this.tabUrunler.Controls.Add(this.lblMarka);
            this.tabUrunler.Controls.Add(this.txtMarka);
            this.tabUrunler.Controls.Add(this.lblModel);
            this.tabUrunler.Controls.Add(this.txtModel);
            this.tabUrunler.Controls.Add(this.lblRenk);
            this.tabUrunler.Controls.Add(this.txtRenk);
            this.tabUrunler.Controls.Add(this.lblStok);
            this.tabUrunler.Controls.Add(this.txtStok);
            this.tabUrunler.Controls.Add(this.lblFiyat);
            this.tabUrunler.Controls.Add(this.txtFiyat);
            this.tabUrunler.Controls.Add(this.btnEkle);
            this.tabUrunler.Controls.Add(this.btnUrunSil);
            this.tabUrunler.Controls.Add(this.btnSatisFormAc);
            this.tabUrunler.Controls.Add(this.dgvUrunler);
            this.tabUrunler.Controls.Add(this.lblGunSonu);
            this.tabUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabUrunler.Name = "tabUrunler";
            this.tabUrunler.Size = new System.Drawing.Size(1272, 694);
            this.tabUrunler.TabIndex = 0;
            this.tabUrunler.Text = "Ürünler";
            this.tabUrunler.Click += new System.EventHandler(this.tabUrunler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(657, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "MÜŞTERİ ÜRÜN SATIŞ";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(661, 3);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAra.TabIndex = 18;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ürün Ara:";
            // 
            // lblGunSonu
            // 
            this.lblGunSonu.AutoSize = true;
            this.lblGunSonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunSonu.Location = new System.Drawing.Point(654, 267);
            this.lblGunSonu.Name = "lblGunSonu";
            this.lblGunSonu.Size = new System.Drawing.Size(541, 37);
            this.lblGunSonu.TabIndex = 15;
            this.lblGunSonu.Text = "GÜNLÜK ÜRÜN SATIŞI: 0 adet - 0 ₺";
            this.lblGunSonu.Click += new System.EventHandler(this.lblGunSonu_Click);
            // 
            // tabMusteriler
            // 
            this.tabMusteriler.Controls.Add(this.btnMusteriSil);
            this.tabMusteriler.Controls.Add(this.dgvMusteriler);
            this.tabMusteriler.Controls.Add(this.txtAdSoyad);
            this.tabMusteriler.Controls.Add(this.txtTelefon);
            this.tabMusteriler.Controls.Add(this.txtAdres);
            this.tabMusteriler.Controls.Add(this.btnMusteriEkle);
            this.tabMusteriler.Controls.Add(this.label1);
            this.tabMusteriler.Controls.Add(this.label2);
            this.tabMusteriler.Controls.Add(this.label3);
            this.tabMusteriler.Location = new System.Drawing.Point(4, 22);
            this.tabMusteriler.Name = "tabMusteriler";
            this.tabMusteriler.Size = new System.Drawing.Size(1272, 694);
            this.tabMusteriler.TabIndex = 1;
            this.tabMusteriler.Text = "Müşteriler";
            this.tabMusteriler.Click += new System.EventHandler(this.tabMusteriler_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(252, 235);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(107, 41);
            this.btnMusteriSil.TabIndex = 8;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.Location = new System.Drawing.Point(252, 29);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(1000, 200);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(100, 20);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 50);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(100, 80);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 3;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(100, 115);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(122, 41);
            this.btnMusteriEkle.TabIndex = 4;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(657, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "MÜŞTERİ SATIŞ İPTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(901, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "→";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Telefoncu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabUrunler.ResumeLayout(false);
            this.tabUrunler.PerformLayout();
            this.tabMusteriler.ResumeLayout(false);
            this.tabMusteriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnSatisFormAc;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUrunler;
        private System.Windows.Forms.TabPage tabMusteriler;
        private System.Windows.Forms.Label lblGunSonu;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}