using DataAcces.interfaces.dtos;
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.interfaces.interfaces
{
    public interface IRestaurantContainerContext
    {
        void create(RestaurantDto restaurant);
        
        List<RestaurantDto> returnList();
        
        void Delete(int id);

        RestaurantDto getRestaurantById(int id);

        RestaurantDto getRestaurantWithComments(CommentDto commentDto, RestaurantDto restaurantDto);
    }
}
