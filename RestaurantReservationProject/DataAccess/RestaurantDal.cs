using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using System.Linq;
using Repositories.interfaces;
using Repositories.Factories;

namespace DataAccess
{
    public class RestaurantDal : IRestaurantDal, IRestaurantContainerDal
    {
        IRestaurantContext restaurantMemoryContext;
        public RestaurantDal()
        {
            restaurantMemoryContext = RestaurantFactory.CreateRestaurant();
        }
        public void create(RestaurantDto restaurant)
        {
            restaurantMemoryContext.create(restaurant.convertToDto());
        }
        public List<RestaurantDto> returnList()
        {
            List<RestaurantDto> restaurants = new List<RestaurantDto>();
            restaurants = restaurantMemoryContext.returnList();
            return restaurants;
        }

        public void Delete(int id)
        {
            restaurantMemoryContext.Delete(id);
        }

        public RestaurantDto getRestaurantById(int id)
        {
            return restaurantMemoryContext.getRestaurantById(id);
        }

        public void update(int id, RestaurantDto restaurant)
        {
            
        }
    }
}
