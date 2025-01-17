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
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            KullaniciGiris kg = new KullaniciGiris();
            kg.Show();
            this.Hide();
        }

        private void btnAdminGirisi_Click(object sender, EventArgs e)
        {
            AdminGiris admin = new AdminGiris();
            admin.Show();
            this.Hide();
        }

        private void btnkayitOl_Click(object sender, EventArgs e)
        {
            KayitEkrani k = new KayitEkrani();
            k.Show();
            this.Hide();
        }
    }
}
