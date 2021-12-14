
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

 namespace DataAcces.interfaces.interfaces
{
    public interface IRestaurantDal
    {
       void update(int id, RestaurantDto restaurant);   
    }
}
