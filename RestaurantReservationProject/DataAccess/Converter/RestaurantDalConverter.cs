using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories.interfaces.dtos;

namespace DataAccess.Converter
{
    public class RestaurantDalConverter
    {
        public RestaurantDalModel Convert_To_RestaurantDalModel(RestaurantRepositoryDto restaurant)
        {
            return new RestaurantDalModel
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Info = restaurant.Info,
                Address = restaurant.Address,
                Telephone = restaurant.Telephone,
                Email = restaurant.Email,
            };
        }
        public List<RestaurantDalModel> Convert_To_RestaurantDalModel(List<RestaurantRepositoryDto> restaurant)
        {
            return restaurant.Select(x => Convert_To_RestaurantDalModel(x)).ToList();
        }

        /// <summary>
        /// Takes values from PageDTO and converts them equal to values from PageModel.
        /// </summary>
        /// <param name="dTO_PageModel"></param>
        /// <returns></returns>
        public RestaurantRepositoryDto Convert_To_RestaurantRepositoryDto(RestaurantDalModel DTOrestaurant)
        {
            return new RestaurantRepositoryDto
            {
                Id = DTOrestaurant.Id,
                Name = DTOrestaurant.Name,
                Info = DTOrestaurant.Info,
                Address = DTOrestaurant.Address,
                Telephone = DTOrestaurant.Telephone,
                Email = DTOrestaurant.Email,
            };
        }
        public List<RestaurantRepositoryDto> Convert_To_RestaurantRepositoryDto(List<RestaurantDalModel> pageModels)
        {
            return pageModels.Select(x => Convert_To_RestaurantRepositoryDto(x)).ToList();
        }
    }
}
