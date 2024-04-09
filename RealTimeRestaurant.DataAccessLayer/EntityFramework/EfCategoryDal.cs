using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(RealTimeRestaurantContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
