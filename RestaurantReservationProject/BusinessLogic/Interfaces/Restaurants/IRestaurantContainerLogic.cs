using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.Restraurants
{
    public interface IRestaurantContainerLogic
    {
        void create(RestaurantModel restaurant);
        void Delete(int id);
        List<RestaurantModel> GetList();
        RestaurantModel getRestaurantById(int id);
    }
}