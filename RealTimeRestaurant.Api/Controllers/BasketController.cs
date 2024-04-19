using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealTimeRestaurant.Api.Models;
using RealTimeRestaurant.BusinessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DtoLayer.BasketDto;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new RealTimeRestaurantContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableId == id).Select(z => new ResultBasketListWithProducts
            {
                BasketId = z.BasketId,
                Count = z.Count,
                MenuTableId = z.MenuTableId,
                Price = z.Price,
                ProductId = z.ProductId,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName,

            }).ToList();
            
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new RealTimeRestaurantContext();
            _basketService.TAdd(new Basket()
            {
                ProductId = createBasketDto.ProductId,
                Count = 1,
                MenuTableId = 4,
                Price = context.Products.Where(x => x.ProductId == createBasketDto.ProductId).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = 0,
            });
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBasket(int id) 
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}
