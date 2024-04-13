using Microsoft.AspNetCore.Mvc;
using RealTimeRestaurant.BusinessLayer.Abstract;

namespace RealTimeRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet]
        public ActionResult SliderList() 
        { 
            return Ok(_sliderService.TGetListAll());
        }
    }
}
