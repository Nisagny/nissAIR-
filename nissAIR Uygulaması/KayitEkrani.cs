using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nissAIR_Uygulaması
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
            
            this.FormClosing += (s,e) => Environment.Exit(0);
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AcilisEkrani ae = new AcilisEkrani();
            ae.Show();
            this.Hide();
        }
  
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            char[] ozelKarakterler = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/' };
            char[] sayi = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] buyukHarfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'Q', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'W', 'X', 'Y', 'Z' };
            char[] kucukHarfler = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'q', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'w', 'x', 'y', 'z' };

            if (!chbOnay.Checked)
            {
                MessageBox.Show("Şartları ve koşulları onaylamalısınz.");
                return;
            }
            if (txtSifre.Text != txtYenidenSifre.Text)
            {
                MessageBox.Show("Girilen şifreler uyuşmuyor.");
                return;
            }
            if (txtSifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter içermeli.");
                return;
            }
            bool containsNumber = false;
            bool containsBigLetter = false;
            bool containsSmallLetter = false;
            bool containsSpecialChars = false;

            foreach (var item in txtSifre.Text)
            {
                if (!containsNumber)
                    containsNumber = sayi.Contains(item) ? true : false;
                if(!containsBigLetter)
                    containsBigLetter = buyukHarfler.Contains(item) ? true : false;
                if (!containsSmallLetter)
                    containsSmallLetter = kucukHarfler.Contains(item) ? true : false;
                if (!containsSpecialChars)
                    containsSpecialChars = ozelKarakterler.Contains(item) ? true : false;
            }
            if (!containsBigLetter || !containsNumber || !containsSmallLetter || !containsSpecialChars)
            {
                MessageBox.Show("Şifre büyük harf, küçük harf, rakam ve özel karakter içermelidir.");
                return;
            }
            


            SqlCommand komut = new SqlCommand("insert into TblUsers " +
                "(userName, userSurname, userPhoneNumber,userEmail," +
                "userPassword, userGender, userBirthDate)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6, @p7)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", txtTelNo.Text);
            komut.Parameters.AddWithValue("@p4", txtEmail.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p7", txtDogumTarihi.Text);

            komut.ExecuteNonQuery();
            bgl.kapat();

            BasariliKayit basariliKayit = new BasariliKayit();
            basariliKayit.Show();
            this.Hide();
        }



    }
}
