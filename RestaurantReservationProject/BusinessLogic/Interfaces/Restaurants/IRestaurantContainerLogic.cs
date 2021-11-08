using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.Restraurants
{
    public interface IRestaurantContainerLogic
    {
        void create(Restaurant restaurant);
        void Delete(int id);
        List<Restaurant> GetList();
        Restaurant getRestaurantById(int id);
        int ReturnList(int id);
    }
}