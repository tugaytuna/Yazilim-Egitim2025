
Console.WriteLine("Kullanıcı arama ekranına hoş geldiniz!");
Console.WriteLine("Lütfen kullanıcı adını giriniz");


string arama = Console.ReadLine();

List<string> isimler = new List<string>()
{
    "Elif","Levent","Metin","Öner","Sibel","Tugay"
};



//string sonuc = isimler.FirstOrDefault(isim => isim == "Tugay");
//string sonuc = isimler.FirstOrDefault(kk => kk.Contains('l'));


string sonuc = isimler.FirstOrDefault(item => item == arama); // Kullanıcıdan aldığımız değeri arıyoruz.

if (sonuc != null) // sonuc boş değilse
{
    Console.WriteLine("Sonuç: " + sonuc);
}

if (sonuc == null) // sonuc boş ise
{
    Console.WriteLine("Aradığınız kullanıcı bulunamadı!");
}



//foreach (string isim in isimler)
//{
//    if (isim == "Tugay")
//    {
//        Console.WriteLine(isim);
//    }

//    Console.WriteLine(isim);
//}



Console.WriteLine("Kaç yaşında olduğunuzu giriniz");
int yas = 0;
try // denemek
{
    // Hata alma potansiyelimiz olan durumlarda 'deneme' yapar.
    yas = int.Parse(Console.ReadLine());
    Console.WriteLine("Yaşınız: " + yas);
}
catch (Exception ex) // Hata gerçekleşti
{
    // Yalnızca hata ile karşılaşıldığında çalışır.
    Console.WriteLine("Yalnızca rakam girmeniz gerekiyor.");
    Console.WriteLine(ex.Message);
    

}
finally // Tüm bu sürecin sonunda kesinlikle çalışır
{
    Console.WriteLine("Ana sayfaya dön");
}


List<string> isimlerListesi = new List<string>();
Dictionary<int, string> isimlerKutuphanesi = new Dictionary<int, string>();

isimlerKutuphanesi.Add(123, "Ali");
isimlerKutuphanesi.Add(555, "Ayşe");


Console.WriteLine(isimlerKutuphanesi[123]);

Dictionary<string, string> kitaplar = new Dictionary<string, string>();

kitaplar.Add("kitap1", "Nutuk");
kitaplar.Add("kitap2", "Sefiller");

Console.WriteLine(kitaplar["kitap1"]);





