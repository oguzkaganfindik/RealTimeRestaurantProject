using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
