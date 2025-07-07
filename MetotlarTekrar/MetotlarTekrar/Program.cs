// Switch-case örneği, int ile.

string isim = "Ahmet";
switch (isim)
{
    case "Ahmet":
        Console.WriteLine("Ahmet bey hoş geldiniz");
        break;
    case "Tugay":
        Console.WriteLine("Admin hoş geldiniz");
        break;
    case "Tolga":
        Console.WriteLine("Tolga bey hoş geldiniz");
        break;
    default:
        Console.WriteLine("Hatalı tuşlama yaptınız");
        break;

}


// Switch-case örneği, string tipinde kullanıcan değer alarak.



int gun = int.Parse(Console.ReadLine());
switch (gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;

    default:
        Console.WriteLine("Hatalı tuşlama yaptınız");
        break;
}


int toplama(int x, int y)
{
    x += 20;
    y += 10;

   
    return x + y;
}


Console.WriteLine(toplama(5, 5));

int islem = toplama(15, 70);
Console.WriteLine(islem);


Console.WriteLine("İsminizi giriniz");
string name = Console.ReadLine(); // Kullanıcıdan isim değeri alınır.




string editName(string ad)
{
    ad = char.ToUpper(ad[0]) + ad.Substring(1).ToLower(); // İlk harfi büyük geri kalan küçük olan kod.

    return ad;
 
}

Console.WriteLine(editName(name));
name = editName(name); // Name değişkenini güncelle, fonksiyonda düzenlenmiş haliyle



// fonksiyona 2 tane rakam vereceğim, bu rakamlar büyük olanı bana geri döndürsün


string enBuyuk(int x, int y)
{
    if (x > y)
    {
        return x+" bu rakam daha büyüktür!";
    }else if (y > x)
    {
        return y+ " bu rakam daha büyüktür!";
    }
    else
    {
        return "Rakamlar birbirine eşittir";
    }
}

int unreadMes1 = 10;
int unreadMes2 = 5;


Console.WriteLine(enBuyuk(10,20));
Console.WriteLine(enBuyuk(30, 20));
Console.WriteLine(enBuyuk(unreadMes1,unreadMes2));
Console.WriteLine(enBuyuk(5, 5));








