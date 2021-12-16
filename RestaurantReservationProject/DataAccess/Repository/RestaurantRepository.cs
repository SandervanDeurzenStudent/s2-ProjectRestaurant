using DataAcces.interfaces.interfaces;
using DataAcces.interfaces.Repositories;
using DataAccess.interfaces.Repositories;
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Repository
{
    public class RestaurantRepository : IRestaurantContainerRepository, IRestaurantRepository
    {
        private IRestaurantContainerContext _restaurantContainerContext;
        private IRestaurantContext _restaurantContext;
        public RestaurantRepository(IRestaurantContainerContext restaurantContainerContext, IRestaurantContext restaurantContext )
        {
            _restaurantContainerContext = restaurantContainerContext;
            _restaurantContext = restaurantContext;
        }

        public RestaurantRepository()
        {
           
        }

        public void create(RestaurantDto restaurant)
        {
            _restaurantContainerContext.create(restaurant);
        }
        public List<RestaurantDto> GetList()
        {
            List<RestaurantDto> restaurants = _restaurantContainerContext.returnList();
            return restaurants;
        }
        public void Delete(int id)
        {
            _restaurantContainerContext.Delete(id);
        }
        public RestaurantDto getRestaurantById(int id)
        {
            RestaurantDto restaurant = _restaurantContainerContext.getRestaurantById(id);
            return restaurant;
        }
        
        public void update(int id, RestaurantDto restaurant)
        {
           // throw new NotImplementedException();
        }
    }
}
