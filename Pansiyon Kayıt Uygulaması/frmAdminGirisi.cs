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
    public partial class frmAdminGirisi : Form
    {
        public frmAdminGirisi()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");


        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //if(txtKullaniciAdi.Text== "test@test.com" && txtSifre.Text == "123")
            //{
            //    frmAnaForm giris = new frmAnaForm();
            //    giris.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı Adı veya Şifresi Hatalı !!!");
            //}


            try
            {
                connection.Open();
                string sql = "Select * From Admin Where KullaniciAdi=@Kullanici AND KullaniciSifresi = @Sifresi";
                SqlParameter parameter1 = new SqlParameter("Kullanici", txtKullaniciAdi.Text);
                SqlParameter parameter2 = new SqlParameter("Sifresi", txtSifre.Text);

                SqlCommand komut = new SqlCommand(sql, connection);
                komut.Parameters.Add(parameter1);
                komut.Parameters.Add(parameter2);

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(komut);

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmAnaForm ana = new frmAnaForm();
                    ana.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifresi Hatalı !!!");
            }

        }





        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSifreUnuttum_Click(object sender, EventArgs e)
        {
            frmSifreGuncelle sifre = new frmSifreGuncelle();
            sifre.Show();
            this.Close();
        }
    }
}
