using System;
using System.Collections.Generic;
using System.Text;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using Repositories.interfaces.dtos;

namespace Repositories.interfaces
{
    public interface IRestaurantMySqlContext
    {
         void Create(RestaurantRepositoryDto restaurant);

         List<RestaurantRepositoryDto> returnList();

         void Delete(int id);

         RestaurantDto getRestaurantById(int id);


         void update(int id, RestaurantDto restaurant);
        
    
}
}
