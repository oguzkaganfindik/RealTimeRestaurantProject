﻿using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.ViewComponents.MenuComponents
{
    public class _MenuNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
