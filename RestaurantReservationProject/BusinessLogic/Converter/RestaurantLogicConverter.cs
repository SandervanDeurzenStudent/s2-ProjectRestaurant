using BusinessLogic.Models;
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class RestaurantLogicConverter
    {
        public RestaurantModel Convert_To_Restaurant(RestaurantDto restaurant)
        {
            return new RestaurantModel
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Info = restaurant.Info,
                Address = restaurant.Address,
                Telephone = restaurant.Telephone,
                Email = restaurant.Email,
            };
        }
        public List<RestaurantModel> Convert_To_Restaurant(List<RestaurantDto> restaurant)
        {
            return restaurant.Select(x => Convert_To_Restaurant(x)).ToList();
        }



        public RestaurantDto Convert_To_RestaurantDto(RestaurantModel DTOrestaurant)
        {
            return new RestaurantDto
            {
                Id = DTOrestaurant.Id,
                Name = DTOrestaurant.Name,
                Info = DTOrestaurant.Info,
                Address = DTOrestaurant.Address,
                Telephone = DTOrestaurant.Telephone,
                Email = DTOrestaurant.Email,
            };
        }
        public List<RestaurantDto> Convert_To_RestaurantDto(List<RestaurantModel> restaurants)
        {
            return restaurants.Select(x => Convert_To_RestaurantDto(x)).ToList();
        }
    }
}
