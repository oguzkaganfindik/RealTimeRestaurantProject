﻿using Microsoft.AspNetCore.Mvc;

namespace RealTimeRestaurant.WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
