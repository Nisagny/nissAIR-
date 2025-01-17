using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nissAIR_Uygulaması
{

    public partial class KoltukSecimi : Form
    {
        
        private static string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";

        private int selectedFlightID;

      
        public KoltukSecimi(int flightID)
        {
            InitializeComponent();
            this.selectedFlightID = flightID;
            this.FormClosing += (s, e) => Environment.Exit(0);
            txtKoltukno.KeyPress += TxtKoltukNo_KeyPress;
            txtKoltukno.TextChanged += TxtKoltukno_TextChanged;
        }


        private void TxtKoltukno_TextChanged(object sender, EventArgs e)
        {
            decimal yeniFiyat = BiletAlis.SelectedFlightPrice;

            if (int.TryParse(txtKoltukno.Text, out int koltukNo))
            {
                if (koltukNo == 1)
                {
                    yeniFiyat += 350;
                }
                else if ((koltukNo >= 2 && koltukNo <= 10) || (koltukNo >= 13 && koltukNo <= 19))
                {
                    yeniFiyat += 250;
                }
            }

            lblKoltukFiyat.Text = yeniFiyat.ToString("N2") + " TRY";
            BiletAlis.SelectedFlightPrice = yeniFiyat;
        }

        
        private void TxtKoltukNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    
        
        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (ReserveSelectedSeat())
                {
                    BiletAlis.KoltukSecildi = true;
                    EkHizmetler ekHizmetler = new EkHizmetler();
                    ekHizmetler.Show();
                    this.Hide();
                }
            }
        }

        
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtKoltukno.Text))
            {
                MessageBox.Show("Lütfen koltuk numarası seçiniz.");
                return false;
            }

            if (!int.TryParse(txtKoltukno.Text, out int koltukNo) || koltukNo < 1 || koltukNo > 37)
            {
                MessageBox.Show("Lütfen 1-37 arasında bir koltuk numarası giriniz.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbKoltuk.Text))
            {
                MessageBox.Show("Lütfen koltuk tipini seçiniz.");
                return false;
            }

            return true;
        }

        
        private bool ReserveSelectedSeat()
        {
            //seçilen koltuğu rezerve ediyourm ki başka kullanıcıya tekrar satmamalıyım.
            string seatNumber = txtKoltukno.Text.PadLeft(2, '0') + cmbKoltuk.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    if (!IsSeatAvailable(conn, seatNumber))
                    {
                        MessageBox.Show("Bu koltuk dolu. Lütfen başka bir koltuk seçiniz.");
                        return false;
                    }

                    SaveReservation(conn, seatNumber);
                    MessageBox.Show("Koltuk rezervasyonu başarıyla yapıldı.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon sırasında bir hata oluştu: " + ex.Message);
                return false;
            }
        }

        private bool IsSeatAvailable(SqlConnection conn, string seatNumber)
        {
            //önceden rezerve edilip edilmediğini kontrol ediyorum.
            string query = "SELECT COUNT(*) FROM TblReservation WHERE FlightID = @FlightID AND SeatNumber = @SeatNumber";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FlightID", selectedFlightID);
                cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                return (int)cmd.ExecuteScalar() == 0;
            }
        }

        /// <summary>
        /// Rezervasyonu veritabanına kaydeden metod
        /// </summary>
        private void SaveReservation(SqlConnection conn, string seatNumber)
        {
            string query = @"INSERT INTO TblReservation (FlightID, UserID, SeatNumber, ReservationDate, Situation) 
                           VALUES (@FlightID, @UserID, @SeatNumber, @ReservationDate, @Situation)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FlightID", selectedFlightID);
                cmd.Parameters.AddWithValue("@UserID", GetCurrentUserID());
                cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                cmd.Parameters.AddWithValue("@ReservationDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Situation", 1);
                cmd.ExecuteNonQuery();
            }
        }

        private int GetCurrentUserID()
        {
            //rzervasyonu yapan kullanıcımın ID sini okuyorum.
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT userID FROM TblUsers WHERE userPhoneNumber = @PhoneNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", BiletAlis.UserPhoneNumber);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

       
        private void linklblDevamEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EkHizmetler ekHizmetler = new EkHizmetler();
            ekHizmetler.Show();
            this.Hide();
        }
    }
}
