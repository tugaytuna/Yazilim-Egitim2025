
Kedi kedi1 = new Kedi();
kedi1.Ad = "Petito";
kedi1.KediCinsi = "Tekir";

Kopek kopek1 = new Kopek();
kopek1.Ad = "Dost";
kopek1.KopekCinsi = "Golden";

Civciv civ1 = new Civciv();
civ1.Ad = "Sarı";
civ1.TuyBilgisi = "Düz";


List<Hayvan> hayvanlar = new List<Hayvan>();
hayvanlar.Add(kedi1);
hayvanlar.Add(kopek1);
hayvanlar.Add(civ1);

// Sorunsuz çalışıyor 
//kedi1.SesCıkar(); // Miyav Miyav
//kopek1.SesCıkar(); // Hav hav


foreach (Hayvan hay in hayvanlar)
{
    hay.SesCıkar();
}



class Hayvan
{
    public string Ad { get; set; }
    public virtual void SesCıkar()
    {
        Console.WriteLine("Bir hayvan sesi!");
    }
}

class Civciv : Hayvan
{
    public string TuyBilgisi { get; set; }
}

class Kedi : Hayvan
{
    public string KediCinsi { get; set; }

    public override void SesCıkar()
    {
        Console.WriteLine("Miyav Miyav");
    }
}

class Kopek : Hayvan
{
    public string KopekCinsi { get; set; }

    public override void SesCıkar()
    {
        Console.WriteLine("Hav hav!");
    }

}