﻿using BusinessLogic.Controller.Restraurants;
using BusinessLogic.Restraurants;
using System;

namespace BusinessLogic.Factories
{
    public class RestaurantFactory
    {
        public static IRestaurantLogic CreateRestaurant()
        {
            return new RestaurantDataController();
        }
        public static IRestaurantContainerLogic CreateRestaurantCollection()
        {
            return new RestaurantCollectionController();
        }
    }
}
