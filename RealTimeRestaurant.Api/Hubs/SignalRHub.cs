using Microsoft.AspNetCore.SignalR;
using RealTimeRestaurant.BusinessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;

namespace RealTimeRestaurant.Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;


        public SignalRHub(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task SendCategoryCount()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }

        public async Task SendProductCount()
        {
            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);
        }
    }
}