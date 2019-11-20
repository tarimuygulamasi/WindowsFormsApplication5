namespace TarimUygulamasi
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sifreHatırlat = new System.Windows.Forms.Label();
            this.kullaniciEkle = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.girisButonu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifreHatırlat
            // 
            this.sifreHatırlat.AutoSize = true;
            this.sifreHatırlat.ForeColor = System.Drawing.Color.White;
            this.sifreHatırlat.Location = new System.Drawing.Point(211, 231);
            this.sifreHatırlat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sifreHatırlat.Name = "sifreHatırlat";
            this.sifreHatırlat.Size = new System.Drawing.Size(140, 24);
            this.sifreHatırlat.TabIndex = 12;
            this.sifreHatırlat.Text = "Şifremi unuttum";
            this.sifreHatırlat.Click += new System.EventHandler(this.sifreHatırlat_Click_1);
            // 
            // kullaniciEkle
            // 
            this.kullaniciEkle.AutoSize = true;
            this.kullaniciEkle.ForeColor = System.Drawing.Color.White;
            this.kullaniciEkle.Location = new System.Drawing.Point(11, 231);
            this.kullaniciEkle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kullaniciEkle.Name = "kullaniciEkle";
            this.kullaniciEkle.Size = new System.Drawing.Size(160, 24);
            this.kullaniciEkle.TabIndex = 11;
            this.kullaniciEkle.Text = "Yeni kullanıcı ekle";
            this.kullaniciEkle.Click += new System.EventHandler(this.kullaniciEkle_Click_1);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(195, 131);
            this.sifre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(156, 29);
            this.sifre.TabIndex = 9;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BackColor = System.Drawing.SystemColors.Window;
            this.kullaniciAdi.Location = new System.Drawing.Point(195, 83);
            this.kullaniciAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(156, 29);
            this.kullaniciAdi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifreniz             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adınız :";
            // 
            // girisButonu
            // 
            this.girisButonu.BackColor = System.Drawing.Color.Teal;
            this.girisButonu.ForeColor = System.Drawing.Color.White;
            this.girisButonu.Location = new System.Drawing.Point(195, 172);
            this.girisButonu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(156, 44);
            this.girisButonu.TabIndex = 6;
            this.girisButonu.Text = "Giriş";
            this.girisButonu.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(98, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "GİRİŞ PANELİ";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(380, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifreHatırlat);
            this.Controls.Add(this.kullaniciEkle);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisButonu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarım Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifreHatırlat;
        private System.Windows.Forms.Label kullaniciEkle;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisButonu;
        private System.Windows.Forms.Label label3;
    }
}

