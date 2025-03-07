using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class FrmBilgi: Form
    {
        public FrmBilgi()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
        }
        public string isim;
        private void FrmBilgi_Load(object sender, EventArgs e)
        {
            BtnSonraki.Text = "Başlat";
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            label8.Text = isim;
        }
        int sayac = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac--;
            LblKalanSüre.Text = sayac.ToString();
            if (sayac == 0)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = true;
                timer1.Stop();
            }
            if (sayac == 3 )
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 0)
            {
                this.BackColor = Color.LightSteelBlue;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                BtnSonraki.Enabled = true;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                timer1.Stop();
            }
        }
        
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            LblSoruNo.Text = soruno.ToString();
            BtnSonraki.Text = "Sonraki";

            if (soruno == 1)
            {
                timer1.Start();
                BtnA.Enabled = true;
                BtnB.Enabled = true;
                BtnC.Enabled = true;
                BtnD.Enabled = true;
                BtnSonraki.Enabled = false;

                richTextBox1.Text = "Cumhuriyetimiz kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                
            }

            if (soruno == 2)
            {
                timer1.Start();
                sayac = 11;
                BtnA.Enabled = true;
                BtnB.Enabled = true;
                BtnC.Enabled = true;
                BtnD.Enabled = true;
                BtnSonraki.Enabled = false;

                richTextBox1.Text = "Balıyla meşhur Erzincan ilçesi?";
                BtnA.Text = "Üzümlü";
                BtnB.Text = "Çayırlı";
                BtnC.Text = "Tercan";
                BtnD.Text = "Kemaliye";
                label4.Text = "Çayırlı";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                
            }

            if (soruno == 3)
            {
                timer1.Start();
                sayac = 11;
                BtnA.Enabled = true;
                BtnB.Enabled = true;
                BtnC.Enabled = true;
                BtnD.Enabled = true;
                BtnSonraki.Enabled = false;

                richTextBox1.Text = "Hayvan Çiftliği kitabının yazarı kimdir?";
                BtnA.Text = "George Orwell";
                BtnB.Text = "Amin Maalouf";
                BtnC.Text = "Paulo Coelho";
                BtnD.Text = "Sylvester Stellone";
                label4.Text = "George Orwell";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

            }

            if (soruno == 4)
            {
                timer1.Start();
                sayac = 11;
                BtnA.Enabled = true;
                BtnB.Enabled = true;
                BtnC.Enabled = true;
                BtnD.Enabled = true;
                BtnSonraki.Enabled = false;

                richTextBox1.Text = "Yunanistan ile Türkiye arasında doğal sınır olan nehir hangisidir?";
                BtnA.Text = "Tuna";
                BtnB.Text = "Meriç";
                BtnC.Text = "Kızılırmak";
                BtnD.Text = "Menderes";
                label4.Text = "Meriç";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

            }

            if (soruno == 5)
            {
                timer1.Start();
                sayac = 11;
                BtnA.Enabled = true;
                BtnB.Enabled = true;
                BtnC.Enabled = true;
                BtnD.Enabled = true;
                BtnSonraki.Enabled = false;

                richTextBox1.Text = "Türkiye'nin en işlek kapısı olan ve Bulgaristan'a açılan sınır kapısı aşağıdakilerden hangisidir?";
                BtnA.Text = "İpsala";
                BtnB.Text = "Sarp";
                BtnC.Text = "Pazarkule";
                BtnD.Text = "Kapıkule";
                label4.Text = "Kapıkule";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                BtnSonraki.Text = "Sonuçlar";
            }
            int sonuc ;
            
            if (soruno == 6)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                sonuc = dogru * 20;

                MessageBox.Show("Puanınız : " + sonuc);

                if (sonuc == 100)
                {
                    MessageBox.Show("Tebrikler. Hiç yanlış yapmadınız :)");
                }
            }
        }
    }
}
