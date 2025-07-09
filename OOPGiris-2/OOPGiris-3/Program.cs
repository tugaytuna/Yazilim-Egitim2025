
SatilikEv ev1 = new SatilikEv();
ev1.IlaninAdi = "5+2 Muhteşem Manzaralı Ev!";
ev1.MetreKare = 320;
ev1.Balkon = true;
ev1.Garaj = false;
ev1.OdaAdet = 5;
ev1.SalonAdet = 2;
ev1.Bahce = true;
ev1.Adres = "Konak, İzmir";

//ev1.EvBilgileri();


SatilikEv ev2 = new SatilikEv();
ev2.IlaninAdi = "Küçük tatlı ev";
ev2.MetreKare = 80;
ev2.Balkon = true;
ev2.Garaj = false;
ev2.OdaAdet = 2;
ev2.SalonAdet = 1;
ev2.Bahce = false;
ev2.Adres = "Kadıköy, İstanbul";

//ev2.EvBilgileri();


List<SatilikEv> evlerListesi = new List<SatilikEv>();
evlerListesi.Add(ev1);
evlerListesi.Add(ev2);


foreach (SatilikEv ev in evlerListesi)
{
    Console.WriteLine("---------------");
    ev.EvBilgileri();
    Console.WriteLine("---------------");
}

// this


class SatilikEv()
{
    public string IlaninAdi { get; set; }
    public int MetreKare { get; set; }

    public int SalonAdet { get; set; }
    public int OdaAdet { get; set; }

    public bool Balkon { get; set; }

    public bool Bahce { get; set; }

    public bool Garaj { get; set; }

    private double Puan { get; set; }

    public  string Adres { get; set; }  

    private void PuanHesapla()
    {
        Puan = 0;
        if (Balkon)
        {
            Puan += 1;
        }
        //Puan += (Balkon) ? 1 : 0;

        if (Bahce)
        {
            Puan += 2;
        }

        if (Garaj)
        {
            Puan += 1;
        }

        if (MetreKare < 200 && MetreKare > 100) 
        {
            Puan += 1;
        }else if (MetreKare > 200) 
        {
            Puan += 2;
        }

        if (SalonAdet > 1 && OdaAdet > 2)
        {
            Puan += 3;
        }

    }


    public void EvBilgileri()
    {
        Console.WriteLine("{0} ilanı için bilgiler aşağıdadır.",IlaninAdi);
        Console.WriteLine("İlandaki ev {0} metrekare olup, {1}+{2}'dir.",MetreKare,OdaAdet,SalonAdet);
        
        if (Balkon)
        {
            Console.WriteLine("İlandaki ev balkonludur.");
        }else
        {
            Console.WriteLine("İlandaki evin balkonu yoktur.");
        }

        if (Bahce)
        {
            Console.WriteLine("İlandaki ev bahçelidir.");
        }
        else
        {
            Console.WriteLine("İlandaki evin bahçesi yoktur.");
        }

        if (Garaj)
        {
            Console.WriteLine("İlandaki evin garajı vardır. Rahatça arabanızı park edebilirsiniz.");
        }
        else
        {
            Console.WriteLine("İlandaki evin garajı yoktur.");
        }
        PuanHesapla();
        Console.WriteLine("İlandaki evin puanı: {0}",Puan);
        Console.WriteLine("İlandaki evin adresi: {0}",Adres);


    }


}