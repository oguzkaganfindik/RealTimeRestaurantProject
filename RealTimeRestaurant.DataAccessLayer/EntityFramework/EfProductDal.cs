using Microsoft.EntityFrameworkCore;
using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        //private readonly RealTimeRestaurantContext _context;
        //public EfProductDal(RealTimeRestaurantContext context) : base(context)
        //{
        //    _context = context;
        //}
        // TODO: Daha sonra D.I. yapacağım.

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

        public string ProductNameByMaxPrice()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new RealTimeRestaurantContext();
            {
                return context.Products.Average(x => x.Price);
            }
        }

        public decimal ProductAvgPriceByHamburger()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Average(w => w.Price);
        }

        public decimal ProductPriceBySteakBurger()
        {
            using var context = new RealTimeRestaurantContext();
            {
                return context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();
            }
        }

        public decimal TotalPriceByDrinkCategory()
        {
            using var context = new RealTimeRestaurantContext();
            int id = context.Categories.Where(x => x.CategoryName == "içecek").Select(y => y.CategoryId).FirstOrDefault();
            return context.Products.Where(x => x.CategoryId == id).Sum(y => y.Price);
        }

        public decimal TotalPriceBySaladCategory()
        {
            using var context = new RealTimeRestaurantContext();
            int id = context.Categories.Where(x => x.CategoryName == "Salata").Select(y => y.CategoryId).FirstOrDefault();
            return context.Products.Where(x => x.CategoryId == id).Sum(y => y.Price);
        }
    }
}
