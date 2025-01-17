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
    public partial class BiletSecenek : Form
    {
        public BiletSecenek()
        {
            InitializeComponent();
        }

        

       

       

        private void btnBasic_Click(object sender, EventArgs e)
        {
            BiletAlis.SecilenBiletTipi = "Basic";
            MessageBoxBilet secenek = new MessageBoxBilet();
            secenek.Show();
            this.Hide();
        }

        private void btnFlex_Click(object sender, EventArgs e)
        {
            BiletAlis.SecilenBiletTipi = "Flex";
            BiletAlis.SelectedFlightPrice += 250;
            MessageBoxBilet2 secenek = new MessageBoxBilet2();
            secenek.Show();
            this.Hide();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            BiletAlis.SecilenBiletTipi = "Premium";
            BiletAlis.SelectedFlightPrice += 750;
            BiletAlis biletAlis = new BiletAlis();
            biletAlis.Show();
            this.Hide();
        }
    }
}
