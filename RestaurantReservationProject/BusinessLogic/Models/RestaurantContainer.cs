using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Models;
using DataAcces.interfaces.interfaces;
using MySqlConnector;
namespace BusinessLogic.Restraurants
{
    public class RestaurantContainer : IRestaurantContainerLogic
    {
        private IRestaurantContainerDal restaurantContainerDal;
        private RestaurantConverter _restaurantConverter;
        public RestaurantContainer(IRestaurantContainerDal restaurantDAl)
        {
            restaurantContainerDal = restaurantDAl;
        }
        public RestaurantContainer()
        {
           
        }
        public void create(Restaurant restaurant)
        {
            restaurantContainerDal.create(restaurant.convertToDto());  
         //test
        }
        public List<Restaurant> GetList()
        {
            List<Restaurant> restaurants = _restaurantConverter.Convert_To_Restaurant(restaurantContainerDal.returnList()); 
            return restaurants;
        }
        public void Delete(int id)
        {
            restaurantContainerDal.Delete(id);
        }
        public Restaurant getRestaurantById(int id)
        {
            return new Restaurant(restaurantContainerDal.getRestaurantById(id));
        }

    }
}
