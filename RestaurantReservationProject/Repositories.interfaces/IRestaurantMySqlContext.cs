using System;
using System.Collections.Generic;
using System.Text;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;

namespace Repositories.interfaces
{
    public interface IRestaurantMySqlContext
    {
         void create(RestaurantDto restaurant);

         List<RestaurantDto> returnList();

         void Delete(int id);

        RestaurantDto getRestaurantById(int id);


         void update(int id, RestaurantDto restaurant);
        
    
}
}
