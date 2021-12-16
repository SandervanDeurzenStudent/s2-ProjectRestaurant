using System.Collections.Generic;
using DataAccess.interfaces.RestaurantsDto;

namespace DataAccess.interfaces.Repositories
{
    public interface IRestaurantContainerRepository
    {
        void create(RestaurantDto restaurant);
        void Delete(int id);
        List<RestaurantDto> GetList();
        RestaurantDto getRestaurantById(int id);
    }
}