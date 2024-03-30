using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(RealTimeRestaurantContext context) : base(context)
        {
        }
    }
}
