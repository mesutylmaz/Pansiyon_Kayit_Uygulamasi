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
    public partial class frmMesaj : Form
    {
        public frmMesaj()
        {
            InitializeComponent();
        }



        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");


        private void frmMesaj_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void verileriGoster()
        {
            connection.Open();  
            SqlCommand command = new SqlCommand("select * from Mesaj", connection);       
            SqlDataReader reader = command.ExecuteReader();     

            while (reader.Read())       
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = reader["MesajID"].ToString();             
                liste.SubItems.Add(reader["Konu"].ToString());
                liste.SubItems.Add(reader["Mesaj"].ToString());
                liste.SubItems.Add(reader["Tarih"].ToString());
                liste.SubItems.Add(reader["Saat"].ToString());

                listView1.Items.Add(liste);
            }
            connection.Close();     //Bağlantıyı kapat
        }






        private void FormuTemizle()
        {
            txtKonu.Clear();
            rtbMesaj.Clear();
        }





        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            //SqlCommand komut = new SqlCommand("Insert into Mesaj (Konu, Mesaj, Tarih, Saat) Values ('" + txtKonu.Text + " ',' " + rtbMesaj.Text + "')", connection);

            if (txtKonu.Text == "" && rtbMesaj.Text == "")
            {
                MessageBox.Show("Konu ve Mesaj İçeriği alanları boş bırakılamaz!");
                connection.Close();
                verileriGoster();
            }
            else
            {
                string saat = DateTime.Now.ToShortTimeString();
                string tarih = DateTime.Now.ToShortDateString();

                SqlCommand komut1 = new SqlCommand("Insert Into Mesaj(Konu, Mesaj, Tarih, Saat) VALUES ('    "+ txtKonu.Text +" ',' " + rtbMesaj.Text + " ',' "+ tarih +" ',' "+ saat +"   ')", connection);
                komut1.ExecuteNonQuery();       //ExecuteNonQuery, Gönderilen verilerde yada parametrelerde düzenleme yapmayı sağlar

                connection.Close();
                verileriGoster();
                MessageBox.Show("Mesaj Kaydı Başarıyla Tamamlandı.");
                FormuTemizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKonu.Text = "";
            rtbMesaj.Text = "";
            txtKonu.Enabled = true;
            rtbMesaj.Enabled = true;
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);        
            txtKonu.Text = listView1.SelectedItems[0].SubItems[1].Text;  
            rtbMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtKonu.Enabled = false;
            rtbMesaj.Enabled = false;
        }
    }
}
