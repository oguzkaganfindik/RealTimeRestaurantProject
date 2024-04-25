using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public EfMessageDal(RealTimeRestaurantContext context) : base(context)
        {
        }
    }
}
