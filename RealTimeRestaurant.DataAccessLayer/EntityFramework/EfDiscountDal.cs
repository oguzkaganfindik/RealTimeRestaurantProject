using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(RealTimeRestaurantContext context) : base(context)
        {
        }

        public void ChangeStatusToFalse(int id)
        {
            using var context = new RealTimeRestaurantContext();
            var value = context.Discounts.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeStatusToTrue(int id)
        {
            using var context = new RealTimeRestaurantContext();
            var value = context.Discounts.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
