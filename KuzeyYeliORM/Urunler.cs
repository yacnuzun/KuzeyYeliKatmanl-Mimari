using KuzeyYeliEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KuzeyYeliORM
{
    public class Urunler
    {
        
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * From Urunler",Tools.Baglanti);

            DataTable dt = new DataTable();
            adp.Fill (dt);
            return dt;
        }

        public static bool Ekle(Urun U)
        {

            SqlCommand add = new SqlCommand("UrunEkle", Tools.Baglanti);
            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.AddWithValue("@ad",U.UrunAdi);
            add.Parameters.AddWithValue("@fiyat",U.Fiyat);
            add.Parameters.AddWithValue("@stok",U.Stok);
            add.Parameters.AddWithValue("@tedarikciID",U.TedarikciID);
            add.Parameters.AddWithValue("@kategoriID",U.KategoriID);
            
                Tools.Baglanti.Open();
            int sonuc =    add.ExecuteNonQuery();
                Tools.Baglanti.Close();
            if (sonuc>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //select insert Update işlemi yapılacak.
    }
}
