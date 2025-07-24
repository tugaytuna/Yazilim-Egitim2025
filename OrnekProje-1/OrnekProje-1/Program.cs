List<Urun> urunler = new List<Urun>();
List<Musteri> musteriler = new List<Musteri>()
{
    new Musteri(){Ad="Ahmet",Il="İstanbul",Soyad="Yılmaz",Telefon=0544545445},
    new Musteri(){Ad="Elif",Soyad="Sezgin",Il="İstanbul",Telefon=0544548784},
    new Musteri(){Ad="Levent",Soyad="Akgül",Il="İstanbul",Telefon=05325455},
    new Musteri(){Ad="Metin",Soyad="Ok",Il="İzmir",Telefon=0505458974},
    new Musteri(){Ad="Sibel", Soyad="Katar", Il="Ankara", Telefon=054545421}
};


//Müşteriler
//    Ad      Soyad       İl         Telefon
//    Ahmet   Yılmaz   İstanbul       554545564
//    Elif    Sezgin   İstanbul       545545454
//    Levent  Akgül    İstanbul       554654646
//    Metin   Ok       İzmir          454545545


List<Kayit> kayitler = new List<Kayit>()
{
    new Kayit(){KayitId=1,Musteri = musteriler[0], Ariza=true, Fiyat=1000, Tamamlandi=true, Teknisyen="Ahmet Teknik"},
    new Kayit(){KayitId=2,Musteri = musteriler[1], Ariza=false, Fiyat=2000, Tamamlandi=false, Teknisyen="Mehmet Teknik"},
    new Kayit(){KayitId=3,Musteri = musteriler[2], Ariza=true, Fiyat=5000, Tamamlandi=true, Teknisyen="Ahmet Teknik" },
    new Kayit(){KayitId=4 ,Musteri = musteriler[3], Ariza=false, Fiyat=500, Tamamlandi=true, Teknisyen="Osman Teknik"}
};




Console.WriteLine("Kayıt Sistemine Hoş Geldiniz!");

while (true)
{
    Console.WriteLine("1-Müşteri Listele");
    Console.WriteLine("2-Müşteri Ara");
    Console.WriteLine("3-Kayıtları Liste");
    Console.WriteLine("4-Kayıtlarda Ara");
    Console.WriteLine("5-Müşteri Ekle");
    Console.WriteLine("6-Kayıt Ekle");
    


    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            MusteriListele();
            break;
        case 2:
            MusteriAra();
            break;
        case 3:
            KayitlariListele();
            break;
        case 4:
            KayitlardaAra();
            break;
        case 5:
            // Müşteri Ekle
            break;
        case 6:
            KayitEkle();
            break;
        default:
            Console.WriteLine("Hatalı tuşlama yaptınız, tekrar deneyiniz");
            break;

    }


}




void MusteriListele()
{
    foreach (Musteri kisi in musteriler)
    {
        kisi.MusteriTanit();
    }
}

void MusteriAra()
{
    Console.WriteLine("Müşteri Arama Ekranı");
    Console.WriteLine("Aramak istediğiniz müşterinin adını giriniz:");
    string arama = Console.ReadLine();

    //Console.WriteLine("1-İsme Göre Ara");
    //Console.WriteLine("2-Soyada Göre Ara");
    //Console.WriteLine("3-İle Göre Ara");
    //Console.WriteLine("4-Telefon Numarasına Göre Ara");

   

    foreach (Musteri musteri in musteriler)
    {
        

        if (musteri.Ad.ToLower() == arama.ToLower())
        {        
            musteri.MusteriTanit();
        }
    }

    //Musteri musteri1 = musteriler.FirstOrDefault(musteri => musteri.Ad == arama);
    //musteri1.MusteriTanit();

    //try
    //{
    //    musteriler.FirstOrDefault(musteri => musteri.Ad == arama).MusteriTanit();
    //}
    //catch
    //{
    //    Console.WriteLine("Müşteri Bulunamadı!");
    //}
    
    
}

void KayitlariListele()
{
    Console.WriteLine("Kayıtları Listele");
    Console.WriteLine("1- Tüm kayıtlar");
    Console.WriteLine("2- Tamamlanan kayıtlar");
    Console.WriteLine("3- Devam Eden kayıtlar");

    int secim = int.Parse(Console.ReadLine());

    if (secim == 1)
    {
        foreach (Kayit kayit in kayitler)
        {
            kayit.KayitListele();
        }
    }else if (secim == 2)
    {
        foreach (Kayit kayit in kayitler)
        {
            if (kayit.Tamamlandi)
            {
                kayit.KayitListele();
            }
            
        }
    }else if (secim == 3)
    {
        foreach (Kayit kayit in kayitler)
        {
            if (!kayit.Tamamlandi)
            {
                kayit.KayitListele();
            }

        }
    }


    
}

void KayitlardaAra()
{
    Console.WriteLine("Kayıt Arama Ekranı");
    Console.WriteLine("Aramak istediğiniz kayıtın numarasını giriniz:");
    int arama = int.Parse(Console.ReadLine());

    



    foreach (Kayit kayit in kayitler)
    {
        if (kayit.KayitId == arama)
        {
            kayit.KayitListele();
        }
    }
}

void KayitEkle()
{
    Kayit kayit1 = new Kayit();

    Console.WriteLine("Kayıt Ekleme Sayfası");
    Console.WriteLine("Kayıt Id Giriniz:");

    kayit1.KayitId = int.Parse(Console.ReadLine());

    Console.WriteLine("Arıza mı başka bir işlem mi?");
    Console.WriteLine("Arıza ise 1'i Diğer işlem ise 2'yi tuşlayın");
    int secim1 = int.Parse(Console.ReadLine());
    if (secim1 == 1)
    {
        kayit1.Ariza = true;
    }else
    {
        kayit1.Ariza = false;
    }

    Console.WriteLine("İşlemin Fiyatını giriniz.");
    kayit1.Fiyat = int.Parse(Console.ReadLine());

    Console.WriteLine("İşem tamamlandı mı?");
    Console.WriteLine("Tamamlandı ise 1'i Hala devam ediyor ise 2'yi tuşlayın");
    int secim2 = int.Parse(Console.ReadLine());
    if (secim2 == 1)
    {
        kayit1.Tamamlandi = true;
    }
    else
    {
        kayit1.Tamamlandi = false;
    }

    // Müşteri Ara işlemi yapılır
    // Müşteri bulunduğunda direkt olarak kayit içindeki müşteri prop'una eklenir.
    

    Console.WriteLine("Aramak istediğiniz müşterinin adını giriniz:");
    string arama = Console.ReadLine();

    foreach (Musteri musteri in musteriler)
    {
        if (musteri.Ad.ToLower() == arama.ToLower())
        {
            kayit1.Musteri = musteri;
        }
    }

    kayitler.Add(kayit1);


    Console.WriteLine("Kayıt başarılı bir şekilde eklendi!");
}






class Urun
{
    public string marka { get; set; }
    public string model { get; set; }
    public int stok { get; set; }

}


class Musteri
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Il { get; set; }
    public int Telefon { get; set; }

    public void MusteriTanit()
    {
        Console.WriteLine("----------");
        Console.WriteLine("Müşteri Adı Soyadı: {0} {1}",Ad,Soyad);
        Console.WriteLine("Müşteri İl: {0}", Il);
        Console.WriteLine("Müşteri Telefon: 0{0}",Telefon);
        Console.WriteLine("----------");
    }

}

class Kayit 
{
    public int KayitId { get; set; }
    public bool Ariza { get; set; }
    public DateTime Tarih { get; set; }
    public int Fiyat { get; set; }
    public bool Tamamlandi { get; set; }

    public string Teknisyen { get; set; }

    public Urun TamirUrun { get; set; } = new Urun();

    public Musteri Musteri{ get; set; }  


    public void KayitListele()
    {
        Console.WriteLine("Kayıt Numarası: " + KayitId);
        if (Ariza)
        {
            Console.WriteLine("Kayıt Türü: Arıza");
        }
        else
        {
            Console.WriteLine("Kayıt Türü: Montaj");
        }
        Console.WriteLine("Fiyat Bilgisi: {0}",Fiyat);

        if (Tamamlandi)
        {
            Console.WriteLine("Tamamlandı");
        }
        else
        {
            Console.WriteLine("Devam Ediyor");
        }

        Console.WriteLine("Teknisten: {0}",Teknisyen);
        Console.WriteLine("Ürünün Markası: {0} - Ürünün Modeli: {1}",TamirUrun.marka,TamirUrun.model);
        Musteri.MusteriTanit();
    }


}


