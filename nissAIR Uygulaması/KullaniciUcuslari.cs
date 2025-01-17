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
    public partial class KullaniciUcuslari : Form
    {
        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        public KullaniciUcuslari()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.FormClosing += (s, e) => { 
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
            };
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            string query = $"SELECT * FROM TblReservation WHERE userID = {anasayfa.KullaniciID}";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
