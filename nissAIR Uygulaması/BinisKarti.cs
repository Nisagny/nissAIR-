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
    public partial class BinisKarti : Form
    {
        private readonly string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";

        private string pnr, kalkisSaat, kalkisHavalimani, inisSaat, inisHavalimani, adSoyad, kalkisTarih;

        private void materialButton1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        public BinisKarti(string pnrCode)
        {
            InitializeComponent();
            pnr = pnrCode;
            LoadData();
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(pnr))
            {
                MessageBox.Show("PNR Kodu alınırken bir hata oluştu. Lütfen tekrar deneyiniz.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            TblUsers.UserName, 
                            TblUsers.UserSurname, 
                            TblFlights.DepartureAirport, 
                            TblFlights.ArrivalAirport,
                            TblFlights.DepartureDate,
                            TblFlights.DepartureTime, 
                            TblFlights.ArrivalDate, 
                            TblFlights.ArrivalTime
                        FROM TblPayments 
                        INNER JOIN TblUsers ON TblPayments.UserID = TblUsers.UserID
                        INNER JOIN TblFlights ON TblPayments.FlightID = TblFlights.FlightID
                        WHERE TblPayments.PNRCode = @pnr";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pnr", pnr);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                           
                            adSoyad = reader["UserName"].ToString() + " " + reader["UserSurname"].ToString();
                            kalkisSaat = reader["DepartureTime"].ToString();
                            kalkisTarih = DateTime.Parse(reader["DepartureDate"].ToString()).ToString("dd-MM-yyyy");
                            kalkisHavalimani = reader["DepartureAirport"].ToString();
                            inisSaat = reader["ArrivalTime"].ToString();
                            inisHavalimani = reader["ArrivalAirport"].ToString();

                           
                            lblAdSoyad.Text = adSoyad;
                            lblKalkisSaat.Text = kalkisSaat;
                            lblTarih.Text = kalkisTarih;
                            lblKalkisYeri.Text = kalkisHavalimani;
                            lblVarisSaat.Text = inisSaat;
                            lblVarisYeri.Text = inisHavalimani;
                            lblPnr.Text = pnr;
                            lblPnrCode.Text = pnr;
                        }
                        else
                        {
                            MessageBox.Show("PNR Kodu ile ilgili ödeme bilgisi bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message);
            }
        }
    }
}
