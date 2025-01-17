using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace nissAIR_Uygulaması
{
 
    public partial class BiletAlis : Form
    { 
        private readonly string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        
        #region Static Properties
        /// <summary>
        /// Kullanıcının telefon numarasını tutar
        /// </summary>
        public static string UserPhoneNumber { get; set; }
        
        /// <summary>
        /// Seçilen uçuşun ID'sini tutar
        /// </summary>
        public static int SelectedFlightID { get; set; }

        /// <summary>
        /// Seçilen uçuşun fiyatını tutar
        /// </summary>
        public static decimal SelectedFlightPrice { get; set; }
        #endregion

        
        public static bool KoltukSecildi { get; set; } = false;
        public static string SecilenBiletTipi { get; set; } 
        public static string KullaniciAdi { get; set; }
        public static string KullaniciSoyadi { get; set; }
        public static string KalkisYeri { get; set; }
        public static string VarisYeri { get; set; }
        public static DateTime UcusTarihi { get; set; }
        public static string KalkisSaati { get; set; }
        public static string VarisSaati { get; set; }

       
        public BiletAlis()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);           
            cmbUyruk.SelectedIndexChanged += CmbUyruk_SelectedIndexChanged;
        }

        private void BiletAlis_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            lblFiyat.Text = SelectedFlightPrice.ToString("N2") + " TRY";
        }

        private void LoadUserInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT userName, userSurname, userEmail, userBirthDate, userPhoneNumber FROM TblUsers WHERE userPhoneNumber = @phoneNumber";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@phoneNumber", UserPhoneNumber);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtKullaniciAdi.Text = reader["userName"].ToString();
                                KullaniciAdi = txtKullaniciAdi.Text;
                                txtKullaniciSoyadi.Text = reader["userSurname"].ToString();
                                KullaniciSoyadi = txtKullaniciSoyadi.Text;
                                txtEmail.Text = reader["userEmail"].ToString();
                                txtDogumGunu.Text = Convert.ToDateTime(reader["userBirthDate"]).ToString("dd.MM.yyyy");
                                txtTelNo.Text = reader["userPhoneNumber"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void CmbUyruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TC No textbox'ının görünürlüğünü ve aktifliğini kontrol et
            txtTCNO.Visible = cmbUyruk.Text == "Türkiye";
            lblUyruk.Visible = cmbUyruk.Text == "Türkiye";
            txtTCNO.Enabled = cmbUyruk.Text == "Türkiye";
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            // Checkbox kontrolü
            if (!chbOnay.Checked)
            {
                MessageBox.Show("Lütfen bilgilerinizin doğruluğunu onaylayınız.", 
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Türkiye seçiliyse ve TC No girilmemişse uyarı ver
            if (cmbUyruk.Text == "Türkiye" && string.IsNullOrWhiteSpace(txtTCNO.Text))
            {
                MessageBox.Show("Lütfen TC Kimlik Numaranızı giriniz.", 
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TC No girilmişse uzunluk kontrolü yap
            if (cmbUyruk.Text == "Türkiye" && txtTCNO.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.", 
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tüm kontroller başarılıysa devam et
            KoltukSecimi koltukSecimi = new KoltukSecimi(SelectedFlightID);
            koltukSecimi.Show();
            this.Hide();
        }

        // TC No'ya sadece sayı girilmesini sağlamak için
        private void txtTCNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve kontrol tuşlarına izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
