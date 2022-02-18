using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public class Kategoriler
    {
        //select insert Update işlemi yapılacak.

        public static DataTable KategoriListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * From Kategoriler",Tools.Baglanti);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
