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
    public partial class KullaniciGiris : Form
    {

        public KullaniciGiris()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => Environment.Exit(0);
        }


        static private string connStr = "Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connStr);

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AcilisEkrani ae = new AcilisEkrani();
            ae.Show();
            this.Hide();

        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {


        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM TblUsers WHERE userPhoneNumber = @phoneNumber AND userPassword = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phoneNumber", txtTelNo.Text);
                cmd.Parameters.AddWithValue("@password", txtSifre.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string userName = reader["userName"].ToString();
                        int id = Convert.ToInt32(reader["userID"].ToString());
                        anasayfa anasayfaForm = new anasayfa();
                        //gerekli formlarda bu isimlerde property oluşturdum ve onlara bu değerleri gönderiyorum.
                        anasayfa.KullaniciAdiSoyadi = userName;
                        anasayfa.KullaniciID = id;
                        BiletAlis.UserPhoneNumber = txtTelNo.Text;
                        anasayfaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Telefon numarası veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

