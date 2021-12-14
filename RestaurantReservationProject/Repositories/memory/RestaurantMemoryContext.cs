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

        public RestaurantMemoryContext()
        {
            restaurantList.Add(new RestaurantDalModel(1, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
        }
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
            foreach (var item in restaurantList)
            {
                if (restaurantid == item.Id)
                {
                    return true;
                }
            }
            throw new ArgumentOutOfRangeException("Restaurant does not exist"); 
        }

        public List<RestaurantDalModel> returnList()
        {
            return restaurantList.GetRange(0, 1);
        }

        public void update(int id, RestaurantDalModel restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
