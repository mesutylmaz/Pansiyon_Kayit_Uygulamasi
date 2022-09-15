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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }




        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");




        private void frmOdalar_Load(object sender, EventArgs e)
        {
            //connection.Open();
            //SqlCommand komut11 = new SqlCommand("Select * from MusteriEkle", connection);
            //SqlDataReader oku11 = komut11.ExecuteReader();

            //while (oku11.Read())
            //{
            //    DateTime bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            //    foreach (var item in oku11)
            //    {
            //        DateTime cikisTarih = Convert.ToDateTime(oku11["CikisTarihi"]);

            //        TimeSpan sonuc = cikisTarih - bugun;       //TimeSpan iki tarih arası farkı hesaplar
            //        int gunSayisi = (int)sonuc.TotalDays;      //TotalDays toplam gün sayısını verir.

            //        connection.Close();






            //        //Oda 101
            //        connection.Open();
            //        SqlCommand komut1 = new SqlCommand("Select * from Oda101", connection);
            //        SqlDataReader oku1 = komut1.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku1.Read())
            //            {
            //                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn101.BackColor = Color.Red;
            //                btn101.Enabled = false;
            //            }
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda101", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            SqlDataReader read = command.ExecuteReader();

            //            while (read.Read())
            //            {
            //                btn101.Text = "101";
            //                btn101.BackColor = Color.DodgerBlue;
            //                btn101.Enabled = true;
            //                MessageBox.Show("101 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            }
            //        }
            //        connection.Close();








            //        //Oda 102
            //        connection.Open();
            //        SqlCommand komut2 = new SqlCommand("Select * from Oda102", connection);
            //        SqlDataReader oku2 = komut2.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku2.Read())
            //            {
            //                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn102.BackColor = Color.Red;
            //                btn102.Enabled = false;
            //            }
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda102", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            SqlDataReader read = command.ExecuteReader();

            //            while (read.Read())
            //            {
            //                btn102.Text = "102";
            //                btn102.BackColor = Color.DodgerBlue;
            //                btn102.Enabled = true;
            //                MessageBox.Show("102 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            }
            //        }
            //        connection.Close();








            //        //Oda 103
            //        connection.Open();
            //        SqlCommand komut3 = new SqlCommand("Select * from Oda103", connection);
            //        SqlDataReader oku3 = komut3.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku3.Read())
            //            {
            //                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn103.BackColor = Color.Red;
            //            }
            //            komut3.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda103", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn103.Text = "103";
            //            btn103.BackColor = Color.DodgerBlue;
            //            btn103.Enabled = true;
            //            MessageBox.Show("103 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }













            //        //Oda 104
            //        connection.Open();
            //        SqlCommand komut4 = new SqlCommand("Select * from Oda104", connection);
            //        SqlDataReader oku4 = komut4.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku4.Read())
            //            {
            //                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn104.BackColor = Color.Red;
            //            }
            //            komut4.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda104", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn104.Text = "104";
            //            btn104.BackColor = Color.DodgerBlue;
            //            btn104.Enabled = true;
            //            MessageBox.Show("104 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }










            //        //Oda 105
            //        connection.Open();
            //        SqlCommand komut5 = new SqlCommand("Select * from Oda105", connection);
            //        SqlDataReader oku5 = komut5.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku5.Read())
            //            {
            //                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn105.BackColor = Color.Red;
            //            }
            //            komut5.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda105", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn105.Text = "105";
            //            btn105.BackColor = Color.DodgerBlue;
            //            btn105.Enabled = true;
            //            MessageBox.Show("105 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }













            //        //Oda 106
            //        connection.Open();
            //        SqlCommand komut6 = new SqlCommand("Select * from Oda106", connection);
            //        SqlDataReader oku6 = komut6.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku6.Read())
            //            {
            //                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn106.BackColor = Color.Red;
            //            }
            //            komut6.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda106", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn106.Text = "106";
            //            btn106.BackColor = Color.DodgerBlue;
            //            btn106.Enabled = true;
            //            MessageBox.Show("106 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }












            //        //Oda 107
            //        connection.Open();
            //        SqlCommand komut7 = new SqlCommand("Select * from Oda107", connection);
            //        SqlDataReader oku7 = komut7.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku7.Read())
            //            {
            //                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn107.BackColor = Color.Red;
            //            }
            //            komut7.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda107", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn107.Text = "107";
            //            btn107.BackColor = Color.DodgerBlue;
            //            btn107.Enabled = true;
            //            MessageBox.Show("107 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }












            //        //Oda 108
            //        connection.Open();
            //        SqlCommand komut8 = new SqlCommand("Select * from Oda108", connection);
            //        SqlDataReader oku8 = komut8.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku8.Read())
            //            {
            //                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn108.BackColor = Color.Red;
            //            }
            //            komut8.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda108", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn108.Text = "108";
            //            btn108.BackColor = Color.DodgerBlue;
            //            btn108.Enabled = true;
            //            MessageBox.Show("108 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }










            //        //Oda 109
            //        connection.Open();
            //        SqlCommand komut9 = new SqlCommand("Select * from Oda109", connection);
            //        SqlDataReader oku9 = komut9.ExecuteReader();

            //        if (gunSayisi >= 0)
            //        {
            //            while (oku9.Read())
            //            {
            //                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();      //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            //                btn109.BackColor = Color.Red;
            //            }
            //            komut9.ExecuteNonQuery();
            //            connection.Close();

            //            //if (btn101.Text != "101")
            //            //{
            //            //    btn101.BackColor = Color.Red;
            //            //}
            //        }
            //        if (gunSayisi < 0)
            //        {
            //            SqlCommand command = new SqlCommand("Delete from Oda109", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
            //            command.ExecuteNonQuery();
            //            btn109.Text = "109";
            //            btn109.BackColor = Color.DodgerBlue;
            //            btn109.Enabled = true;
            //            MessageBox.Show("109 numaralı odadaki Müşterinin Rezervasyon süresi dolduğu için oda revize edilebilir duruma getirildi.");
            //            connection.Close();
            //        }
            //   }
            //    komut11.ExecuteNonQuery();
            //    connection.Close();
            //}
            //connection.Close();


            //Oda 101
            connection.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Oda101", connection);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
                btn101.BackColor = Color.Red;
            }

            connection.Close();

            //if (btn102.Text != "102")
            //{
            //    btn102.BackColor = Color.Red;
            //}





            //Oda 102
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Oda102", connection);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
                btn102.BackColor = Color.Red;
            }

            connection.Close();

            //if (btn102.Text != "102")
            //{
            //    btn102.BackColor = Color.Red;
            //}



            //Oda 103
            connection.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Oda103", connection);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
            }



            //Oda 104
            connection.Open();
            SqlCommand komut4 = new SqlCommand("Select * from Oda104", connection);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
            }



            //Oda 105
            connection.Open();
            SqlCommand komut5 = new SqlCommand("Select * from Oda105", connection);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn105.Text != "105")
            {
                btn105.BackColor = Color.Red;
            }



            //Oda 106
            connection.Open();
            SqlCommand komut6 = new SqlCommand("Select * from Oda106", connection);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn106.Text != "106")
            {
                btn106.BackColor = Color.Red;
            }



            //Oda 107
            connection.Open();
            SqlCommand komut7 = new SqlCommand("Select * from Oda107", connection);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn107.Text != "107")
            {
                btn107.BackColor = Color.Red;
            }



            //Oda 108
            connection.Open();
            SqlCommand komut8 = new SqlCommand("Select * from Oda108", connection);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn108.Text != "108")
            {
                btn108.BackColor = Color.Red;
            }



            //Oda 109
            connection.Open();
            SqlCommand komut9 = new SqlCommand("Select * from Oda109", connection);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn109.Text != "109")
            {
                btn109.BackColor = Color.Red;
            }
        }
    }
}
