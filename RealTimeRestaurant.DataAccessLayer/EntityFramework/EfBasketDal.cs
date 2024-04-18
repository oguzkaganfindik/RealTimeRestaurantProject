using Microsoft.EntityFrameworkCore;
using RealTimeRestaurant.DataAccessLayer.Abstract;
using RealTimeRestaurant.DataAccessLayer.Concrete;
using RealTimeRestaurant.DataAccessLayer.Repositories;
using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(RealTimeRestaurantContext context) : base(context)
        {
            
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new RealTimeRestaurantContext();
            var values = context.Baskets.Where(x => x.MenuTableId == id).Include(y => y.Product).ToList();
            return values;
        }
    }
}
