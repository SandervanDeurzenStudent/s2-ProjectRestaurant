using DataAccess.interfaces.RestaurantsDto;
using Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.memory
{
    public class RestaurantMemoryContext 
    {
        List<RestaurantDto> restaurantList = new List<RestaurantDto>();
        public bool create(RestaurantDto restaurant)
        {
            if (restaurant.Id <= 0)
            {
                throw new ArgumentException("A Comment with this ID already exists."); ;
                return false;
            }
            else
            {
                restaurantList.Add(restaurant);
                return true;
            }
        }

        public void Delete(int id)
        {
            
        }

        public RestaurantDto getRestaurantById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantDto> returnList()
        {
            throw new NotImplementedException();
        }

        public void update(int id, RestaurantDto restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
