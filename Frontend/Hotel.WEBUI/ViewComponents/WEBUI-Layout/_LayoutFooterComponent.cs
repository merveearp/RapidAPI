using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBUI.ViewComponents.WEBUI_Layout
{
    public class _LayoutFooterComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
