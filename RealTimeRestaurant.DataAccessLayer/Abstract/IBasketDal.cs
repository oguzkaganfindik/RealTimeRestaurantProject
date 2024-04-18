﻿using RealTimeRestaurant.EntityLayer.Entities;

namespace RealTimeRestaurant.DataAccessLayer.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<Basket> GetBasketByMenuTableNumber(int id);
    }
}
