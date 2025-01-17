using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nissAIR_Uygulaması
{
    public partial class EkHizmetler : Form
    {
        public EkHizmetler()
        {
            InitializeComponent();
        }

        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            if (BiletAlis.KoltukSecildi)
            {
                MessageBox.Show("Koltuk seçimi daha önce yapılmıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                KoltukSecimi koltukSecimi = new KoltukSecimi(BiletAlis.SelectedFlightID);
                koltukSecimi.Show();
                this.Hide();
            }
        }

        private void btnBagaj_Click(object sender, EventArgs e)
        {
            EkstraBagajHakki ekstraBagajHakkı=new EkstraBagajHakki();
            ekstraBagajHakkı.Show();
            this.Hide();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            BiletSonKontrol biletSonKontrol = new BiletSonKontrol();
            biletSonKontrol.Show();
            this.Hide();
        }
    }
}
