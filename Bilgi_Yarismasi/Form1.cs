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

namespace Bilgi_Yarismasi
{
    public partial class FrmGiris: Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=BilgiYarismasi;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtAdSoyad.Text=="" || TxtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Adınızı Soyadınızı ve Şifrenizi giriniz");
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKAYİT where ADSOYAD=@P1 AND SİFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmBilgi fr = new FrmBilgi();
                fr.isim = TxtAdSoyad.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Ad Soyad veya Şifre !");
            }
                baglanti.Close();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayit fr = new FrmKayit();
            fr.Show();
        }
    }
}
