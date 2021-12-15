﻿using System;
using System.Collections.Generic;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;

namespace DataAccess.Repositories
{
    public class RestaurantMemoryContext : IRestaurantContext, IRestaurantContainerContext
    {
       public List<RestaurantDto> restaurantList = new List<RestaurantDto>();

        public RestaurantMemoryContext()
        {
            restaurantList.Add(new RestaurantDto(1, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
        }
        public void create(RestaurantDto restaurant)
        {
            if (restaurant.Id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id is invalid");
            }
            else
            {
                restaurantList.Add(restaurant);
            }
        }

        public void Delete(int id)
        {
            foreach (RestaurantDto item in restaurantList)
            {
                if (item.Id == id)
                {
                    restaurantList.Remove(item);
                    return;
                }
            }
            throw new ArgumentOutOfRangeException("Restaurant does not exist");
        }

        public RestaurantDto getRestaurantById(int restaurantid)
        {
            foreach (var item in restaurantList)
            {
                if (restaurantid == item.Id)
                {
                    return item;
                }
            }
            throw new ArgumentOutOfRangeException("Restaurant does not exist");
        }

        public List<RestaurantDto> returnList()
        {
            return restaurantList.GetRange(0, 1);
        }

        public void update(int id, RestaurantDto restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
