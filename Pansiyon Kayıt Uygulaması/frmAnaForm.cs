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
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        frmAdminGirisi admin;
        frmGazeteler gazete;
        frmGelirGider gelirgider;
        frmMasraflar masraf;
        frmMesaj mesaj;
        frmMusteriler musteri;
        frmOdalar oda;
        frmRadyoDinle radyo;
        frmYeniMüsteriEkle yenimusteri;
        frmPersonelListesi personel;

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            if(admin==null || admin.IsDisposed){
                admin = new frmAdminGirisi();
                admin.Show();
            }
            else {
                MessageBox.Show("Giriş Sayfası Zaten Açık!");
            }

            //frmAdminGirisi fr = new frmAdminGirisi();
            //fr.Show();
            //btnAdminGiris.Enabled = false;
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            if (yenimusteri == null || yenimusteri.IsDisposed)
            {
                yenimusteri = new frmYeniMüsteriEkle();
                yenimusteri.Show();
            }
            else
            {
                MessageBox.Show("Yeni Müşteri Sayfası Zaten Açık!");
            }
            //frmYeniMüsteriEkle fr = new frmYeniMüsteriEkle();
            //fr.Show();
            //// this.Hide();
            //btnYeniMusteri.Enabled = false;

        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            if (oda == null || oda.IsDisposed)
            {
                oda = new frmOdalar();
                oda.Show();
            }
            else
            {
                MessageBox.Show("Odalar Sayfası Zaten Açık!");
            }
            //frmOdalar fr = new frmOdalar();
            //fr.Show();
            ////this.Hide();
            //btnOdalar.Enabled = false;
        }



        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new frmMusteriler();
                musteri.Show();
            }
            else
            {
                MessageBox.Show("Müşteriler Sayfası Zaten Açık!");
            }
            //frmMusteriler fr = new frmMusteriler();
            //fr.Show();
            ////this.Hide();
            //btnMusteriler.Enabled = false;
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansiyon Kayıt Uygulaması - " + DateTime.Now.Year);
        }



        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnGelirGiderFormu_Click(object sender, EventArgs e)
        {
            if (gelirgider == null || gelirgider.IsDisposed)
            {
                gelirgider = new frmGelirGider();
                gelirgider.Show();
            }
            else
            {
                MessageBox.Show("Yeni Müşteri Sayfası Zaten Açık!");
            }
            //frmGelirGider gelirGider = new frmGelirGider();
            //gelirGider.Show();
            //btnGelirGiderFormu.Enabled = false;
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            if (masraf == null || masraf.IsDisposed)
            {
                masraf = new frmMasraflar();
                masraf.Show();
            }
            else
            {
                MessageBox.Show("Masraflar Sayfası Zaten Açık!");
            }
            //frmMasraflar stok = new frmMasraflar();
            //stok.Show();
            //btnStoklar.Enabled = false;
        }

        private void btnRadyoDinle_Click(object sender, EventArgs e)
        {
            if (radyo == null || radyo.IsDisposed)
            {
                radyo = new frmRadyoDinle();
                radyo.Show();
            }
            else
            {
                MessageBox.Show("Radyo Dinleme Sayfası Zaten Açık!");
            }
            //frmRadyoDinle radyo = new frmRadyoDinle();
            //radyo.Show();
            //btnRadyoDinle.Enabled = false;
        }

        private void btnGazeteler_Click(object sender, EventArgs e)
        {
            if (gazete == null || gazete.IsDisposed)
            {
                gazete = new frmGazeteler();
                gazete.Show();
            }
            else
            {
                MessageBox.Show("Gazeteler Sayfası Zaten Açık!");
            }
            //frmGazeteler gazete = new frmGazeteler();
            //gazete.Show();
            //btnGazeteler.Enabled = false;
        }

        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            if (mesaj == null || mesaj.IsDisposed)
            {
                mesaj = new frmMesaj();
                mesaj.Show();
            }
            else
            {
                MessageBox.Show("Mesaj Sayfası Zaten Açık!");
            }
            //frmMesaj mesaj = new frmMesaj();
            //mesaj.Show();
            //btnMesajlar.Enabled = false;
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            if (personel == null || personel.IsDisposed)
            {
                personel = new frmPersonelListesi();
                personel.Show();
            }
            else
            {
                MessageBox.Show("Personel Listesi Sayfası Zaten Açık!");
            }
        }
    }
}
