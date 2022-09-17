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
    public partial class frmSifreGuncelle : Form
    {
        public frmSifreGuncelle()
        {
            InitializeComponent();
        }




        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-ODV8LDJ; Initial Catalog = PansiyonUygulaması; Integrated Security = True");



        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "Select * From Admin Where KullaniciAdi=@Kullanici";
            SqlParameter parameter = new SqlParameter("Kullanici", txtKullaniciAdi.Text);

            SqlCommand komut = new SqlCommand(sql, connection);
            komut.Parameters.Add(parameter);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(komut);

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if(txtYeniSifre.Text == txtSifreOnay.Text)
                {
                    SqlCommand command = new SqlCommand("   Update Admin set KullaniciSifresi= '" + txtYeniSifre.Text + "'   ", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Şifre Kaydı İşlemi Başarıyla Gerçekleştirildi.");

                    frmAdminGirisi giris = new frmAdminGirisi();
                    giris.Show();
                    this.Close();
                }
                else if(txtYeniSifre.Text != txtSifreOnay.Text)
                {
                    MessageBox.Show("Şifreler Birbiriyle Uyuşmuyor!");
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Hatalı Girildi!");
                connection.Close();
            }
        }
    }
}
