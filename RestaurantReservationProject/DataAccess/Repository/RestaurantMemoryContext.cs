using System;
using System.Collections.Generic;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;


namespace DataAccess.Repositories
{
    public class RestaurantMemoryContext : IRestaurantDal, IRestaurantContainerDal
    {
        public void create(RestaurantDto restaurant)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RestaurantDto getRestaurantById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RestaurantDto> returnList()
        {
            throw new NotImplementedException();
        }

        public void update(int id, RestaurantDto restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
