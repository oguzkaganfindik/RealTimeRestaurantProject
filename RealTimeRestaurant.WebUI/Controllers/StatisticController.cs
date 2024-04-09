using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
