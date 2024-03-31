using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
