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
using System.Xml.Linq;

namespace nissAIR_Uygulaması
{
    
    public partial class OdemeEkrani : Form
    {
       
        public OdemeEkrani()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);

        }

        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connStr);
        static private string cmdStr = string.Empty;


    
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtKartNumarasi.Text) || 
                    string.IsNullOrWhiteSpace(txtKartSahibi.Text) || 
                    string.IsNullOrWhiteSpace(txtCVV.Text) ||
                    string.IsNullOrWhiteSpace(txtSKT.Text))
                {
                    MessageBox.Show("Lütfen tüm kart bilgilerini doldurunuz.", 
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    
                    string userQuery = "SELECT UserID FROM TblUsers WHERE userPhoneNumber = @phoneNumber";
                    int userID;

                    using (SqlCommand userCmd = new SqlCommand(userQuery, conn))
                    {
                        userCmd.Parameters.AddWithValue("@phoneNumber", BiletAlis.UserPhoneNumber);
                        var result = userCmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Kullanıcı bilgisi bulunamadı!", 
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        userID = Convert.ToInt32(result);
                    }


                    string pnrCode = DateTime.Now.ToString("yyMMdd") +
                        new Random().Next(1000, 9999).ToString();

                    //yapılan ödememin kaydını vertabanıma ekliyorum
                    string paymentQuery = @"INSERT INTO TblPayments 
                        (UserID, FlightID, PaymentDate, Amount, PNRCode, 
                        CardHolderName, PaymentType, CardNumber, CardCVV, CardSonKullanmaTarihi ) 
                        VALUES 
                        (@UserID, @FlightID, @PaymentDate, @PaymentAmount, @PNRCode, 
                         @CardHolderName, @PaymentType, @CardNumber, @CardCVV, @CardSonKullanmaTarihi)";

                    using (SqlCommand cmd = new SqlCommand(paymentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@FlightID", BiletAlis.SelectedFlightID);
                        cmd.Parameters.AddWithValue("@PNRCode", pnrCode);
                        cmd.Parameters.AddWithValue("@PaymentAmount", BiletAlis.SelectedFlightPrice);
                        cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@CardNumber", txtKartNumarasi.Text);
                        cmd.Parameters.AddWithValue("@PaymentType", cmbPaymentType.Text);
                        cmd.Parameters.AddWithValue("@CardHolderName", txtKartSahibi.Text);
                        cmd.Parameters.AddWithValue("@CardCVV", txtCVV.Text);
                        cmd.Parameters.AddWithValue("@CardSonKullanmaTarihi", txtSKT.Text);

                        cmd.ExecuteNonQuery();

                       
                    }

                    MessageBox.Show($"Ödeme başarıyla tamamlandı!\n\n" +
                        $"PNR Kodunuz: {pnrCode}\n\n" +
                       MessageBoxButtons.OK);

                    // Ana sayfaya dön
                    anasayfa anasayfa = new anasayfa();
                    anasayfa.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message, 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

