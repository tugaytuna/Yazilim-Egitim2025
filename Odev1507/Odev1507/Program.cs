Kurs k1 = new Kurs()
{
    Ad = "Yazılım Eğitimi",
    EgitmenAdi = "Tugay Tuna",
    KursKodu = 1414,
    MaksKontenjan = 5
};

Kurs k2 = new Kurs()
{
    Ad = "Grafik Tasarım Eğitimi",
    EgitmenAdi = "Levent Akgül",
    KursKodu = 1254,
    MaksKontenjan = 8
};

Kurs k3 = new Kurs()
{
    Ad = "Web Tasarım Eğitimi",
    EgitmenAdi = "Metin Ok",
    KursKodu = 1701,
    MaksKontenjan = 10
};

Kurs k4 = new Kurs()
{
    Ad = "Resim Eğitimi",
    EgitmenAdi = "Sibel Katar",
    KursKodu = 8795,
    MaksKontenjan = 4
};

Ogrenci o1 = new Ogrenci()
{
    Ad = "Elif",
    KayitliKurslar = {k1,k2},
    OgrenciNumarasi = 1414
};

Ogrenci o2 = new Ogrenci()
{
    Ad = "Tolga",
    KayitliKurslar = { k2, k3 },
    OgrenciNumarasi = 4154
};

Ogrenci o3 = new Ogrenci()
{
    Ad = "İzel",
    KayitliKurslar = { k4, k1 },
    OgrenciNumarasi = 5787
};



List<Kurs> kurslar = new List<Kurs>();
kurslar.Add(k1);
kurslar.Add(k2);
kurslar.Add(k3);
kurslar.Add(k4); 


List<Ogrenci> ogrenciler = new List<Ogrenci>()
{
    o1,o2,o3
};

while (true) {

    Console.WriteLine("---- Kurs Takip Programı ----");
    Console.WriteLine("1- Öğrenci Ekleme");
    Console.WriteLine("2- Kurs Ekleme");
    Console.WriteLine("3- Kurs Bilgilerini Yazdırma");
    Console.WriteLine("4- Öğrencinin Kurs Bilgileri");
    Console.WriteLine("5- Öğrenciye Kurs Ekleme");

    string secim = Console.ReadLine();

    switch (secim)
    {
        case "1":
            OgrenciEkleme();
            break;
        case "2":
            KursEkleme();
            break;
        case "3":
            KursBilgileriniYazdir();
            break;
        case "4":
            OgrencininKursBilgileri();
            break;
        case "5":
            OgrenciyeKursEkle();
            break;
        default:
            Console.WriteLine("Hatalı tuşlama yaptınız!");
            break;

    }
}

void OgrenciEkleme()
{
    Ogrenci ogrenci1 = new Ogrenci();

    Console.WriteLine("Öğrencinin Adı:");
    ogrenci1.Ad = Console.ReadLine();

    Console.WriteLine("Öğrencinin Numarası:");
    ogrenci1.OgrenciNumarasi = int.Parse(Console.ReadLine());

    //Ogrenci ogrenci1 = new Ogrenci()
    //{
    //    Ad = ogrenciAd,
    //    OgrenciNumarasi = ogrenciNumarasi
    //};


    ogrenciler.Add(ogrenci1);
    Console.WriteLine("Öğrenci başarıyla eklendi!");
}

void KursEkleme()
{
    Kurs kurs1 = new Kurs();


    Console.WriteLine("Kursun Adı:");
    kurs1.Ad = Console.ReadLine();

    Console.WriteLine("Kursun Kodu:");
    kurs1.KursKodu = int.Parse(Console.ReadLine());

    Console.WriteLine("Eğitmenin Adı:");
    kurs1.EgitmenAdi = Console.ReadLine();

    Console.WriteLine("Maks Kontenjan:");
    kurs1.MaksKontenjan = int.Parse(Console.ReadLine());


    //Kurs kurs1 = new Kurs()
    //{
    //    Ad = KursAd,
    //    EgitmenAdi = egitmenAd,
    //    KursKodu = kursKodu,
    //    MaksKontenjan = maksKont
    //};
   


    kurslar.Add(kurs1);
    Console.WriteLine("Kurs kaydı başarıyla eklendi!");
}

void KursBilgileriniYazdir()
{
    foreach (Kurs kurs in kurslar)
    {
        kurs.KursBilgi();
    }
}

void OgrencininKursBilgileri()
{
    Console.WriteLine("Öğrencinin Numarasını Giriniz:");
    int ogNo = int.Parse(Console.ReadLine());

    foreach (Ogrenci og in ogrenciler)
    {
        if (og.OgrenciNumarasi == ogNo)
        {
            og.KayitliKurslariListele();
            return;
        }
    }
    Console.WriteLine("{0} numaralı öğrenci kayıtlarda yoktur!", ogNo);



}

void OgrenciyeKursEkle() 
{
    Console.WriteLine("Öğrencinin Numarasını Giriniz:");
    int ogNo = int.Parse(Console.ReadLine());

    Console.WriteLine("Kurs Kodunu Giriniz:");
    int kursKod = int.Parse(Console.ReadLine());


    //foreach (Kurs kurs in kurslar)
    //{
    //    if (kursKod == kurs.KursKodu)
    //    {
    //        KursKaydet(kurs);
    //    }
    //}

    //foreach (Ogrenci og in ogrenciler)
    //{
    //    if (og.OgrenciNumarasi == ogNo)
    //    {
    //        og.KayitliKurslar.Add(kursOrnek);
    //        kursOrnek.MaksKontenjan -= 1;
    //        Console.WriteLine("Kurs başarılı bir şekilde kaydedildi.");
    //    }
    //}

    Kurs kursOrnek = kurslar.FirstOrDefault(kurs => kursKod == kurs.KursKodu);
    Ogrenci ogrenciOrnek = ogrenciler.FirstOrDefault(og => og.OgrenciNumarasi == ogNo);

    ogrenciOrnek.KayitliKurslar.Add(kursOrnek);
    kursOrnek.MaksKontenjan -= 1;
    Console.WriteLine("Kurs başarılı bir şekilde kaydedildi.");




}





class Kurum
{
    public string Ad { get; set; }
}


class Kurs : Kurum
{
    //1. Kurs sınıfı 
    //kurs adı kurs kodu eğitmen adı ve maks kontenjan özellikler tanımla
    //kursun temel bilgilerini döndüren bir metot yazın

    public int KursKodu { get; set; }
    //public string KursAdi { get; set; }

    public string EgitmenAdi { get; set; }

    public int MaksKontenjan { get; set; }

    public void KursBilgi()
    {
        Console.WriteLine("----");
        Console.WriteLine("Kurs kodu: " + KursKodu);
        Console.WriteLine("Kurs adı: " + Ad);
        Console.WriteLine("Eğitmen adı: " + EgitmenAdi);
        Console.WriteLine("Maksimum kontenjan: "+ MaksKontenjan);
        Console.WriteLine("----");
    }
}

class Ogrenci : Kurum
{
    //    2. Öğrenci sınıfı
    //öğrenci adı öğrenci numarası ve kayıtlı kurslar(list<course>)gibi özellikler tanımlayın


    public int OgrenciNumarasi{ get; set; }

    public List<Kurs> KayitliKurslar { get; set; } = new List<Kurs>();
    //public List<int> KayitliKursKodlari { get; set; } = new List<int>();


    

    public void KayitliKurslariListele()
    {
        Console.WriteLine("Kullanıcının kayıtlı olduğu kurslar listeleniyor.");
        foreach (Kurs kk in KayitliKurslar)
        {
            kk.KursBilgi();
        }
    }


}