using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text== "test@test.com" && txtSifre.Text == "123")
            {
                frmAnaForm giris = new frmAnaForm();
                giris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifresi Hatalı !!!");
            }
        }
    }
}
