using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace BusinessLogic.Restraurants
{
    public class RestaurantCollectionController : IRestaurantController
    {
        public void create(DataAccess.Restaurants.Restaurant restaurant)
        {
            
            DataAccess.RestaurantDal dataacces = new DataAccess.RestaurantDal();
            dataacces.create(restaurant);
        }
        public List<DataAccess.Restaurants.Restaurant> GetList()
        {
            DataAccess.RestaurantDal dataacces = new DataAccess.RestaurantDal();
            return dataacces.returnList();
            
        }

        public void Delete(int id)
        {
            DataAccess.RestaurantDal dataacces = new DataAccess.RestaurantDal();
            dataacces.Delete(id);
        }
        public void update(int id, DataAccess.Restaurants.Restaurant restaurant)
        {
            DataAccess.RestaurantDal dataacces = new DataAccess.RestaurantDal();
            dataacces.update(id, restaurant);
        }

        public int ReturnList(int id)
        {
            return id = 5;
        }

        
        public List<DataAccess.Restaurants.Restaurant> getRestaurantById( int id)
        {
            DataAccess.RestaurantDal dataacces = new DataAccess.RestaurantDal();
            return dataacces.getRestaurantById( id);
        }

    }
}
