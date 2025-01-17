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
    
    public partial class BiletSonKontrol : Form
    {
        public BiletSonKontrol()
        {
            InitializeComponent();
            this.Load += BiletSonKontrol_Load;
        }

        private void BiletSonKontrol_Load(object sender, EventArgs e)
        {
            try
            {
                lblTarih.Text = BiletAlis.UcusTarihi.ToString("dd.MM.yyyy");

              
                lblKalkisYeri.Text = BiletAlis.KalkisYeri;
                lblVarisYeri.Text = BiletAlis.VarisYeri;

               
                lblKalkisSaat.Text = BiletAlis.KalkisSaati;
                lblVarisSaat.Text = BiletAlis.VarisSaati;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

      

        private void btnDevam_Click(object sender, EventArgs e)
        {
            OdemeEkrani odeme = new OdemeEkrani();
            odeme.Show();
            this.Hide();
        }
    }
}
