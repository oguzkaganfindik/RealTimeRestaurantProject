using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
