using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void BookingStatusApproved(int id);
        void BookingStatusCancelled(int id);
    }
}
