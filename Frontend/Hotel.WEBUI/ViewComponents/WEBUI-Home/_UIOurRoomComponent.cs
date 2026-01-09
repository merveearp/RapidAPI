using Hotel.WEBUI.Dtos.RoomDtos;
using Hotel.WEBUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotel.WEBUI.ViewComponents.WEBUI_Home
{
    public class _UIOurRoomComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _UIOurRoomComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5178/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
