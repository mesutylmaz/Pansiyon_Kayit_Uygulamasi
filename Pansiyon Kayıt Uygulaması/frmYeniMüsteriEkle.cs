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

        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";

            //connection.Open();
            //SqlCommand komut = new SqlCommand("Insert into Oda101 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
            //komut.ExecuteNonQuery();
            //connection.Close();

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
            

            if(txtAdi.Text == "" || txtSoyadi.Text == "" || txtOdaNo.Text=="")
            {
                MessageBox.Show("Ad, Soyad veya Oda Numarası alanları boş bırakılamaz!");
                connection.Close();
            }
            else
            {
                string numara = txtOdaNo.Text;
                switch (numara)
                {
                    case "101":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda101 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "102":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda102 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "103":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda103 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "104":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda104 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "105":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda105 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "106":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda106 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "107":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda107 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "108":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda108 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    case "109":
                        {
                            SqlCommand komut1 = new SqlCommand("Insert Into MusteriEkle(Adi, Soyadi, Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)                                                                                                  VALUES ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"
                                               + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtTcNo.Text + "','"
                                               + txtOdaNo.Text + "','" + txtOdaUcreti.Text + "','" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", connection);
                            komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            SqlCommand komut2 = new SqlCommand("Insert into Oda109 (Adi, Soyadi) Values ('" + txtAdi.Text + " ',' " + txtSoyadi.Text + "')", connection);
                            komut2.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar


                            connection.Close();
                            MessageBox.Show("Müşteri Kaydı Başarıyla Tamamlandı.");
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Hatalı bir işlem gerçekleştirdiniz!");
                            break;
                        }
                }
            }
        }











        private void frmYeniMüsteriEkle_Load(object sender, EventArgs e)
        {
            //Oda 101
            connection.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Oda101", connection);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
                btn101.Text = "Dolu";
                btn101.Enabled = false;
            }



            //Oda 102
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Oda102", connection);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();       //Oda101'den çekilen komut1'in değerlerini Oku(oku1) ve okuduğun değerlerden, Adi Soyadi ifadesini butona yaz.
            }

            connection.Close();

            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
                btn102.Text = "Dolu";
                btn102.Enabled = false;
            }



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
                btn103.Text = "Dolu";
                btn103.Enabled = false;
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
                btn104.Text = "Dolu";
                btn104.Enabled = false;
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
                btn105.Text = "Dolu";
                btn105.Enabled = false;
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
                btn106.Text = "Dolu";
                btn106.Enabled = false;
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
                btn107.Text = "Dolu";
                btn107.Enabled = false;
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
                btn108.Text = "Dolu";
                btn108.Enabled = false;
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
                btn109.Text = "Dolu";
                btn109.Enabled = false;
            }
        }
    }
}
