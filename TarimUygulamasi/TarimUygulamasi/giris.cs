using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TarimUygulamasi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LBBDB5R\\SQLEXPRESS; Initial Catalog=TarimUygulamasi; Integrated Security=SSPI");
        kgoster frm2 = new kgoster();

        private void Form1_Load(object sender, EventArgs e)
        {            
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Open();
        }

        private void girisButonu_Click(object sender, EventArgs e)
        {

            try
            {

            
            //kullanıcılar tablosundan girilen bilgilerin var olup olmadığını kontrol edildi.
            SqlCommand sorgu = new SqlCommand("SELECT k_adi, k_sifre FROM Kullanicilar WHERE k_adi='" + kullaniciAdi + "' AND k_sifre='" + sifre + "'", baglanti);
            SqlDataReader kytoku = sorgu.ExecuteReader();
                //girilen değer doğruysa giriş seviyesine göre sayfaya yönlendirildi
                if (kytoku.HasRows)
                {
                this.Hide();
                frm2.Show();
                }
                else
                {
                MessageBox.Show("Girilen bilgiler hatalıdır.Lütfen bilgilerinizi kontrol edip tekrar deneyin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                
            }

        }
        private void sifreHatırlat_Click(object sender, EventArgs e)
        {
            sifre sf = new sifre();
            this.Hide();
            sf.Show();
        }

        private void kullaniciEkle_Click(object sender, EventArgs e)
        {
            ekle ek = new ekle();
            this.Hide();
            ek.Show();
        }

        
    }
}
