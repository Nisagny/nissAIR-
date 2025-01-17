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
    public partial class MessageBoxBilet : Form
    {
        public MessageBoxBilet()
        {
            InitializeComponent();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            BiletAlis biletAlis = new BiletAlis();
            biletAlis.Show();
            this.Hide();
        }

        private void btnFlex_Click(object sender, EventArgs e)
        {
            BiletAlis.SelectedFlightPrice += 250;
            BiletAlis biletAlis = new BiletAlis();
            biletAlis.Show();
            this.Hide();
        }
    }
}
