using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
