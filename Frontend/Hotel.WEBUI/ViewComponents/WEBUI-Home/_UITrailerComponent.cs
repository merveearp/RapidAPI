using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBUI.ViewComponents.WEBUI_Home
{
    public class _UITrailerComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}

