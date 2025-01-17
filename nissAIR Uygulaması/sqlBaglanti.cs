using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace nissAIR_Uygulaması
{
    public  class sqlBaglanti
    {
        SqlConnection baglan=new SqlConnection ("Data Source=DESKTOP-NUR8O5T;Initial Catalog=nissAIR;Integrated Security=True;TrustServerCertificate=True");
        public SqlConnection baglanti ()
        {
            baglan.Open ();
            return baglan;
        }

        public void kapat()
        {
            if (baglan.State == System.Data.ConnectionState.Open)
            {
                baglan.Close();
            }
        }
    }
}
