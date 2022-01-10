using BusinessLogic.Models;
using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAcces.interfaces.Repositories;

namespace BusinessLogic.Functions
{
    public class Restaurant : IRestaurantLogic
    {
        private IRestaurantRepository _IRestaurantRepository;
        private RestaurantLogicConverter _restaurantConverter;
        public Restaurant(IRestaurantRepository RestaurantRepository)
        {
            _IRestaurantRepository = RestaurantRepository;
        }
        public void update(int id, RestaurantModel restaurant)
        {
            _IRestaurantRepository.update(id, _restaurantConverter.Convert_To_RestaurantDto(restaurant));
        }
    }
}
