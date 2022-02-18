using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliEntity
{
   public class Urun
    {
        public int UrunID{ get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public int BirimdekiMiktar { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public int YeniSatis { get; set; }
        public int EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }


    }
}
