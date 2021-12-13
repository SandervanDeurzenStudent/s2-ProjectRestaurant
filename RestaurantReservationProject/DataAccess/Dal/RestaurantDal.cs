using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using System.Linq;
using Repositories.interfaces;
using DataAccess.Converter;

namespace DataAccess
{
    public class RestaurantDal : IRestaurantDal, IRestaurantContainerDal
    {
        private IRestaurantMySqlContext _restaurantMysqlContext;
        RestaurantDalConverter _restaurantDalConverter;
        public RestaurantDal(IRestaurantMySqlContext restaurantMySqlContext, RestaurantDalConverter restaurantDalConverter)
        {
            _restaurantMysqlContext = restaurantMySqlContext;
            _restaurantDalConverter = restaurantDalConverter;
        }
        public void create(RestaurantDalModel restaurant)
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand("INSERT INTO restaurants (`restaurant_name`, `restaurant_info`, `address`, `telephone`, `email`) VALUES (@name, @info, @address, @telephone, @email);", MyConn);
                MyCommand.Parameters.AddWithValue("@name", restaurant.Name);
                MyCommand.Parameters.AddWithValue("@info", restaurant.Info);
                MyCommand.Parameters.AddWithValue("@address", restaurant.Address);
                MyCommand.Parameters.AddWithValue("@telephone", restaurant.Telephone);
                MyCommand.Parameters.AddWithValue("@email", restaurant.Email);
                MySqlDataReader MyReader2;
                MyConn.Open();
                MyReader2 = MyCommand.ExecuteReader();
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<RestaurantDalModel> returnList()
        {
            List<RestaurantDalModel> restaurants = _restaurantDalConverter.Convert_To_RestaurantDalModel(_restaurantMysqlContext.returnList());
            return restaurants;
            
        }
            public void Delete(int id)
        {
            //_restaurantMysqlContext.Delete(id);
        }

        public RestaurantDalModel getRestaurantById(int id)
        {
            RestaurantDalModel restaurant = _restaurantDalConverter.Convert_To_RestaurantDalModel(_restaurantMysqlContext.getRestaurantById(id));
            return restaurant;
        }

        public void update(int id, RestaurantDalModel restaurant)
        {
            
        }
    }
}
