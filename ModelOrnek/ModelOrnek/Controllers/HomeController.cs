using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelOrnek.Models;

namespace ModelOrnek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Ad = "Tugay";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Ad = "Tuna";
            return View();
        }

        public IActionResult OgrenciDetay()
        {
            //Oluþturma zamanýnda listeye item eklemek
            //List<string> yazilar = new List<string>()
            //{
            //    "asdasd","sadasd","asdasd"
            //};

            //Boþ liste oluþturup item ekleme
            //List<string> yazilar = new List<string>();
            //yazilar.Add("asdasd");

            //Listenin itemlarýný ekrana yazdýrma
            //foreach (string yazi in yazilar) {
            //    Console.WriteLine(yazi);
            //}


            List<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci()
                {
                    Id=1,
                    Ad="Tugay",
                    Aktif=true,
                    Sinif=11,
                    Yas=15,
                },
                new Ogrenci()
                {
                    Id=2,
                    Ad="Metin",
                    Aktif=true,
                    Sinif=12,
                    Yas=18,
                },
                new Ogrenci()
                {
                    Id=3,
                    Ad="Elif",
                    Aktif=false,
                    Sinif=9,
                    Yas=14,
                },
                new Ogrenci()
                {
                    Id=4,
                    Ad="Öner",
                    Aktif=true,
                    Sinif=10,
                    Yas=16,
                },
                new Ogrenci()
                {
                    Id=5,
                    Ad="Sibel",
                    Aktif = true,
                    Sinif=11,
                    Yas=17,
                },
                new Ogrenci()
                {
                    Id=6,
                    Ad="Levent",
                    Aktif=false,
                    Sinif=9,
                    Yas=14,
                }
            };


            Ogrenci ogrenci1 = new Ogrenci()
            {
                Id = 1,
                Ad = "Tugay",
                Aktif = true,
                Sinif = 11,
                Yas = 20
            };

        




            //Ogrenci ogrenci2 = new Ogrenci();
            //ogrenci2.Id = 2;
            //ogrenci2.Aktif = true;
            return View(ogrenciler);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
