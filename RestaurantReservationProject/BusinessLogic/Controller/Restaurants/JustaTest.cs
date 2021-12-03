using BusinessLogic.Models;
using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAccess.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller.Restaurants
{
    class JustaTest : IRestaurantLogic
    {
        IRestaurantDal restaurantDal;
        public JustaTest()
        {
            restaurantDal = RestaurantFactory.CreateRestaurant();
        }
        public void update(int id, Restaurant restaurant)
        {
            restaurantDal.update(id, restaurant.convertToDto());
        }
    }
}
