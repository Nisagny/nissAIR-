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
    public partial class UcakTanimla : Form
    {
        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        public UcakTanimla()
        {
            InitializeComponent();

            dgvUcaklar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //data  grid'te yer alan sütunların genişliklerini olduğu alanı kaplayacak şekilde ayarlamak için kullandım.

            DataGridFill();
        }

        private void DataGridFill()
        {
            dgvUcaklar.DataSource = null;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sorgu = "SELECT * FROM TblPlane";
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvUcaklar.DataSource = dt;

            conn.Close();
        }

        private void btnUcakEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO TblPlane(plnCapacity) VALUES (@capacity)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@capacity", 222);
            cmd.ExecuteNonQuery();

            conn.Close();
            DataGridFill();
        }

        private void btnBaslangic_Click(object sender, EventArgs e)
        {
            AcilisEkrani acilisEkrani = new AcilisEkrani();
            acilisEkrani.Show();
            this.Hide();
        }
    }
}
