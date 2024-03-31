using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
