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
  
    public partial class UcusTanimlama : Form
    {
        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connStr);
        static private string cmdStr = string.Empty;

        
        public UcusTanimlama()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);
        }

       
        private void UcusTanimlama_Load(object sender, EventArgs e)
        {
            //Burada form açıldığında Data Grid' ten görmek istediğim verileri otomatik göstermeye başlıyourm.
            FillDataGridView();
        }

        
        private void FillDataGridView()
        {
            conn.Open();
            cmdStr = "SELECT * FROM TblFlights";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            DataTable dt = new DataTable(); //DataTable verilerimi tablo şeklinde saklamamı sağlayan nesnedir.
            dt.Load(cmd.ExecuteReader());
            dgvUcuslar.DataSource = dt; //Data Gridimde görünmesi için bir tablo şeklinde tutulmuş kaynağa ihtiyacım vardı o kaynağı burada atadım.
            conn.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmdStr = "INSERT INTO TblFlights" +
            "(PlaneID, DepartureAirport, ArrivalAirport, DepartureDate, DepartureTime, ArrivalDate, ArrivalTime, Amount)" +
            "VALUES" +
            "(@PlaneID_, @DepartureAirport_, @ArrivalAirport_, @DepartureDate_, @DepartureTime_, @ArrivalDate_, @ArrivalTime_, @Amount_)";

            SqlCommand cmd = new SqlCommand(cmdStr, conn);

            cmd.Parameters.AddWithValue("@PlaneID_", txtPlane.Text);
            cmd.Parameters.AddWithValue("@DepartureAirport_", cmbNereden.Text);
            cmd.Parameters.AddWithValue("@ArrivalAirport_", cmbNereye.Text);
            cmd.Parameters.AddWithValue("@DepartureDate_", DateTime.Parse(dtpKalkisTarih.Text).Date);
            cmd.Parameters.AddWithValue("@DepartureTime_", DateTime.Parse(dtpKalkisSaat.Text).TimeOfDay);
            cmd.Parameters.AddWithValue("@ArrivalDate_", DateTime.Parse(dtpVarisTarihi.Text).Date);
            cmd.Parameters.AddWithValue("@ArrivalTime_", DateTime.Parse(dtpVarisSaati.Text).TimeOfDay);
            cmd.Parameters.AddWithValue("@Amount_", txtUcret.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarılı");
            Temizle();
            FillDataGridView();

        }
        private void Temizle()
        {
            txtPlane.Text = string.Empty;
            cmbNereden.Text = string.Empty;
            cmbNereye.Text = string.Empty;
            dtpKalkisTarih.Text = string.Empty;
            dtpKalkisSaat.Text = string.Empty;
            dtpVarisTarihi.Text = string.Empty;
            dtpVarisSaati.Text = string.Empty;

        }

        private void dgvUcuslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUcuslar.Rows[e.RowIndex];

                txtPlane.Text = row.Cells[1].Value?.ToString();
                cmbNereden.Text = row.Cells[2].Value.ToString();
                cmbNereye.Text = row.Cells[3].Value?.ToString();
                dtpKalkisTarih.Text = row.Cells[4].Value?.ToString();
                dtpKalkisSaat.Text = (row.Cells[5].Value?.ToString());
                dtpVarisTarihi.Text = (row.Cells[6].Value?.ToString());
                dtpVarisSaati.Text = (row.Cells[7].Value?.ToString());

            }
        }

      
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUcuslar.SelectedRows.Count > 0)
            {
                try
                {
                    int flightID = Convert.ToInt32(dgvUcuslar.SelectedRows[0].Cells["FlightID"].Value);
                    string oldDepartureTime = string.Empty;
                    string oldArrivalTime = string.Empty;
                    string oldDepartureAirport = string.Empty;
                    string oldArrivalAirport = string.Empty;

                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string getOldValues = "SELECT DepartureTime, ArrivalTime, DepartureAirport, ArrivalAirport FROM TblFlights WHERE FlightID = @FlightID";
                        using (SqlCommand cmd = new SqlCommand(getOldValues, conn))
                        {
                            cmd.Parameters.AddWithValue("@FlightID", flightID);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    oldDepartureTime = ((TimeSpan)reader["DepartureTime"]).ToString(@"hh\:mm");
                                    oldArrivalTime = ((TimeSpan)reader["ArrivalTime"]).ToString(@"hh\:mm");
                                    oldDepartureAirport = reader["DepartureAirport"].ToString();
                                    oldArrivalAirport = reader["ArrivalAirport"].ToString();
                                }
                            }
                        }

                        // Güncelleme işlemi
                        string updateQuery = "UPDATE TblFlights SET " +
                             "DepartureAirport = @DepartureAirport_, " +
                             "ArrivalAirport = @ArrivalAirport_, " +
                             "DepartureDate = @DepartureDate_, " +
                             "DepartureTime = @DepartureTime_, " +
                             "ArrivalDate = @ArrivalDate_, " +
                             "ArrivalTime = @ArrivalTime_ " +
                             "WHERE FlightID = @FlightID_";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@DepartureAirport_", cmbNereden.Text);
                            cmd.Parameters.AddWithValue("@ArrivalAirport_", cmbNereye.Text);
                            cmd.Parameters.AddWithValue("@DepartureDate_", DateTime.Parse(dtpKalkisTarih.Text).Date);
                            cmd.Parameters.AddWithValue("@DepartureTime_", DateTime.Parse(dtpKalkisSaat.Text).TimeOfDay);
                            cmd.Parameters.AddWithValue("@ArrivalDate_", DateTime.Parse(dtpVarisTarihi.Text).Date);
                            cmd.Parameters.AddWithValue("@ArrivalTime_", DateTime.Parse(dtpVarisSaati.Text).TimeOfDay);
                            cmd.Parameters.AddWithValue("@FlightID_", flightID);

                            cmd.ExecuteNonQuery();
                        }

                        

                        MessageBox.Show("Kayıt başarıyla güncellendi ve ilgili yolculara bildirim gönderildi.");
                        Temizle();
                        FillDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir satır seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUcuslar.SelectedRows.Count > 0) 
            {
                int flightID = Convert.ToInt32(dgvUcuslar.SelectedRows[0].Cells["FlightID"].Value);

                conn.Open();
                cmdStr = "DELETE FROM TblFlights WHERE FlightID = @FlightID_";
                SqlCommand cmd = new SqlCommand(cmdStr, conn);
                cmd.Parameters.AddWithValue("@FlightID_", flightID);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kayıt başarıyla silindi.");
                Temizle();
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                conn.Open();
 
                cmdStr = "SELECT * FROM TblFlights WHERE PlaneID LIKE '%" + txtSearch.Text + "%'" + 
                "OR DepartureAirport LIKE '%" + txtSearch.Text + "%'" + 
                "OR ArrivalAirport LIKE '%" + txtSearch.Text + "%'";
                SqlCommand cmd = new SqlCommand(cmdStr,conn);
                DataTable dt =new DataTable();
               
                dt.Load(cmd.ExecuteReader());
                dgvUcuslar.DataSource = dt;
                conn.Close();
            }
            else {  FillDataGridView(); }
        }

        private void btnBaslangic_Click(object sender, EventArgs e)
        {
            AcilisEkrani acilisEkrani = new AcilisEkrani();
            acilisEkrani.Show();
            this.Hide();
        }
    }

}
