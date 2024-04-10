using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.Abstract
{
    public interface IMoneyCaseDal : IGenericDal<MoneyCase>
    {
        decimal TotalMoneyCaseAmount();
    }
}
