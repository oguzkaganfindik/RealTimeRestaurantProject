using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.BusinessLayer.Abstract
{
    public interface IMenuTableService : IGenericService<MenuTable>
    {
        int TMenuTableCount();
    }
}
