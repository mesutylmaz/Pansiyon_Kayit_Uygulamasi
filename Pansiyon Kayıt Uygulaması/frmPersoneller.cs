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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }



        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");




        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();


            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtMaasi.Text == "")
            {
                MessageBox.Show("Ad, Soyad veya Maaş alanları boş bırakılamaz!");
                connection.Close();
            }

            else
            {
                SqlCommand komut = new SqlCommand("Insert into Personel (PersonelAdi, PersonelSoyadi, Maas) Values ('   "+ txtAdi.Text +" ',' "+ txtSoyadi.Text + "  ',' "+ txtMaasi.Text +" ')", connection);
                komut.ExecuteNonQuery();       


                connection.Close();
                MessageBox.Show("Personel Kaydı Başarıyla Tamamlandı.");
            }
        }
    }
}
