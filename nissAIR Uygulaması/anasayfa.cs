using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nissAIR_Uygulaması
{
    
    public partial class anasayfa : Form
    {
       
        public static string KullaniciAdiSoyadi { get; set; }
        public static int KullaniciID { get; set; }

        
        public anasayfa()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);

        }
        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connStr);




        private void btnUcusAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbNereden.Text) || string.IsNullOrWhiteSpace(cmbNereye.Text))
            {
                MessageBox.Show("Lütfen 'Nereden' ve 'Nereye' alanlarını doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbNereden.Text == cmbNereye.Text)
            {
                MessageBox.Show("Aynı il içerisinde uçuş gerçekleştiremezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //gerekli formlarda bu isimlerde property oluşturdum ve onlara bu değerleri gönderiyorum.
                BiletAlis.KalkisYeri = cmbNereden.Text;
                BiletAlis.VarisYeri = cmbNereye.Text;
                BiletAlis.UcusTarihi = DateTime.Parse(dtpGidisTarihi.Text);

                Ucuslar ucuslarForm = new Ucuslar();
                ucuslarForm.ArrivalAirport = cmbNereye.Text;
                ucuslarForm.DepartureAirport = cmbNereden.Text;
                ucuslarForm.SelectedDate = DateTime.Parse(dtpGidisTarihi.Text).Date;
                ucuslarForm.Show();
                this.Hide();
            }
        }
    

        

        private void tstxtCheckIn_Click(object sender, EventArgs e)
        {

            CheckIn checkIn = new CheckIn();
            checkIn.Show();
            this.Hide();

        }

        private void btnGidisDonus_Click(object sender, EventArgs e)
        {
            anasayfaGD gd = new anasayfaGD();
            gd.Show();
            this.Hide();
        }



        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Çıkış yapmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                KullaniciGiris kullaniciGiris = new KullaniciGiris();
                kullaniciGiris.Show();
                this.Hide();
            }
            else { }


        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(KullaniciAdiSoyadi))
                {
                    tsmiKullanici.Text = KullaniciAdiSoyadi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı bilgisi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void uçuşlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciUcuslari ucuslar = new KullaniciUcuslari();
            ucuslar.Show();
            this.Hide();
        }
    }
}
