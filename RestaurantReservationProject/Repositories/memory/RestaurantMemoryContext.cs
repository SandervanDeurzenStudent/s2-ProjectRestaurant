using DataAccess.interfaces.RestaurantsDto;
using Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.memory
{
    public class RestaurantMemoryContext 
    {
        List<RestaurantDalModel> restaurantList = new List<RestaurantDalModel>();
        public bool create(RestaurantDalModel restaurant)
        {
            if (restaurant.Id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id is invalid"); 
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

        public bool getRestaurantById(int restaurantid)
        {
            if (restaurantid <= 0)
            {
                throw new ArgumentOutOfRangeException("ID not found");
            }
            else
            {
                return true;
            }
        }

        public List<RestaurantDalModel> returnList()
        {
            throw new NotImplementedException();
        }

        public void update(int id, RestaurantDalModel restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
