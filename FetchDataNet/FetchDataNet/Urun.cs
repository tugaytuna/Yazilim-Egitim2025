using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataNet
{
    internal class Urun
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public int UrunFiyat { get; set; }

        //public int Barkod { get; set; }

        public int StokAdet { get; set; }

        public DateTime SKT { get; set; }

        public bool Stokta { get; set; }
    }
}
