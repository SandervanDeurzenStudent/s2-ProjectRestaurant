﻿using System;
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
        private RestaurantLogicConverter _restaurantConverter;
        public RestaurantContainer(IRestaurantContainerDal restaurantDAl, RestaurantLogicConverter restaurantConverter)
        {
            _restaurantDal = restaurantDAl;
            _restaurantConverter = restaurantConverter;
        }
        public void create(RestaurantModel restaurant)
        {
            //_restaurantDal.create(restaurant.convertToDto());  
        }
        public List<RestaurantModel> GetList()
        {
            List<RestaurantModel> restaurants = _restaurantConverter.Convert_To_Restaurant(_restaurantDal.returnList()); 
            return restaurants;
        }
        public void Delete(int id)
        {
            _restaurantDal.Delete(id);
        }
        public RestaurantModel getRestaurantById(int id)
        {
            return null;
           // return new Restaurant(_restaurantDal.getRestaurantById(id));
        }

    }
}