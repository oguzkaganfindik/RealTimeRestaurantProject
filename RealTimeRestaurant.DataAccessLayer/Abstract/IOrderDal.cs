using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        int TotalOrderCount();
        int ActiveOrderCount();
    }
}
