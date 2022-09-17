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
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }





        //SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");




        PersonelEntities personel = new PersonelEntities();




        private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personel.Personels.ToList();

            //Satırlardaki hücrelere tıklandığında düzenlebilir olmaması için;
            dataGridView1.Columns["PersonelID"].ReadOnly = true;
            dataGridView1.Columns["PersonelAdi"].ReadOnly = true;
            dataGridView1.Columns["PersonelSoyadi"].ReadOnly = true;
            dataGridView1.Columns["Maas"].ReadOnly = true;


            //Yorumlardaki Kodların tümü Form'da DataGrid yerine ListBox kullanılsa geçerli ve çalışan kodlardır.

            //listBox1.Items.Clear();

            //connection.Open();
            ////SqlCommand komut1 = new SqlCommand("Select * from Personel", connection);
            ////SqlDataReader oku1 = komut1.ExecuteReader();

            //SqlDataAdapter adapter = new SqlDataAdapter("Select * from Personel", connection);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //this.listBox1.HorizontalScrollbar = true;
            //this.listBox1.ColumnWidth = 185;

            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    listBox1.Items.Add(table.Rows[i][1] + "          " + table.Rows[i][2] + "          " + table.Rows[i][3] + "          ");
            //}

            //connection.Close();
        }








        




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "" && txtSoyadi.Text != "" && nmrMaas.Value >= 5500)
            {
                Personel kisi = new Personel();
                kisi.PersonelAdi = txtAdi.Text;
                kisi.PersonelSoyadi = txtSoyadi.Text;
                kisi.Maas = nmrMaas.Value.ToString();

                personel.Personels.Add(kisi);

                KaydetTemizleListele();
            }
            if (txtAdi.Text != "" && txtSoyadi.Text != "")
            {
                if (nmrMaas.Value < 5500)
                {
                    MessageBox.Show("Personel Maaşı en az 5500 ₺ girilmelidir!");
                }
            }
            else if (txtAdi.Text == "" || txtSoyadi.Text == "")
            {
                MessageBox.Show("Personel Adı veya Soyadı boş bırakılamaz!");
            }
        }











        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }












        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }









        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            nmrMaas.Value = 0;
        }







        private void KaydetTemizleListele()
        {
            personel.SaveChanges();

            MessageBox.Show("Kayıt İşlemi Başarılı.");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is NumericUpDown)
                {
                    item.Text = "0";
                }
                dataGridView1.DataSource = personel.Personels.ToList();
            }
        }








        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(txtAdi.Text != "" && txtSoyadi.Text != "" && nmrMaas.Value>=5500)
            {
                string ad = txtAdi.Text;
                string soyad = txtSoyadi.Text;


                string ad2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string soyad2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                var guncelle = personel.Personels.Where(x => x.PersonelAdi == ad2 && x.PersonelSoyadi == soyad2).FirstOrDefault();


                guncelle.PersonelAdi = txtAdi.Text;
                guncelle.PersonelSoyadi = txtSoyadi.Text;
                guncelle.Maas = nmrMaas.Value.ToString();

                KaydetTemizleListele();
            }
            if (txtAdi.Text != "" && txtSoyadi.Text != "")
            {
                if(nmrMaas.Value < 5500)
                {
                    MessageBox.Show("Personel Maaşı en az 5500 ₺ girilmelidir!");
                }
            }
            else if(txtAdi.Text == "" || txtSoyadi.Text == "")
            {
                MessageBox.Show("Personel Adı veya Soyadı boş bırakılamaz!");
            }
        }










        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nmrMaas.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value);
        }











        private void btnSil_Click(object sender, EventArgs e)
        {
            string ad = txtAdi.Text;
            string soyad = txtSoyadi.Text;

            
            string ad2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyad2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            var sil = personel.Personels.Where(x => x.PersonelAdi == ad2 && x.PersonelSoyadi==soyad2).FirstOrDefault();

            personel.Personels.Remove(sil);

            KaydetTemizleListele();
        }
    }
}
