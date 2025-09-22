using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewBagOrnekler.Models;

namespace ViewBagOrnekler.Controllers
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
            ViewData["Yas"] = 20;
            ViewBag.Message = "Çýkýþ Yapýldý!";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Tarih = DateTime.Now;
            DateTime dt = new DateTime(2025, 12, 31,23,59,59);
         
            ViewBag.GeriSayim = (dt - DateTime.Now);
            ViewBag.GeriSayimSaat = (dt.Hour - DateTime.Now.Hour);
            ViewBag.GerisayimDk = (dt.Minute - DateTime.Now.Minute);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
