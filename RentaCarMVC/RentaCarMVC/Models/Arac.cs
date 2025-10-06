namespace RentaCarMVC.Models
{
    public class Arac
    {
        public int AracId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public bool Vites { get; set; } // Otomatik Vites - True
        public int GunlukKira { get; set; } // Günlük Kiralama ücreti TL cinsinden
        public int Kilometre { get; set; }
        public bool Hazir { get; set; } // Kiralamaya uygun - True
        public string GorselUrl { get; set; }
    }
}
