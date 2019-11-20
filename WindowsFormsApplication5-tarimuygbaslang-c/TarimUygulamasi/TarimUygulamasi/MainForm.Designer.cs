namespace TarimUygulamasi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sifreHatırlat = new System.Windows.Forms.Label();
            this.kullaniciEkle = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.girisButonu = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sifreHatırlat);
            this.tabPage1.Controls.Add(this.kullaniciEkle);
            this.tabPage1.Controls.Add(this.sifre);
            this.tabPage1.Controls.Add(this.kullaniciAdi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.girisButonu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sifreHatırlat
            // 
            this.sifreHatırlat.AutoSize = true;
            this.sifreHatırlat.Location = new System.Drawing.Point(330, 187);
            this.sifreHatırlat.Name = "sifreHatırlat";
            this.sifreHatırlat.Size = new System.Drawing.Size(79, 13);
            this.sifreHatırlat.TabIndex = 5;
            this.sifreHatırlat.Text = "Şifremi unuttum";
            // 
            // kullaniciEkle
            // 
            this.kullaniciEkle.AutoSize = true;
            this.kullaniciEkle.Location = new System.Drawing.Point(330, 209);
            this.kullaniciEkle.Name = "kullaniciEkle";
            this.kullaniciEkle.Size = new System.Drawing.Size(92, 13);
            this.kullaniciEkle.TabIndex = 4;
            this.kullaniciEkle.Text = "Yeni kullanıcı ekle";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(333, 125);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(146, 20);
            this.sifre.TabIndex = 3;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(333, 94);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(146, 20);
            this.kullaniciAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifreniz             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adınız :";
            // 
            // girisButonu
            // 
            this.girisButonu.Location = new System.Drawing.Point(375, 151);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(65, 24);
            this.girisButonu.TabIndex = 0;
            this.girisButonu.Text = "Giriş";
            this.girisButonu.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label sifreHatırlat;
        private System.Windows.Forms.Label kullaniciEkle;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisButonu;
        private System.Windows.Forms.TabPage tabPage2;
    }
}