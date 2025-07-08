Console.WriteLine("1. Kullanıcının adını giriniz. ");
Ogrenci o1 = new Ogrenci(Console.ReadLine());

Console.WriteLine("1. Kullanıcının soyadını giriniz. ");
o1.Soyad = Console.ReadLine();


o1.BilgiYazdir();



Ogrenci o2 = new Ogrenci("Tugay", "Tuna");
o2.BilgiYazdir();


class Ogrenci
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    // this

    public Ogrenci(string ad)
    {
        Ad = ad.ToLower();
        Soyad = "Bilinmiyor";
    }
     
    public Ogrenci(string ad, string soyad)
    {
        Ad = ad.ToLower();
        Soyad = soyad.ToLower();
    }

    public void BilgiYazdir()
    {
        Console.WriteLine("Kullanıcının adı: {0}, soyadı: {1}", Ad, Soyad);
    }
}