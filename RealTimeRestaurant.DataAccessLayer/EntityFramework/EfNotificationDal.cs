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

        public void NotificationStatusChangeToFalse(int id)
        {
            using var context = new RealTimeRestaurantContext();
            var value = context.Notifications.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            using var context = new RealTimeRestaurantContext();
            var value = context.Notifications.Find(id);
            value.Status = true;
            context.SaveChanges();
        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new RealTimeRestaurantContext();
            return context.Notifications.Where(x => x.Status == false).Count();
        }
    }
}
