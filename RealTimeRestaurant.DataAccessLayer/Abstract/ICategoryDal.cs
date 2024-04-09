using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();

    }
}
