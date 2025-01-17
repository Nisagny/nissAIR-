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
    public partial class EkstraBagajHakki : Form
    {
        private decimal bagajUcreti = 0;

        public EkstraBagajHakki()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);            
            nudFazlaBagaj.ValueChanged += NudFazlaBagaj_ValueChanged;
        }

        private void EkstraBagajHakki_Load(object sender, EventArgs e)
        {
            
            lblYolcu.Text = BiletAlis.KullaniciAdi;

          
            switch (BiletAlis.SecilenBiletTipi?.ToLower())
            {
                case "basic":
                    lblBagajHakki.Text = "15 + 8";
                    break;
                case "flex":
                    lblBagajHakki.Text = "20 + 10";
                    break;
                case "premium":
                    lblBagajHakki.Text = "25 + 10";
                    break;
                default:
                    lblBagajHakki.Text = "15 + 8"; 
                    break;
            }

          
            lblTutar.Text = "0,00 TRY";
            UpdateToplamTutar();
        }

        private void NudFazlaBagaj_ValueChanged(object sender, EventArgs e)
        {
            
            bagajUcreti = nudFazlaBagaj.Value * 250;
            lblTutar.Text = bagajUcreti.ToString("N2") + " TRY";
            UpdateToplamTutar();
        }

        private void UpdateToplamTutar()
        {
            try
            {
                
                decimal bagajUcreti = decimal.Parse(lblTutar.Text.Replace(" TRY", ""));

                decimal toplamTutar = BiletAlis.SelectedFlightPrice + bagajUcreti;

                lblToplamTutar.Text = toplamTutar.ToString("N2") + " TRY";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat hesaplanırken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            BiletSonKontrol biletSonKontrol = new BiletSonKontrol();
            biletSonKontrol.Show();
            this.Hide();
        }

        
    }
}