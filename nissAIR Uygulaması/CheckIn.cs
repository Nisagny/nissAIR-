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
    
    public partial class CheckIn : Form
    {
        
        private readonly string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";

        public CheckIn()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPNR.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("PNR ve Soyad alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    
                    string query = @"SELECT p.PNRCode, u.userSurname 
                                   FROM TblPayments p
                                   INNER JOIN TblUsers u ON p.UserID = u.UserID
                                   WHERE p.PNRCode = @pnr AND u.userSurname = @surname";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pnr", txtPNR.Text.Trim());
                        cmd.Parameters.AddWithValue("@surname", txtSoyad.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close();
                                BinisKarti binisKarti = new BinisKarti(txtPNR.Text);
                                binisKarti.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Debug için girilen değerleri gösterelim
                                MessageBox.Show($"Girilen Değerler:\nPNR: {txtPNR.Text}\nSoyad: {txtSoyad.Text}\n\n" +
                                    "Bu bilgilerle eşleşen kayıt bulunamadı. Lütfen bilgilerinizi kontrol edip tekrar deneyiniz.",
                                    "Kayıt Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uçuş bilgileri kontrol edilirken bir hata oluştu: " + ex.Message +
                    "\nStack Trace: " + ex.StackTrace,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
