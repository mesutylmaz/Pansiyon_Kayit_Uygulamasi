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
    public partial class frmMasraflar : Form
    {
        public frmMasraflar()
        {
            InitializeComponent();
        }



        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");



        private void verileriGoster()
        {
            listView1.Items.Clear();    //Verileri Göster metotu her çağrıldığında ListView içini temizle ve sonra yükle demiş olduk.

            connection.Open();  //Bağlantımı aç
            SqlCommand command = new SqlCommand("select * from Stoklar", connection);       //Verileri Çek
            SqlDataReader reader = command.ExecuteReader();     //Çekilen verileri Oku

            while (reader.Read())       //Okuma işlemi yapılırken
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = reader["ID"].ToString();       //PrimaryKey property, Text olarak belirtiliyor. Yani, Ana ögeyi belirtiyoruz
                liste.SubItems.Add(reader["Gida"].ToString());      //Alt ögeler SubItems.Add ile ekleniyor
                liste.SubItems.Add(reader["Icecek"].ToString());
                liste.SubItems.Add(reader["Atistirmalik"].ToString());
                liste.SubItems.Add(reader["Tarih"].ToString());
                liste.SubItems.Add(reader["Saat"].ToString());

                listView1.Items.Add(liste);
            }
            connection.Close();     //Bağlantıyı kapat
        }




        private void verileriGosterFatura()
        {
            listView2.Items.Clear();    

            connection.Open();  
            SqlCommand command = new SqlCommand("select * from Faturalar", connection);       
            SqlDataReader reader = command.ExecuteReader();     

            while (reader.Read())       
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = reader["ID"].ToString();       
                liste.SubItems.Add(reader["Dogalgaz"].ToString());      
                liste.SubItems.Add(reader["Elektrik"].ToString());
                liste.SubItems.Add(reader["Su"].ToString());
                liste.SubItems.Add(reader["Internet"].ToString());
                liste.SubItems.Add(reader["Tarih"].ToString());
                liste.SubItems.Add(reader["Saat"].ToString());

                listView2.Items.Add(liste);
            }
            connection.Close();    
        }





        private void frmStoklar_Load(object sender, EventArgs e)
        {
            verileriGoster();
            verileriGosterFatura();
        }








        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            connection.Open();

            if (dtpTarih.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş Döneme Ait Bir Stok Ödemesi Yapılamaz!");
                connection.Close();
                verileriGoster();
            }

            if (nmrGida.Text == "0" && nmrIcecek.Text == "0" && nmrAtistirma.Text == "0")
            {
                MessageBox.Show("Gıda, İçecek veya Atıştırmalık Tutarı alanlarından en az birine veri girişi yapmalısınız!");
                connection.Close();
                verileriGoster();
            }
            else
            {
                string saat = DateTime.Now.ToShortTimeString();
                string tarih = dtpTarih.Value.ToShortDateString();

                SqlCommand komut1 = new SqlCommand("Insert Into Stoklar(Gida, Icecek, Atistirmalik, Tarih, Saat) VALUES ('" + nmrGida.Text + "','" + nmrIcecek.Text + "','" + nmrAtistirma.Text + "','" + tarih + "','" + saat + "')", connection);
                komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar

                connection.Close();
                verileriGoster();
                MessageBox.Show("Stok Girişi Kaydı Başarıyla Tamamlandı.");
                nmrAtistirma.Value = 0;
                nmrGida.Value = 0;
                nmrIcecek.Value = 0;
            }
        }









        private void btnKaydetFatura_Click(object sender, EventArgs e)
        {
            //Liste:

            connection.Open();

            if(dtpFaturaTarih.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş Döneme Ait Bir Fatura Ödemesi Yapılamaz!");
                connection.Close();
                verileriGosterFatura();
                //goto Liste;
            }

            if (nmrDogalgaz.Text == "0" && nmrElektrik.Text == "0" && nmrSu.Text == "0" || nmrInternet.Text=="0")
            {
                MessageBox.Show("Doğalgaz, Elektrik, Su veya İnternet Tutarı alanlarından en az birine veri girişi yapmalısınız!");
                connection.Close();
                verileriGosterFatura();
            }

            else
            {
                string saat = DateTime.Now.ToShortTimeString();
                string tarih = dtpFaturaTarih.Value.ToShortDateString();

                SqlCommand komut1 = new SqlCommand("Insert Into Faturalar(Dogalgaz, Elektrik, Su, Internet Tarih, Saat) VALUES ('" + nmrDogalgaz.Text + "','" + nmrElektrik.Text + "','" + nmrSu.Text + "','" + nmrInternet.Text + "','" + tarih + "','" + saat + "')", connection);
                komut1.ExecuteNonQuery();       

                connection.Close();
                verileriGosterFatura();
                MessageBox.Show("Fatura Girişi Kaydı Başarıyla Tamamlandı.");
                nmrDogalgaz.Value = 0;
                nmrElektrik.Value = 0;
                nmrSu.Value = 0;
            }
        }
    }
}
