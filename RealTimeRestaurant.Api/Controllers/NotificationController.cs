using Microsoft.AspNetCore.Mvc;
using RealTimeRestaurant.BusinessLayer.Abstract;

namespace RealTimeRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public ActionResult NotificationList() 
        {
            return Ok(_notificationService.TGetListAll());
        }
    }
}
