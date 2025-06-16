namespace Telefoncu
{
    partial class SatisForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cboMusteriler = new System.Windows.Forms.ComboBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.cboUrunler = new System.Windows.Forms.ComboBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.btnSatisSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteri
            // 
            this.lblMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(55, 60);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(64, 23);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri:";
            // 
            // cboMusteriler
            // 
            this.cboMusteriler.Location = new System.Drawing.Point(123, 59);
            this.cboMusteriler.Name = "cboMusteriler";
            this.cboMusteriler.Size = new System.Drawing.Size(121, 21);
            this.cboMusteriler.TabIndex = 1;
            // 
            // lblUrun
            // 
            this.lblUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.Location = new System.Drawing.Point(74, 106);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(45, 23);
            this.lblUrun.TabIndex = 2;
            this.lblUrun.Text = "Ürün:";
            // 
            // cboUrunler
            // 
            this.cboUrunler.Location = new System.Drawing.Point(128, 105);
            this.cboUrunler.Name = "cboUrunler";
            this.cboUrunler.Size = new System.Drawing.Size(121, 21);
            this.cboUrunler.TabIndex = 3;
            // 
            // lblAdet
            // 
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(74, 146);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(48, 23);
            this.lblAdet.TabIndex = 4;
            this.lblAdet.Text = "Adet:";
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(128, 144);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(120, 20);
            this.numAdet.TabIndex = 5;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(72, 176);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(45, 23);
            this.lblBirimFiyat.TabIndex = 6;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(128, 175);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBirimFiyat.TabIndex = 7;
            // 
            // lblToplam
            // 
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(60, 202);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(62, 23);
            this.lblToplam.TabIndex = 8;
            this.lblToplam.Text = "Toplam:";
            this.lblToplam.Click += new System.EventHandler(this.lblToplam_Click);
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(128, 201);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(100, 20);
            this.txtToplam.TabIndex = 9;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(128, 239);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(100, 35);
            this.btnSatisYap.TabIndex = 10;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click_1);
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.Location = new System.Drawing.Point(250, 12);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.Size = new System.Drawing.Size(708, 250);
            this.dgvSatislar.TabIndex = 11;
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.Location = new System.Drawing.Point(749, 268);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(101, 41);
            this.btnSatisSil.TabIndex = 12;
            this.btnSatisSil.Text = "Satış Sil";
            this.btnSatisSil.UseVisualStyleBackColor = true;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // SatisForm
            // 
            this.ClientSize = new System.Drawing.Size(1251, 454);
            this.Controls.Add(this.btnSatisSil);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.cboMusteriler);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.cboUrunler);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.dgvSatislar);
            this.Name = "SatisForm";
            this.Text = "Satış Formu";
            this.Load += new System.EventHandler(this.SatisForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ComboBox cboMusteriler;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.ComboBox cboUrunler;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Button btnSatisSil;
    }
}
