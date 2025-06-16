namespace Telefoncu
{
    partial class GirisForm
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.btnKayitEkrani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Location = new System.Drawing.Point(126, 135);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(179, 30);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "KULLANICI ADI :";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(311, 145);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(114, 20);
            this.txtKullanici.TabIndex = 1;
            this.txtKullanici.TextChanged += new System.EventHandler(this.txtKullanici_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Location = new System.Drawing.Point(219, 185);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(86, 30);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "ŞİFRE :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(311, 195);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(114, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(449, 135);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(167, 99);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "GİRİŞ YAP";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // btnKayitEkrani
            // 
            this.btnKayitEkrani.Location = new System.Drawing.Point(650, 173);
            this.btnKayitEkrani.Name = "btnKayitEkrani";
            this.btnKayitEkrani.Size = new System.Drawing.Size(75, 23);
            this.btnKayitEkrani.TabIndex = 5;
            this.btnKayitEkrani.Text = "KAYIT OL";
            this.btnKayitEkrani.UseVisualStyleBackColor = true;
            this.btnKayitEkrani.Click += new System.EventHandler(this.btnKayitEkrani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(133, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "TELEFON SATIŞ SİSTEMİ";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayitEkrani);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKullanici);
            this.Name = "GirisForm";
            this.Text = "GirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button btnKayitEkrani;
        private System.Windows.Forms.Label label1;
    }
}
