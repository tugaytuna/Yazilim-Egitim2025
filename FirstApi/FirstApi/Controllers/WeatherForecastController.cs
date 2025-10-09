using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
     

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Urun Get()
        {
            Urun urun1 = new Urun()
            {
                UrunId = 1,
                UrunAdi = "Yumurta",
                SKT = new DateOnly(2025, 11, 1),
                StokAdet = 200,
                Stokta = true,
                UrunFiyat = 15,
            };

            Urun urun2 = new Urun()
            {
                UrunId = 2,
                UrunAdi = "Süt",
                SKT = new DateOnly(2025, 10, 15),
                StokAdet = 100,
                Stokta = true,
                UrunFiyat = 55,
            };

            List<Urun> urunler = new List<Urun>() { urun1, urun2 };

            return urun1;
        }
    }
}
