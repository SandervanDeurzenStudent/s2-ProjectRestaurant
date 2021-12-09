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
        private IRestaurantContainerDal _restaurantDal;
        private RestaurantConverter _restaurantConverter;
        public RestaurantContainer(IRestaurantContainerDal restaurantDAl, RestaurantConverter restaurantConverter)
        {
            _restaurantDal = restaurantDAl;
            _restaurantConverter = restaurantConverter;
        }
        public RestaurantContainer()
        {
           
        }
        public void create(Restaurant restaurant)
        {
            _restaurantDal.create(restaurant.convertToDto());  
         //test
        }
        public List<Restaurant> GetList()
        {
            List<Restaurant> restaurants = _restaurantConverter.Convert_To_Restaurant(_restaurantDal.returnList()); 
            return restaurants;
        }
        public void Delete(int id)
        {
            _restaurantDal.Delete(id);
        }
        public Restaurant getRestaurantById(int id)
        {
            return new Restaurant(_restaurantDal.getRestaurantById(id));
        }

    }
}
