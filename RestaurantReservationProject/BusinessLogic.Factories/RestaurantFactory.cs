using BusinessLogic.Restraurants;
using System;

namespace BusinessLogic.Factories
{
    public class RestaurantFactory
    {
        public static IRestaurantLogic CreateRestaurant()
        {
            return new BusinessLogic.Controller.Restraurants.RestaurantDataController();
        }
        public static IRestaurantContainerLogic CreateRestaurantCollection()
        {
            return new RestaurantCollectionController();
        }
    }
}
