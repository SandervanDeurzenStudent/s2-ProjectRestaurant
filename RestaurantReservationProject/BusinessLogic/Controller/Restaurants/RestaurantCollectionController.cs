using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Models;
using DataAcces.interfaces.interfaces;
using DataAccess.Factories;
using MySqlConnector;
namespace BusinessLogic.Restraurants
{
    public class RestaurantCollectionController : IRestaurantContainerLogic
    {
        IRestaurantContainerDal restaurantContainerDal;
        public RestaurantCollectionController()
        {
            restaurantContainerDal = RestaurantFactory.CreateRestaurantCollection();
        }
        public void create(Restaurant restaurant)
        {
            restaurantContainerDal.create(restaurant.convertToDto());  
            //testet
        }
        public List<Restaurant> GetList()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurantContainerDal.returnList().ForEach(dto => restaurants.Add(new Restaurant(dto)));
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
