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
    public partial class MessageBoxBilet2 : Form
    {
        public MessageBoxBilet2()
        {
            InitializeComponent();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            BiletAlis.SelectedFlightPrice += 750;
            BiletAlis biletAlis = new BiletAlis();
            biletAlis.Show();
            this.Hide();
        }

        private void btnFlex_Click(object sender, EventArgs e)
        {
            BiletAlis biletAlis = new BiletAlis();
            biletAlis.Show();
            this.Hide();
        }
    }
}
