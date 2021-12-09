using BusinessLogic.Models;
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class RestaurantConverter
    {
        public Restaurant Convert_To_Restaurant(RestaurantDto restaurant)
        {
            return new Restaurant
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Info = restaurant.Info,
                Address = restaurant.Address,
                Telephone = restaurant.Telephone,
                Email = restaurant.Email,
            };
        }
        public List<Restaurant> Convert_To_Restaurant(List<RestaurantDto> restaurant)
        {
            return restaurant.Select(x => Convert_To_Restaurant(x)).ToList();
        }

        /// <summary>
        /// Takes values from PageDTO and converts them equal to values from PageModel.
        /// </summary>
        /// <param name="dTO_PageModel"></param>
        /// <returns></returns>
        public RestaurantDto Convert_To_RestaurantDto(Restaurant DTOrestaurant)
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
        public List<RestaurantDto> Convert_To_RestaurantDto(List<Restaurant> restaurants)
        {
            return restaurants.Select(x => Convert_To_RestaurantDto(x)).ToList();
        }
    }
}
