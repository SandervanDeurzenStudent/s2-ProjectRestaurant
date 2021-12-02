using DataAcces.interfaces.interfaces;
using System;

namespace DataAccess.Factories
{
    public class RestaurantFactory
    {
        public static IRestaurantDal CreateRestaurant()
        {
            return new RestaurantDal();
        }
        public static IRestaurantContainerDal CreateRestaurantCollection()
        {
            return new RestaurantDal();
        }
    }
}
