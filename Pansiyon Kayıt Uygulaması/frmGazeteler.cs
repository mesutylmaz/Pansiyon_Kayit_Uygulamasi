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
    public partial class frmGazeteler : Form
    {
        public frmGazeteler()
        {
            InitializeComponent();
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void btnPosta_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.posta.com.tr/");
        }

        private void btnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
        }

        private void btnFanatik_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void btnCumhuriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cumhuriyet.com.tr/");
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milligazete.com.tr");
        }

        private void btnFotomac_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://egazete.fotomac.com.tr/");
        }

        private void btnAksam_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.aksam.com.tr");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
