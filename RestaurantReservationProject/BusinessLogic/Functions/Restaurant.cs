using BusinessLogic.Models;
using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;

namespace BusinessLogic.Functions
{
    public class Restaurant : IRestaurantLogic
    {
        private IRestaurantContext _restaurantContext;
        private RestaurantLogicConverter _restaurantConverter;
        public Restaurant(IRestaurantContext restaurantContext, RestaurantLogicConverter restaurantLogicConverter)
        {
            _restaurantContext = restaurantContext;
            _restaurantConverter = restaurantLogicConverter;
        }
        public void update(int id, RestaurantModel restaurant)
        {
            _restaurantContext.update(id, _restaurantConverter.Convert_To_RestaurantDto(restaurant));
        }
    }
}
