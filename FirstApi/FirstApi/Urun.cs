namespace FirstApi
{
    public class Urun
    {
        public int UrunId { get; set; }

        public string UrunAdi{ get; set; }

        public int UrunFiyat { get; set; }

        //public int Barkod { get; set; }

        public int StokAdet { get; set; }

        public DateOnly SKT { get; set; }

        public bool Stokta { get; set; }


    }
}
