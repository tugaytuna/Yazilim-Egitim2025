namespace KitaplikUygulamasi.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimYili { get; set; }
        public bool Okundu { get; set; }

    }
}
