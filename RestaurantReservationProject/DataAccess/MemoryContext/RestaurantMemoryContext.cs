using System;
using System.Collections.Generic;
using DataAcces.interfaces.dtos;
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

        public RestaurantDto getRestaurantWithComments(CommentDto commentDto, RestaurantDto restaurantDto)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantDto> returnList()
        {
            return restaurantList.GetRange(0, 1);
        }

        public void update(int id, RestaurantDto restaurant)
        {
            foreach (RestaurantDto item in restaurantList)
            {
                if (item.Id ==  id)
                {
                    restaurantList[item.Id - 1] = restaurant;
                    return;
                }
            }

            throw new ArgumentOutOfRangeException("No run with this ID was found.");
        }
    }
}
