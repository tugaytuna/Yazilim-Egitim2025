

Console.WriteLine("Uygulamaya hoş geldiniz!");
Console.WriteLine("Kaç kullanıcı eklemek istersiniz?");
int kullaniciSayisi = int.Parse(Console.ReadLine());

List<Profil> profiller = new List<Profil>();

for (int i = 0; i < kullaniciSayisi; i++)
{
    Console.WriteLine("Bir kullanıcı adı giriniz.");
    Profil p1 = new Profil(Console.ReadLine(), false);

    Console.WriteLine("Takipçi sayısını giriniz");
    p1.TakipciSayisi = int.Parse(Console.ReadLine());

    Console.WriteLine("Takip edilen sayısını giriniz");
    p1.TakipEdilenSayisi = int.Parse(Console.ReadLine());

    Console.WriteLine("Toplam Beğeni sayısını giriniz");
    p1.ToplamBegeniSayisi = int.Parse(Console.ReadLine());


    profiller.Add(p1);

}


foreach (Profil profil in profiller)
{
    profil.ProfilBilgileriYazdir();
}


Console.WriteLine(profiller[2].KullaniciAdi);


class Profil
{
    public string KullaniciAdi { get; set; }

    public int TakipciSayisi { get; set; }

    public int TakipEdilenSayisi { get; set; }

    public int ToplamBegeniSayisi { get; set; }

    public bool MaviTik {  get; set; }

    
    public Profil(string kadi)
    {
        KullaniciAdi = kadi.ToLower();
    }

    public Profil(string KullaniciAdi, bool MaviTik)
    {
        this.KullaniciAdi = KullaniciAdi.ToLower();
        this.MaviTik = MaviTik;
    }

    public void ProfilBilgileriYazdir()
    {
        Console.WriteLine("**********************");
        Console.WriteLine("@{0} kullanıcı isimli profilin bilgileri aşağıdadır.",KullaniciAdi);
        Console.WriteLine("Takipçi Sayısı: " + TakipciSayisi);
        Console.WriteLine("Takip Edilen Sayısı: " + TakipEdilenSayisi);
        Console.WriteLine("Toplam Beğeni Sayısı: "+ ToplamBegeniSayisi);

        if (MaviTik)
        {
            Console.WriteLine("Mavi Tik sahibi kullanıcı.");
        }
        Console.WriteLine("**********************");


    }

}