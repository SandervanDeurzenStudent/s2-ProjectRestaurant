using System;
using Repositories;
using Repositories.interfaces;

namespace Repositories.Factories
{
    public class RestaurantFactory
    {
        public static IRestaurantMySqlContext CreateRestaurant()
        {
            return new RestaurantMySqlContext();
        }
        //public static IRestaurantContext CreateRestaurantCollection()
        //{
        //    return new Restaur();
        //}
    }
}
