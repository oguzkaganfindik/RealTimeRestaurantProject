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
    }
}
