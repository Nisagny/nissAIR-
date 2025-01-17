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
    public partial class Ucuslar : Form
    {
        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";

        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime SelectedDate { get; set; }
        
        //incele butonlarıma tıkladığımda daha sonra kullanılmak üzere uçuşların Id değerini tuttum
        private int? flight1ID;
        private int? flight2ID;
        private int? flight3ID;
        private int? flight4ID;        
        
        private Label lblUcret1;
        private Label lblUcret2;
        private Label lblUcret3;
        private Label lblUcret4;

        private Label lblKalkisSaat1;
        private Label lblVarisSaat1;
        private Label lblKalkisSaat2;
        private Label lblVarisSaat2;
        private Label lblKalkisSaat3;
        private Label lblVarisSaat3;
        private Label lblKalkisSaat4;
        private Label lblVarisSaat4;

        public Ucuslar()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);


        }

        private void Ucuslar_Load(object sender, EventArgs e)
        {
            ShowFlights(SelectedDate);



            btnBugun.Text = SelectedDate.ToString().Split(' ')[0];

           
            if (SelectedDate > DateTime.MinValue.AddDays(1))
            {
                btnDun.Text = SelectedDate.AddDays(-1).ToString().Split(' ')[0];
            }
            else
            {
                btnDun.Text = "Geçerli Değil";
            }

            if (SelectedDate > DateTime.MinValue.AddDays(2))
            {
                btnOnceki.Text = SelectedDate.AddDays(-2).ToString().Split(' ')[0];
            }
            else
            {
                btnOnceki.Text = "Geçerli Değil";
            }

            btnYarin.Text = SelectedDate.AddDays(1).ToString().Split(' ')[0];
            btnSonraki.Text = SelectedDate.AddDays(2).ToString().Split(' ')[0];

           

        }

        private void ShowFlights(DateTime selecteddate)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string query = @"SELECT FlightID, DepartureTime, ArrivalTime, DepartureAirport, ArrivalAirport, Amount 
                                FROM TblFlights 
                                WHERE DepartureAirport = @DepartureAirport 
                                AND ArrivalAirport = @ArrivalAirport 
                                AND DepartureDate = @DepartureDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartureAirport", DepartureAirport);
                    cmd.Parameters.AddWithValue("@ArrivalAirport", ArrivalAirport);
                    cmd.Parameters.AddWithValue("@DepartureDate", selecteddate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int Departurex = 60, Arrivalx = 785;
                        int Departurey = 110, Arrivaly = 110;
                        int Ucretx = 940, Ucrety = 120;
                        
                        int i = 1;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // FlightID'yi al
                                int flightID = Convert.ToInt32(reader["FlightID"]);
                                
                                // Panele göre FlightID'yi sakla
                                switch(i)
                                {
                                    case 1:
                                        flight1ID = flightID;
                                        break;
                                    case 2:
                                        flight2ID = flightID;
                                        break;
                                    case 3:
                                        flight3ID = flightID;
                                        break;
                                    case 4:
                                        flight4ID = flightID;
                                        break;
                                }

                                string departureAirport = reader["DepartureAirport"].ToString();
                                string arrivalAirport = reader["ArrivalAirport"].ToString();
                                string departureTime = ((TimeSpan)reader["DepartureTime"]).ToString(@"hh\:mm");
                                string arrivalTime = ((TimeSpan)reader["ArrivalTime"]).ToString(@"hh\:mm");
                                string amount = reader["Amount"].ToString();

                                
                                Label lbldepartureTime = new Label();
                                lbldepartureTime.Text = departureTime;
                                lbldepartureTime.BackColor = Color.Transparent;
                                lbldepartureTime.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                                lbldepartureTime.Name = "lblKalkisSaat" + i;
                                lbldepartureTime.Location = new Point(Departurex, Departurey);
                                
                                
                                switch(i)
                                {
                                    case 1:
                                        lblKalkisSaat1 = lbldepartureTime;
                                        break;
                                    case 2:
                                        lblKalkisSaat2 = lbldepartureTime;
                                        break;
                                    case 3:
                                        lblKalkisSaat3 = lbldepartureTime;
                                        break;
                                    case 4:
                                        lblKalkisSaat4 = lbldepartureTime;
                                        break;
                                }

                                Departurey += 40;

                                Label lbldepartureAirport = new Label();
                                lbldepartureAirport.Text = departureAirport;
                                lbldepartureAirport.BackColor = Color.Transparent;
                                lbldepartureAirport.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                                lbldepartureAirport.Name = "lblKalkisAirport" + i;
                                lbldepartureAirport.Location = new Point(Departurex, Departurey);

                                Label lblarrivalTime = new Label();
                                lblarrivalTime.Text = arrivalTime;
                                lblarrivalTime.BackColor = Color.Transparent;
                                lblarrivalTime.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                                lblarrivalTime.Name = "lblVarisSaat" + i;
                                lblarrivalTime.Location = new Point(Arrivalx, Arrivaly);

                                // Varış saati label referansını hemen sakla
                                switch(i)
                                {
                                    case 1:
                                        lblVarisSaat1 = lblarrivalTime;
                                        break;
                                    case 2:
                                        lblVarisSaat2 = lblarrivalTime;
                                        break;
                                    case 3:
                                        lblVarisSaat3 = lblarrivalTime;
                                        break;
                                    case 4:
                                        lblVarisSaat4 = lblarrivalTime;
                                        break;
                                }

                                Arrivaly += 40;

                                Label lblArrivalAirport = new Label();
                                lblArrivalAirport.Text = arrivalAirport;
                                lblArrivalAirport.BackColor = Color.Transparent;
                                lblArrivalAirport.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                                lblArrivalAirport.Name = "lblVarisAirport" + i;
                                lblArrivalAirport.Location = new Point(Arrivalx, Arrivaly);

                                Label lblAmount = new Label();
                                lblAmount.Text = amount + " TRY";
                                lblAmount.BackColor = Color.Transparent;
                                lblAmount.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                                lblAmount.Name = "lblUcret" + i;
                                lblAmount.Location = new Point(Ucretx, Ucrety);

                                // Label referansını sakla
                                switch(i)
                                {
                                    case 1:
                                        lblUcret1 = lblAmount;
                                        break;
                                    case 2:
                                        lblUcret2 = lblAmount;
                                        break;
                                    case 3:
                                        lblUcret3 = lblAmount;
                                        break;
                                    case 4:
                                        lblUcret4 = lblAmount;
                                        break;
                                }

                                Departurey += 80;
                                Arrivaly += 80;
                                Ucrety += 110;
                                i++;

                                this.Controls.Add(lbldepartureTime);
                                this.Controls.Add(lbldepartureAirport);
                                this.Controls.Add(lblarrivalTime);
                                this.Controls.Add(lblArrivalAirport);
                                this.Controls.Add(lblAmount);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Uygun uçuş bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearDynamicLabels();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uçuş bilgileri yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnBugun_Click(object sender, EventArgs e)
        {
            ShowFlights(SelectedDate);
        }

        private void btnDun_Click(object sender, EventArgs e)
        {
            ShowFlights(SelectedDate.AddDays(-1));
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            ShowFlights(SelectedDate.AddDays(-2));
        }

        private void btnYarin_Click(object sender, EventArgs e)
        {
            ShowFlights(SelectedDate.AddDays(1));
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            ShowFlights(SelectedDate.AddDays(2));
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            if (flight1ID.HasValue)
            {
                try
                {
                    BiletAlis.SelectedFlightID = flight1ID.Value;
                    decimal price = decimal.Parse(lblUcret1.Text.Replace(" TRY", ""));
                    BiletAlis.SelectedFlightPrice = price;

                    // Seçilen uçuşun saatlerini burada kaydediyorum çünkü daha sonra kullanacağım.
                    if (lblKalkisSaat1 != null && lblVarisSaat1 != null)
                    {
                        BiletAlis.KalkisSaati = lblKalkisSaat1.Text;
                        BiletAlis.VarisSaati = lblVarisSaat1.Text;

                        BiletSecenek biletSecenek = new BiletSecenek();
                        biletSecenek.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uçuş saatleri bilgisi alınamadı. Lütfen tekrar deneyin.", 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, 
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu sefer için uçuş bulunamadı.");
            }
        }

        private void btnIncele2_Click(object sender, EventArgs e)
        {
            if (flight2ID.HasValue)
            {
                try
                {
                    BiletAlis.SelectedFlightID = flight2ID.Value;
                    decimal price = decimal.Parse(lblUcret2.Text.Replace(" TRY", ""));
                    BiletAlis.SelectedFlightPrice = price;

                    // Seçilen uçuşun saatlerini kaydet
                    if (lblKalkisSaat2 != null && lblVarisSaat2 != null)
                    {
                        BiletAlis.KalkisSaati = lblKalkisSaat2.Text;
                        BiletAlis.VarisSaati = lblVarisSaat2.Text;

                        BiletSecenek biletSecenek = new BiletSecenek();
                        biletSecenek.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uçuş saatleri bilgisi alınamadı. Lütfen tekrar deneyin.", 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, 
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu sefer için uçuş bulunamadı.");
            }
        }

        private void btnIncele3_Click(object sender, EventArgs e)
        {
            if (flight3ID.HasValue)
            {
                try
                {
                    BiletAlis.SelectedFlightID = flight3ID.Value;
                    decimal price = decimal.Parse(lblUcret3.Text.Replace(" TRY", ""));
                    BiletAlis.SelectedFlightPrice = price;

                    // Seçilen uçuşun saatlerini kaydet
                    if (lblKalkisSaat3 != null && lblVarisSaat3 != null)
                    {
                        BiletAlis.KalkisSaati = lblKalkisSaat3.Text;
                        BiletAlis.VarisSaati = lblVarisSaat3.Text;

                        BiletSecenek biletSecenek = new BiletSecenek();
                        biletSecenek.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uçuş saatleri bilgisi alınamadı. Lütfen tekrar deneyin.", 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, 
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu sefer için uçuş bulunamadı.");
            }
        }

        private void btnIncele4_Click(object sender, EventArgs e)
        {
            if (flight4ID.HasValue)
            {
                try
                {
                    BiletAlis.SelectedFlightID = flight4ID.Value;
                    decimal price = decimal.Parse(lblUcret4.Text.Replace(" TRY", ""));
                    BiletAlis.SelectedFlightPrice = price;

                    // Seçilen uçuşun saatlerini kaydet
                    if (lblKalkisSaat4 != null && lblVarisSaat4 != null)
                    {
                        BiletAlis.KalkisSaati = lblKalkisSaat4.Text;
                        BiletAlis.VarisSaati = lblVarisSaat4.Text;

                        BiletSecenek biletSecenek = new BiletSecenek();
                        biletSecenek.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uçuş saatleri bilgisi alınamadı. Lütfen tekrar deneyin.", 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, 
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu sefer için uçuş bulunamadı.");
            }
        }

        private void ClearDynamicLabels()
        {
            // Dinamik olarak oluşturduğum tüm labelleri burada temizliyorum çünkü bir sonraki uçuş seçimlerimde eeskiden kalan olmamalı.
            var labelsToRemove = this.Controls.OfType<Label>()
                .Where(lbl => lbl.Name.StartsWith("lblKalkisSaat") ||
                             lbl.Name.StartsWith("lblKalkisAirport") ||
                             lbl.Name.StartsWith("lblVarisSaat") ||
                             lbl.Name.StartsWith("lblVarisAirport") ||
                             lbl.Name.StartsWith("lblUcret"))
                .ToList();

            foreach (var label in labelsToRemove)
            {
                this.Controls.Remove(label);
                label.Dispose();
            }

            // FlightID değerlerini sıfırla
            flight1ID = null;
            flight2ID = null;
            flight3ID = null;
            flight4ID = null;

            // Label referanslarını temizle
            lblUcret1 = null;
            lblUcret2 = null;
            lblUcret3 = null;
            lblUcret4 = null;

            // Saat label referanslarını temizle
            lblKalkisSaat1 = null;
            lblKalkisSaat2 = null;
            lblKalkisSaat3 = null;
            lblKalkisSaat4 = null;
            lblVarisSaat1 = null;
            lblVarisSaat2 = null;
            lblVarisSaat3 = null;
            lblVarisSaat4 = null;
        }
    }
}
