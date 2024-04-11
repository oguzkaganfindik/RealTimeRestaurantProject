using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        public EfMenuTableDal(RealTimeRestaurantContext context) : base(context)
        {           
        }

        public int MenuTableCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.MenuTables.Count();
        }
    }
}
