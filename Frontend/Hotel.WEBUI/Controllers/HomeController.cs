using Hotel.WEBUI.Dtos.SubscribeDtos;
using Hotel.WEBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace Hotel.WEBUI.Controllers
{

    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _UISubscribeComponent()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _UISubscribeComponent(CreateSubscribeDto subscribeDto)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Geçersiz e-posta adresi.";
                return RedirectToAction("Index", "Home");
            }

            var client = _httpClientFactory.CreateClient();

            var jsonData = JsonConvert.SerializeObject(subscribeDto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync(
                "http://localhost:5178/api/Subscribe",
                content
            );

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Message"] = "E-posta adresiniz baþarýyla bültenimize kaydedildi.";
            }
            else
            {
                TempData["Error"] = "Bülten kaydý sýrasýnda bir hata oluþtu.";
            }

            return RedirectToAction("Index", "Home");
        }



    }
}
