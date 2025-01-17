using System;
using System.Windows.Forms;

namespace nissAIR_Uygulaması
{
    /// <summary>
    /// Ekstra bagaj hakkı seçimi ve ücretlendirme formu
    /// </summary>
    public partial class EkstraBagajHakki : Form
    {
        /// <summary>
        /// Seçilen ekstra bagaj ücreti
        /// </summary>
        private decimal bagajUcreti = 0;

        /// <summary>
        /// Form constructor'ı
        /// </summary>
        public EkstraBagajHakki()
        {
            InitializeComponent();
            this.FormClosing += EkstraBagajHakki_FormClosing;
            this.Load += EkstraBagajHakki_Load;
            nudFazlaBagaj.ValueChanged += NudFazlaBagaj_ValueChanged;
        }

        private void EkstraBagajHakki_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Değerleri sıfırla
            BiletAlis.KullaniciAdi = string.Empty;
            BiletAlis.KullaniciSoyadi = string.Empty;
            BiletAlis.SelectedFlightPrice = 0;
            BiletAlis.SecilenBiletTipi = string.Empty;
            
            Environment.Exit(0);
        }

        private void EkstraBagajHakki_Load(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcı adı ve soyadını kontrol et ve birleştirip göster
                if (!string.IsNullOrEmpty(BiletAlis.KullaniciAdi) && !string.IsNullOrEmpty(BiletAlis.KullaniciSoyadi))
                {
                    lblKullaniciAdi.Text = BiletAlis.KullaniciAdi + " " + BiletAlis.KullaniciSoyadi;
                }
                else
                {
                    lblKullaniciAdi.Text = "Kullanıcı bilgisi bulunamadı";
                }

                // Bilet tipine göre bagaj hakkını ayarla
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
                        lblBagajHakki.Text = "15 + 8"; // Varsayılan değer
                        break;
                }

                // Başlangıç tutarını 0 olarak göster
                lblTutar.Text = "0,00 TRY";
                
                // Toplam tutarı güncelle (koltuk seçimi sonrası fiyat)
                UpdateToplamTutar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void NudFazlaBagaj_ValueChanged(object sender, EventArgs e)
        {
            // Bagaj ücretini hesapla (her artış için 450 TL)
            bagajUcreti = nudFazlaBagaj.Value * 450;
            UpdateToplamTutar();
        }

        private void UpdateToplamTutar()
        {
            try
            {
                // Toplam tutarı hesapla (güncellenmiş bilet fiyatı + bagaj ücreti)
                decimal toplamTutar = BiletAlis.SelectedFlightPrice + bagajUcreti;
                
                // Toplam tutarı göster
                lblTutar.Text = toplamTutar.ToString("N2") + " TRY";
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