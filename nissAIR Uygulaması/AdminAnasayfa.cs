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
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);
        }

        private void btnUcuslar_Click(object sender, EventArgs e)
        {
            UcusTanimlama ut = new UcusTanimlama();
            ut.Show();
            this.Hide();
        }

        private void btnUcaklar_Click(object sender, EventArgs e)
        {
            UcakTanimla ucak = new UcakTanimla();
            ucak.Show();
            this.Hide();
        }
    }
}
