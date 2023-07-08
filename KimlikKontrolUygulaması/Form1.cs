using System;
using System.Windows.Forms;

namespace KimlikKontrolUygulaması
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
          KimlikKontrol();
        }

        void KimlikKontrol()
        {
            long TCKN = byte.Parse(tctxt.Text);
            string Ad, Soyad;
            Ad = adtxt.Text;
            Soyad = soyadtxt.Text;
            int DY = dgtxt.Value.Year;
            KimlikBilgileri.KPSPublicSoapClient KK = new KimlikBilgileri.KPSPublicSoapClient();
            bool Durum = KK.TCKimlikNoDogrula(TCKN, Ad, Soyad, DY);
            if (Durum == true)
            {
                MessageBox.Show("Girilen Kimlik Bilgileri Doğrulandı.", "Geçerli Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Durum != true)
            {
                MessageBox.Show("Girilen Kimlik Bilgileri Yanlış.", "Geçersiz Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
