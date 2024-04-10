using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(RealTimeRestaurantContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public int TotalOrderCount()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Orders.Count();
        }
    }
}
