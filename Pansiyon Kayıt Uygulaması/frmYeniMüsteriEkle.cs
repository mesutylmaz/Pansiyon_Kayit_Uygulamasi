using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmYeniMüsteriEkle : Form
    {
        public frmYeniMüsteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mavi renkli butonlar boş odaları gösterir.");
        }

        private void dtCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtCikisTarihi.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;       //TimeSpan iki tarih arası farkı hesaplar

            int gunSayisi = (int)sonuc.TotalDays;      //TotalDays toplam gün sayısını verir.
            if (gunSayisi >= 0)
            {
                label11.Text = gunSayisi.ToString();
                ucret = Convert.ToInt32(label11.Text) * 50;

                txtOdaUcreti.Text = ucret.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TcNo,OdaNo,Ucret)                                                                                                  VALUES ('" + txtAdi.Text+"','" + txtSoyadi.Text +"','" + cmbCinsiyet.Text+ "','" 
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','" 
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "')", connection);
            komut.ExecuteNonQuery();        //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar
            connection.Close();
            MessageBox.Show("Müşteri kaydı yapıldı.");
        }
    }
}
