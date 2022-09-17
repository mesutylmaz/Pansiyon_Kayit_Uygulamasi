using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pansiyon_Kayıt_Uygulaması
{
    public partial class frmHavaDurumu : Form
    {
        public frmHavaDurumu()
        {
            InitializeComponent();
        }



        private const string api = "629cfbed55d985e200c00a2219649794";

        private const string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=Turkey,Istanbul&mode=xml&units=metric&APPID=" + api;



        private void frmHavaDurumu_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;


            XDocument hava = XDocument.Load(baglanti);

            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            lblDerece.Text = sicaklik.ToString() + "°";

            var durum = hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            lblDurum.Text = durum.ToString();

            var sehir = hava.Descendants("city").ElementAt(0).Attribute("name").Value;
            lblSehir.Text = sehir.ToString();


            if (durum.Contains("clouds"))
            {
                pictureBox1.Visible = true;
            }


            if (durum.Contains("sun") || durum.Contains("clear sky"))
            {
                pictureBox2.Visible = true;
            }


            if (durum.Contains("rainy"))
            {
                pictureBox3.Visible = true;
            }
        }
    }
}
