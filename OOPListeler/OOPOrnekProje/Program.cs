Profil p1 = new Profil("tugaytuna", true)
{
    TakipciSayisi = 152,
    TakipEdilenSayisi = 14,
    ToplamBegeniSayisi = 121
};
Profil p2 = new Profil("tututu", false)
{
    TakipciSayisi = 1421,
    TakipEdilenSayisi = 1542,
    ToplamBegeniSayisi = 1211
};
Profil p3 = new Profil("elifszgn", true)
{
    TakipciSayisi = 452,
    TakipEdilenSayisi = 145,
    ToplamBegeniSayisi = 1848
};
Profil p4 = new Profil("metinok", true)
{
    TakipciSayisi = 245,
    TakipEdilenSayisi = 548,
    ToplamBegeniSayisi = 4578
};
Profil p5 = new Profil("onrozkc", false)
{
    TakipciSayisi = 4542,
    TakipEdilenSayisi = 115,
    ToplamBegeniSayisi = 890
};
Profil p6 = new Profil("sibelktr", false)
{
    TakipciSayisi = 845,
    TakipEdilenSayisi = 754,
    ToplamBegeniSayisi = 5426
};

List<Profil> profiller = new List<Profil>()
{
    p1,p2,p3,p4,p5,p6
};

Console.WriteLine("Uygulamaya Hoş Geldiniz!");

Console.WriteLine("1- Tüm kullanıcıları listele");
Console.WriteLine("2- En az takipçi sayısı girerek listele");


string secim = Console.ReadLine();
switch (secim)
{
    case "1":
        //tüm kullanıcıları listeleme metotu
        KullaniciListele();
        break;
    case "2":
        //takipçi sayısı 500ün üzerindeki kullanıcılar
        Console.WriteLine("En az kaç takipçili olmalı?");
        int filtreSayi = int.Parse(Console.ReadLine());
        KullaniciListele(filtreSayi);
        break;
    default:
        Console.WriteLine("Hatalı tuşlama yaptınız");
        break;
}

void KullaniciListele(int filtre = 0)
{
    if (filtre > 0)
    {
        Console.WriteLine("----{0}'ün üzerinde takipçili kullanıcılar----",filtre);
    }
    else
    {
        Console.WriteLine("----Tüm kullanıcılar----");
    }

    foreach (Profil profil in profiller)
    {
        if (profil.TakipciSayisi >= filtre)
        {
            Console.WriteLine("{0} kullanıcısının takipçi sayısı: {1}", profil.KullaniciAdi, profil.TakipciSayisi);
        }
    }
}








class Profil
{
    public string KullaniciAdi { get; set; }

    public int TakipciSayisi { get; set; }

    public int TakipEdilenSayisi { get; set; }

    public int ToplamBegeniSayisi { get; set; }

    public bool MaviTik { get; set; }


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
        Console.WriteLine("@{0} kullanıcı isimli profilin bilgileri aşağıdadır.", KullaniciAdi);
        Console.WriteLine("Takipçi Sayısı: " + TakipciSayisi);
        Console.WriteLine("Takip Edilen Sayısı: " + TakipEdilenSayisi);
        Console.WriteLine("Toplam Beğeni Sayısı: " + ToplamBegeniSayisi);

        if (MaviTik)
        {
            Console.WriteLine("Mavi Tik sahibi kullanıcı.");
        }
        Console.WriteLine("**********************");


    }

}