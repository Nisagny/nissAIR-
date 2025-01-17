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
  
   
    public partial class AdminGiris : Form
    {
       
        public AdminGiris()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);
        }

       
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AcilisEkrani ae = new AcilisEkrani();
            ae.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sabitKullaniciAdi = "1"; 
            string sabitSifre = "1"; 

            string girilenKullaniciAdi = txtKullaniciAdi.Text;
            string girilenSifre = txtSifre.Text;

            if (string.IsNullOrEmpty(girilenKullaniciAdi) || string.IsNullOrEmpty(girilenSifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (girilenKullaniciAdi == sabitKullaniciAdi && girilenSifre == sabitSifre)
            {
                MessageBox.Show("Admin giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                AdminAnasayfa adminPanel = new AdminAnasayfa();
                this.Hide();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
