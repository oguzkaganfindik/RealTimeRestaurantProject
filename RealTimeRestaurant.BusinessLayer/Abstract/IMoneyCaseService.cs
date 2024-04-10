using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.BusinessLayer.Abstract
{
    public interface IMoneyCaseService : IGenericService<MoneyCase>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
