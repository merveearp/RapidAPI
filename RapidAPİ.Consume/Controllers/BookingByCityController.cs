using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidAPİ.Consume.Models;


namespace RapidAPİ.Consume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityId)
        {
            if (!string.IsNullOrEmpty(cityId))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?checkout_date=2026-03-05&filter_by_currency=EUR&order_by=popularity&dest_id={cityId}&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&locale=en-gb&dest_type=city&units=metric&include_adjacency=true&children_number=0&room_number=1&adults_number=2&page_number=0&checkin_date=2026-03-01"),
                    Headers =
                    {
                        { "x-rapidapi-key", "b64f56ed1emsh8afba1e8adc4772p11a325jsn1d2ee2523f59" },
                        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingAPIViewModel>(body);                
                    return View(values.results.ToList());
                }

            }

            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?checkout_date=2026-03-05&filter_by_currency=EUR&order_by=popularity&dest_id-755070&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&locale=en-gb&dest_type=city&units=metric&include_adjacency=true&children_number=0&room_number=1&adults_number=2&page_number=0&checkin_date=2026-03-01"),
                    Headers =
                    {
                        { "x-rapidapi-key", "b64f56ed1emsh8afba1e8adc4772p11a325jsn1d2ee2523f59" },
                        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingAPIViewModel>(body);
                    return View(values.results.ToList());
                }
            }
        }


    }
}
