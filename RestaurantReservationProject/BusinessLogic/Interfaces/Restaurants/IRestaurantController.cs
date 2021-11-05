using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public interface IRestaurantController
    {
        void create(DataAccess.Restaurants.Restaurant restaurant);
        //void update(int id);
        void Delete(int id);
    }
}
