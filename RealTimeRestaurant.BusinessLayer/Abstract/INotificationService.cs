using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        int TNotificationCountByStatusFalse();

        List<Notification> TGetAllNotificationsByFalse();
        void TNotificationChangeToTrue(int id);
        void TNotificationChangeToFalse(int id);
    }
}
