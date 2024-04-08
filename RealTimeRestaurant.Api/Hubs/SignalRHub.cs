using Microsoft.AspNetCore.SignalR;
using RealTimeRestaurant.DataAccessLayer.Concrete;

namespace RealTimeRestaurant.Api.Hubs
{
    public class SignalRHub : Hub
    {
        RealTimeRestaurantContext context = new RealTimeRestaurantContext();

        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}