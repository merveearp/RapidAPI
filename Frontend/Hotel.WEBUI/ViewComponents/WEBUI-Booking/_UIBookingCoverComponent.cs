using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBUI.ViewComponents.WEBUI_Booking
{
    public class _UIBookingCoverComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
