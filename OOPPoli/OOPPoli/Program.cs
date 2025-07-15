Ogrenci o1 = new Ogrenci();
o1.Ad = "Tugay";
o1.Soyad = "Tuna";
o1.OgrenciNo = 121;
o1.OrtNot = 3.2;
o1.Meslek = "Öğrenci";
// Ogrenci tipinde bir nesne yaratıldı.

Ogretmen og1 = new Ogretmen();
og1.Ad = "Metin";
og1.Soyad = "Ok";
og1.Kadro = true;
og1.Brans = "Yazılım";
og1.Meslek = "Öğretmen";
// Ogretmen tipinde bir nesne yaratıldı.


// Ogrenci nesnesinin bilgileri ekrana yazdırıldı.
Console.WriteLine("{0} numaralı, ismi {1} olan öğrencinin ortalama notu: {2}",o1.OgrenciNo,o1.Ad,o1.OrtNot);



//List<Ogrenci> ogrenciler = new List<Ogrenci>();
//ogrenciler.Add(o1);

//List<Ogretmen> ogretmenler = new List<Ogretmen>();
//ogretmenler.Add(og1);

// Ayrı ayrı listeler oluşturabileceğimizi gördük.


// Kisi üst sınıf olduğu için, farklı classları bir arada ekleyebiliyoruz.
List<Kisi> personeller = new List<Kisi>();
personeller.Add(o1);
personeller.Add(og1);




Console.WriteLine("--Tüm Personeller--");
foreach (Kisi personel in personeller)
{
    Console.WriteLine("Ad: {0}, Soyad: {1}, Meslek: {2}",personel.Ad, personel.Soyad,personel.Meslek);

    //if (personel.Meslek == "Öğretmen")
    //{
    //    Console.WriteLine(personel);
    //}

}



class Kisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }   
    public string Meslek { get; set; }
}



class Ogrenci : Kisi
{
    //public string Ad { get; set; }
    //public string Soyad { get; set; }
    public int OgrenciNo { get; set; }
    public double OrtNot { get; set; }
}

class Ogretmen : Kisi
{
    //public string Ad { get; set; }
    //public string Soyad { get; set; }
    public string Brans { get; set; }
    public bool Kadro { get; set; }

}

