using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliORM
{
    public static class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Bag"].ConnectionString);
        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }
        
    }
}
