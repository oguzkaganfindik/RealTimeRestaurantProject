using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.Abstract
{
    public interface IMenuTableDal : IGenericDal<MenuTable>
    {
        int MenuTableCount();
    }
}
