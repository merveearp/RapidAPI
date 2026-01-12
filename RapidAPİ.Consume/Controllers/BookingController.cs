using Microsoft.AspNetCore.Mvc;

namespace RapidAPİ.Consume.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
