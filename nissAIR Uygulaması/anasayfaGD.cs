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
    public partial class anasayfaGD : Form
    {
        public anasayfaGD()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);
        }

        private void btnTekYön_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            checkIn.Show();
            this.Hide();
        }

        private void btnUcusAra_Click(object sender, EventArgs e)
        {
            Ucuslar ucuslar = new Ucuslar();
            ucuslar.Show();
            this.Hide();
        }
    }
}
