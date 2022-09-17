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
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }



        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");



        //private void btnHesapla_Click(object sender, EventArgs e)
        //{
        //    int personel;
        //    personel = Convert.ToInt32(txtPersonelSayisi.Text);
        //    lblPersonelMaaslari.Text = (personel * 5500).ToString();
        //}








        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        private void frmGelirGider_Load(object sender, EventArgs e)
        {
            lblIcecek.Visible = false;
            lblGida.Visible = false;
            lblAtistirma.Visible = false;
            lblDogalgaz.Visible = false;
            lblSu.Visible = false;
            lblInternet.Visible = false;
            lblElektrik.Visible = false;
            lblPersonel.Visible = false;
            lblKasa.Visible = false;
            lblSonucYazisi.Visible = false;

            //Kasadaki Toplam Tutar => Müşterilerin Oda Ücretleri Toplamı
            connection.Open();
            SqlCommand komut1 = new SqlCommand("Select Sum(Ucret) as Toplam1 from MusteriEkle",connection);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                lblKasaToplam.Text = oku1["Toplam1"].ToString() + " ₺";
                lblKasa.Text = oku1["Toplam1"].ToString();
            }
            connection.Close();


            //Alınan Ürünlerin Toplamı => Stok Giderlerinin Toplamı
            //Gıdaların Masrafları
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Select Sum(Gida) as Toplam2 from Stoklar", connection);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                lblGida.Text = oku2["Toplam2"].ToString();
            }
            connection.Close();



            //İçeceklerin Masrafları
            connection.Open();
            SqlCommand komut3 = new SqlCommand("Select Sum(Icecek) as Toplam3 from Stoklar", connection);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                lblIcecek.Text = oku3["Toplam3"].ToString();
            }
            connection.Close();



            //Atıştırmalıkların Toplamı
            connection.Open();
            SqlCommand komut4 = new SqlCommand("Select Sum(Atistirmalik) as Toplam4 from Stoklar", connection);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                lblAtistirma.Text = oku4["Toplam4"].ToString();
            }
            connection.Close();



            //Mutfak(Alınan Ürünler) Toplam Tutar Hesaplaması
            int toplam1 = int.Parse(lblAtistirma.Text) + int.Parse(lblGida.Text) + int.Parse(lblIcecek.Text);
            lblUrunToplam.Text = toplam1.ToString() + " ₺";







            //Faturalar => Fatura Giderlerinin Toplamı
            //Doğalgaz Masrafları
            connection.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(Dogalgaz) as Toplam5 from Faturalar", connection);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                lblDogalgaz.Text = oku5["Toplam5"].ToString();
            }
            connection.Close();




            //Elektrik Masrafları
            connection.Open();
            SqlCommand komut6 = new SqlCommand("Select Sum(Elektrik) as Toplam6 from Faturalar", connection);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                lblElektrik.Text = oku6["Toplam6"].ToString();
            }
            connection.Close();





            //Su Masrafları
            connection.Open();
            SqlCommand komut7 = new SqlCommand("Select Sum(Su) as Toplam7 from Faturalar", connection);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                lblSu.Text = oku7["Toplam7"].ToString();
            }
            connection.Close();





            //İnternet Masrafları
            connection.Open();
            SqlCommand komut8 = new SqlCommand("Select Sum(Internet) as Toplam8 from Faturalar", connection);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                lblInternet.Text = oku8["Toplam8"].ToString();
            }
            connection.Close();




            //Fatura Toplam Tutar Hesaplaması
            int toplam2 = int.Parse(lblDogalgaz.Text) + int.Parse(lblElektrik.Text) + int.Parse(lblSu.Text) + int.Parse(lblInternet.Text);
            lblFaturalar.Text = toplam2.ToString() + " ₺";






            //Personel Maaş Masrafları
            connection.Open();
            SqlCommand komut9 = new SqlCommand("Select Sum(Maas) as Toplam9 from Personel", connection);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                lblPersonelMaaslari.Text = oku9["Toplam9"].ToString() + " ₺";
                lblPersonel.Text = oku9["Toplam9"].ToString();
            }
            connection.Close();












            //Gelir-Gider Durumu Hesaplaması
            int toplam3 = int.Parse(lblPersonel.Text);
            int toplam4 = toplam1 + toplam2 + toplam3;
            int gelir = int.Parse(lblKasa.Text);
            lblSonuc.Text = (gelir-toplam4).ToString() + " ₺";

            if ((gelir - toplam4) < 0)
            {
                lblSonuc.ForeColor = Color.Red;
                lblSonucYazisi.Text = "Kurum Zarar Ediyor";
                lblSonucYazisi.Visible = true;
            }
            else
            {
                lblSonuc.ForeColor = Color.DarkBlue;
                lblSonucYazisi.Text = "Kurum Kâr Ediyor";
                lblSonucYazisi.Visible = true;
            }
        }












    }
}
