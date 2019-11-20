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
    public partial class sifre : Form
    {
        public sifre()
        {
            InitializeComponent();
        }

        private void sifre_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
            SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-LBBDB5R\\SQLEXPRESS; Initial Catalog=TarimUygulamasi; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
            //bağlantı durumu kontrol edildi
            if (bagla.State == ConnectionState.Open)
                bagla.Close();
            bagla.Open();            
            kgoster frm2 = new kgoster(); 
            //telefon numarasına göre arama yapıldı
            SqlCommand telbul=new SqlCommand("SELECT k_sifre FROM Kullanicilar WHERE k_tel='" +tel+ "'",bagla);
            SqlDataReader teloku = telbul.ExecuteReader();
            //eğer aranan değer tabloda varsa şifre kullanıcıya gösterildis
            if (teloku.Read())
            {
                sifreGoster.Text = teloku["k_sifre"].ToString();//!!!!!! düzelt
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz numara hatalı. Lütfen numarayı kontrol edip tekrar deneyin.", "HATA MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bagla.Close();
        }

        
    }
}
