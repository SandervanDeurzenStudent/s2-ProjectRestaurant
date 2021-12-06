using BusinessLogic.Models;
using Presentation.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.RestaurantConverter
{
    public class RestaurantViewConverter
    {

        public RestaurantViewModel Convert_To_RestaurantViewModel(Restaurant restaurant)
        {
            return new RestaurantViewModel
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Info = restaurant.Info,
                Address = restaurant.Address,
                Telephone = restaurant.Telephone,
                Email = restaurant.Email,
            };
        }
        public List<RestaurantViewModel> Convert_To_RestaurantViewModel(List<Restaurant> restaurant)
        {
            return restaurant.Select(x => Convert_To_RestaurantViewModel(x)).ToList();
        }
        
        
        /// Takes values from PageViewModel and converts them equal to values from PageModel.
    
        public Restaurant Convert_To_Restaurant(RestaurantViewModel restaurantView)
        {
            return new Restaurant
            {
                Id = restaurantView.Id,
                Name = restaurantView.Name,
                Info = restaurantView.Info,
                Address = restaurantView.Address,
                Telephone = restaurantView.Telephone,
                Email = restaurantView.Email,
            };
        }

        ///  this method converts a list with the PageViewModel to a list with PageModel.
        public List<Restaurant> Convert_To_Restaurant(List<RestaurantViewModel> restaurantView)
        {
            return restaurantView.Select(x => Convert_To_Restaurant(x)).ToList();
        }
    }
}
