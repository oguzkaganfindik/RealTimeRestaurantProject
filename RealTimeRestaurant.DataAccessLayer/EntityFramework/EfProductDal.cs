using Microsoft.EntityFrameworkCore;
using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(RealTimeRestaurantContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new RealTimeRestaurantContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "içecek").Select(z => z.CategoryId).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Count();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new RealTimeRestaurantContext();
            {
                return context.Products.Average(x => x.Price);
            }
        }
    }
}
