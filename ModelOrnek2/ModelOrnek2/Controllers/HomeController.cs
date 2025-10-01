using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelOrnek2.Models;

namespace ModelOrnek2.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Araclar()
        {
            Arac arac1 = new Arac();
            arac1.AracId = 1;
            arac1.Marka = "Toyota";
            arac1.Model = "Corolla";
            arac1.Hazir = true;
            arac1.Vites = true;
            arac1.Yil = 2020;
            arac1.Kilometre = 45000;
            arac1.GunlukKira = 750;
            arac1.GorselUrl = "https://images.unsplash.com/photo-1623869675781-80aa31012a5a?q=80&w=1154&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";



            List<Arac> araclar = new List<Arac>
        { arac1,
            new Arac
            {
                AracId = 2,
                Marka = "Toyota",
                Model = "Corolla",
                Yil = 2021,
                Vites = true,
                GunlukKira = 750,
                Kilometre = 45000,
                Hazir = true,
                GorselUrl = "https://images.unsplash.com/photo-1717711081688-985a7a3e6a9f?q=80&w=1332&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\r\n"
            },
            new Arac
            {
                AracId = 3,
                Marka = "Volkswagen",
                Model = "Golf",
                Yil = 2019,
                Vites = false,
                GunlukKira = 650,
                Kilometre = 60000,
                Hazir = false,
                GorselUrl = "https://images.unsplash.com/photo-1683444112252-41c5ddf73815?q=80&w=1469&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            },
            new Arac
            {
                AracId = 4,
                Marka = "BMW",
                Model = "320i",
                Yil = 2021,
                Vites = true,
                GunlukKira = 1200,
                Kilometre = 30000,
                Hazir = true,
                GorselUrl = "https://images.unsplash.com/photo-1630357431823-4df30ae338b0?q=80&w=1471&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            },
            new Arac
            {
                AracId = 5,
                Marka = "Renault",
                Model = "Clio",
                Yil = 2018,
                Vites = false,
                GunlukKira = 500,
                Kilometre = 80000,
                Hazir = true,
                GorselUrl = "https://images.unsplash.com/photo-1666335009164-2597314da8e7?q=80&w=1470&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            },
            new Arac
            {
                AracId = 6,
                Marka = "Mercedes",
                Model = "C200",
                Yil = 2022,
                Vites = true,
                GunlukKira = 1400,
                Kilometre = 20000,
                Hazir = true,
                GorselUrl = "https://images.unsplash.com/photo-1584936684506-c3a7086e8212?q=80&w=2647&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
            }
        };





            return View(araclar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
