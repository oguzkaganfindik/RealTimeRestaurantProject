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
    }
}
