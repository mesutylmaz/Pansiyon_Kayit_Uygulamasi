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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }





        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");






        private void verileriGoster()
        {
            listView1.Items.Clear();    //Verileri Göster metotu her çağrıldığında ListView içini temizle ve sonra yükle demiş olduk.

            connection.Open();  //Bağlantımı aç
            SqlCommand command = new SqlCommand("select * from MusteriEkle", connection);       //Verileri Çek
            SqlDataReader reader = command.ExecuteReader();     //Çekilen verileri Oku

            while (reader.Read())       //Okuma işlemi yapılırken
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = reader["MusteriID"].ToString();       //PrimaryKey property, Text olarak belirtiliyor. Yani, Ana ögeyi belirtiyoruz
                liste.SubItems.Add(reader["Adi"].ToString());      //Alt ögeler SubItems.Add ile ekleniyor
                liste.SubItems.Add(reader["Soyadi"].ToString());
                liste.SubItems.Add(reader["Cinsiyet"].ToString());
                liste.SubItems.Add(reader["Telefon"].ToString());
                liste.SubItems.Add(reader["Mail"].ToString());
                liste.SubItems.Add(reader["TC"].ToString());
                liste.SubItems.Add(reader["OdaNo"].ToString());
                liste.SubItems.Add(reader["Ucret"].ToString());
                liste.SubItems.Add(reader["GirisTarihi"].ToString());
                liste.SubItems.Add(reader["CikisTarihi"].ToString());

                listView1.Items.Add(liste);
            }
            connection.Close();     //Bağlantıyı kapat
        }





        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }







        int id = 0;



        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);        //Seçilen nesnenin ilk değerine göre(SelectedItems[0]), İlk hücreyi al(SubItems[0].Text)
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;  //Seçilen nesnenin ilk değerine göre(SelectedItems[0]), İkinci hücreyi al(SubItems[1].Text)
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtOdaUcreti.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }






        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();  //Bağlantımı aç
            //SqlCommand command = new SqlCommand("Delete * from MusteriEkle where MusteriID=("+id+")", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil

            if (txtOdaNo.Text == "101")
            {
                SqlCommand command = new SqlCommand("Delete from Oda101", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "102")
            {
                SqlCommand command = new SqlCommand("Delete from Oda102", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "103")
            {
                SqlCommand command = new SqlCommand("Delete from Oda103", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "104")
            {
                SqlCommand command = new SqlCommand("Delete from Oda104", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "105")
            {
                SqlCommand command = new SqlCommand("Delete from Oda105", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "106")
            {
                SqlCommand command = new SqlCommand("Delete from Oda106", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "107")
            {
                SqlCommand command = new SqlCommand("Delete from Oda107", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "108")
            {
                SqlCommand command = new SqlCommand("Delete from Oda108", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }
            if (txtOdaNo.Text == "109")
            {
                SqlCommand command = new SqlCommand("Delete from Oda109", connection);       //Silinecek Verileri Seçilen ID'ye göre çek ve sil
                command.ExecuteNonQuery();
                FormuTemizle();
                connection.Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
                verileriGoster();
            }



        }




        private void FormuTemizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            mskTxtTelefon.Clear();
            txtTcNo.Clear();
            txtOdaUcreti.Clear();
            txtMail.Text = "";
            txtOdaNo.Clear();
            dtGirisTarihi.Text = DateTime.Now.ToShortDateString();
            dtCikisTarihi.Text = DateTime.Now.ToShortDateString();
        }





        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }








        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();  //Bağlantımı aç
            SqlCommand command = new SqlCommand("Update MusteriEkle set Adi='" + txtAdi.Text + "', Soyadi='" + txtSoyadi.Text + "', Cinsiyet='" + cmbCinsiyet.Text + "', Telefon='" + mskTxtTelefon.Text + "', Mail='" + txtMail.Text + "', TC='" + txtTcNo.Text + "', OdaNo='" + txtOdaNo.Text + "', Ucret='" + txtOdaUcreti.Text + "', GirisTarihi='" + dtGirisTarihi.Value.ToString("yyyy-MM-dd") + "', CikisTarihi='" + dtCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where MusteriID= (" + id + ") ", connection);       //Güncellenecek Verileri Seçilen ID'ye göre çekecek, formda alanları değiştirdikten sonra butona basarak verileri güncelleyecek.
            command.ExecuteNonQuery();
            FormuTemizle();
            connection.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleştirildi.");
            verileriGoster();
        }











        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            connection.Open();
            SqlCommand command = new SqlCommand("select * from MusteriEkle where Adi like '%" + txtAra.Text + "%'    ", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = reader["MusteriID"].ToString();       //PrimaryKey property, Text olarak belirtiliyor. Yani, Ana ögeyi belirtiyoruz
                liste.SubItems.Add(reader["Adi"].ToString());      //Alt ögeler SubItems.Add ile ekleniyor
                liste.SubItems.Add(reader["Soyadi"].ToString());
                liste.SubItems.Add(reader["Cinsiyet"].ToString());
                liste.SubItems.Add(reader["Telefon"].ToString());
                liste.SubItems.Add(reader["Mail"].ToString());
                liste.SubItems.Add(reader["TC"].ToString());
                liste.SubItems.Add(reader["OdaNo"].ToString());
                liste.SubItems.Add(reader["Ucret"].ToString());
                liste.SubItems.Add(reader["GirisTarihi"].ToString());
                liste.SubItems.Add(reader["CikisTarihi"].ToString());

                listView1.Items.Add(liste);
            }
            connection.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
