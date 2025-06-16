namespace Telefoncu
{
    partial class KayitForm
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
            this.txtYeniKullanici = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYeniKullanici
            // 
            this.txtYeniKullanici.Location = new System.Drawing.Point(100, 30);
            this.txtYeniKullanici.Name = "txtYeniKullanici";
            this.txtYeniKullanici.Size = new System.Drawing.Size(150, 20);
            this.txtYeniKullanici.TabIndex = 0;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(100, 70);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(150, 20);
            this.txtYeniSifre.TabIndex = 1;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(120, 110);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(100, 30);
            this.btnKayitOl.TabIndex = 2;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // KayitForm
            // 
            this.ClientSize = new System.Drawing.Size(369, 189);
            this.Controls.Add(this.txtYeniKullanici);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.btnKayitOl);
            this.Name = "KayitForm";
            this.Text = "Yeni Kullanıcı Kaydı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniKullanici;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button btnKayitOl;
    }
}
