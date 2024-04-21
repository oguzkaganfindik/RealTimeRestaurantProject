using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(RealTimeRestaurantContext context) : base(context)
        {            
        }

        public List<Notification> GetAllNotificationsByFalse()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Notifications.Where(x => x.Status == false).ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Notifications.Where(x => x.Status == false).Count();
        }
    }
}
