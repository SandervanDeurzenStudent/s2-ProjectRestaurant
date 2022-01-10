using System.Collections.Generic;
using BusinessLogic.Models;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.Repositories;

namespace BusinessLogic.Restraurants
{
    public class RestaurantContainer : IRestaurantContainerLogic
    {
        private IRestaurantContainerRepository _restaurantContainerRepository;
        private RestaurantLogicConverter _restaurantConverter = new RestaurantLogicConverter();
        public RestaurantContainer(IRestaurantContainerRepository restaurantContainerRepository)
        {
            _restaurantContainerRepository = restaurantContainerRepository;
        }

        public void create(RestaurantModel restaurant)
        {
            _restaurantContainerRepository.create(_restaurantConverter.Convert_To_RestaurantDto(restaurant));
        }
        public List<RestaurantModel> GetList()
        {
            List<RestaurantModel> restaurants = _restaurantConverter.Convert_To_Restaurant(_restaurantContainerRepository.GetList());
            return restaurants;
        }
        public void Delete(int id)
        {
            _restaurantContainerRepository.Delete(id);
        }
        public RestaurantModel getRestaurantById(int id)
        {
            RestaurantModel restaurant =  _restaurantConverter.Convert_To_Restaurant(_restaurantContainerRepository.getRestaurantById(id));
            
            return restaurant;
        }
    }
}
