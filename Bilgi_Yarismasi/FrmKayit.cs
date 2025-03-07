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
    public partial class FrmKayit: Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=BilgiYarismasi;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtSifre.Text == TxtSifre2.Text)
            {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKAYİT (ADSOYAD,SİFRE) VALUES (@P1,@P2)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
                MessageBox.Show("Kaydınız gerçekleşmiştir");
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor");
            }
        }
    }
}
