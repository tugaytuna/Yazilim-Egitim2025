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
            var ogrenci1 = new Ogrenci()
            {
                Id = 1,
                Ad = "Tugay",
                Aktif = true,
                Sinif = 11,
                Yas = 20
            };


            //var ogrenci2 = new Ogrenci();
            //ogrenci2.Id = 2;
            //ogrenci2.Aktif = true;
            return View(ogrenci1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
