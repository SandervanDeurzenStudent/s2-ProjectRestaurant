using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.interfaces.interfaces
{
    public interface IRestaurantContainerDal
    {
        void create(RestaurantDalModel restaurant);
        
        List<RestaurantDalModel> returnList();
        
        void Delete(int id);

        RestaurantDalModel getRestaurantById(int id);
    }
}
