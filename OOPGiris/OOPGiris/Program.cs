
int yas = 20;
string isim = "Tugay";


Console.WriteLine("{0} kişisinin yaşı {1}",isim,yas);


Ogrenci ogr1 = new Ogrenci();
ogr1.Ad = "Tugay";
ogr1.OrtNot = 70;
ogr1.Vize1 = 50;
ogr1.Vize2 = 60;
ogr1.Final = 70;
ogr1.AktifOgrenci = true;

Ogrenci ogr2 = new Ogrenci()
{
    Ad = "Mehmet",
    OrtNot = 50,
    Vize1 = 20,
    Vize2 = 30,
    Final = 40,
    AktifOgrenci = true
};


List<Ogrenci> OgrenciBilgileriListesi = new List<Ogrenci>();
OgrenciBilgileriListesi.Add(ogr1);
OgrenciBilgileriListesi.Add(ogr2);

foreach (Ogrenci ogr in OgrenciBilgileriListesi)
{
    ogr.BilgiYazdir();
}

Console.WriteLine(ogr1.Ad);
Console.WriteLine(ogr1.OrtNot);

//Console.WriteLine("Öğrencinin adı: {0}, Öğrencinin Not Ortalaması: {1}",ogr1.Ad,ogr1.OrtNot);

//Console.WriteLine("Öğrencinin adı: {0}, Öğrencinin Not Ortalaması: {1}", ogr2.Ad, ogr2.OrtNot);

ogr1.BilgiYazdir();
ogr2.BilgiYazdir();


class Ogrenci
{
    public string Ad { get; set; }
    public int OrtNot { get; set;}

    public int Vize1 { get; set; }
    public int Vize2 { get; set; }

    public int Final { get; set; }

    public bool AktifOgrenci { get; set; }

    public void BilgiYazdir()
    {
        Console.WriteLine("Öğrencinin adı: {0}, Öğrencinin Not Ortalaması: {1}, Vize1: {2}, Vize2: {3}, Final Notu: {4}", Ad, OrtNot,Vize1,Vize2,Final);
    }


}











