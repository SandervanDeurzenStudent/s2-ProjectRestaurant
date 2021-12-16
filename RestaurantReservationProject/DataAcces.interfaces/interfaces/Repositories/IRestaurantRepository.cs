
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

 namespace DataAcces.interfaces.Repositories
{
    public interface IRestaurantRepository
    {
       void update(int id, RestaurantDto restaurant);   
    }
}
