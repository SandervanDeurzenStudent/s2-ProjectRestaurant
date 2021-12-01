using System;
using Repositories;
using Repositories.interfaces;

namespace Repositories.Factories
{
    public class RestaurantFactory
    {
        public static IRestaurantContext CreateRestaurant()
        {
            return new RestaurantMemoryMySqlContext();
        }
        //public static IRestaurantContext CreateRestaurantCollection()
        //{
        //    return new Restaur();
        //}
    }
}
