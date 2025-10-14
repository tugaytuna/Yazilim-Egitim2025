using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{


    [Route("First")]
    [ApiController]
    public class FirstController : ControllerBase
    {

        List<Urun> urunler = new List<Urun>() { new Urun()
        {
            UrunId = 1,
            UrunAdi = "Yumurta",
            SKT = new DateOnly(2025, 11, 1),
            StokAdet = 200,
            Stokta = true,
            UrunFiyat = 15,
        }, new Urun()
        {
            UrunId = 2,
            UrunAdi = "Süt",
            SKT = new DateOnly(2025, 10, 15),
            StokAdet = 0,
            Stokta = false,
            UrunFiyat = 55,
        } };


        [HttpGet]
        public IActionResult GetMrb()
        {
            return Ok(urunler);
        }


        [HttpGet("Tugay")]
        public string GetTugay()
        {
            return urunler[1].UrunAdi;
            //return "Merhaba";
        }

        [HttpGet("{id}")]
        public IActionResult UrunlerId(int id) {

            var urun1 = urunler.FirstOrDefault(u => u.UrunId == id);
            // Eğer ilgili id'de ürün yoksa geriye olmadığını döndür
            if (urun1 == null)
            {
                return NotFound("Ürün bulunamadı");
            }

            string stokDegeri = "";
            if (urun1.StokAdet > 0)
            {
                stokDegeri = "Stokta";
            }
            else
            {
                stokDegeri = "Stokta Değil";
            }
                var result = new { Urunismi = urun1.UrunAdi.ToUpper(), Stok = stokDegeri };
            return Ok(result);
            //return Ok(urun1);
        }



        [HttpGet("jsonDeger")]
        public IActionResult GetJsonDeger()
        {
            var info = new { id = 1, developer = "Tugay Tuna" };
            return Ok(info);
        }





    }
}
