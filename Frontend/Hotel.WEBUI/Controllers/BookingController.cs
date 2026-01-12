using Hotel.WEBUI.Dtos.BookingDtos;
using Hotel.WEBUI.Dtos.SubscribeDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Hotel.WEBUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
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
                return RedirectToAction("Index", "Booking");
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
                TempData["Message"] = "E-posta adresiniz başarıyla bültenimize kaydedildi.";
            }
            else
            {
                TempData["Error"] = "Bülten kaydı sırasında bir hata oluştu.";
            }

            return RedirectToAction("Index", "Booking");
        }

        [HttpGet]
        public PartialViewResult _AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _AddBooking(CreateBookingDto bookingDto)
        {
           
            bookingDto.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(bookingDto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync( "http://localhost:5178/api/Booking",content);
            Console.WriteLine((int)response.StatusCode);
            if (response.IsSuccessStatusCode)
            {
                TempData["Message"] = "Rezervasyonunuz başarıyla alınmıştır.";
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine(error);

                TempData["Error"] = "Rezervasyon sırasında bir hata oluştu.";
            }

            return RedirectToAction("Index", "Booking");
        }
    }
}
