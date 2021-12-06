using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using System.Linq;
using Repositories.interfaces;
using Repositories.Factories;

namespace DataAccess
{
    public class RestaurantDal : IRestaurantDal, IRestaurantContainerDal
    {
        IRestaurantContext _restaurantMemoryContext;
        public RestaurantDal(IRestaurantContext restaurantContext)
        {
            _restaurantMemoryContext = restaurantContext;
        }
        public void create(RestaurantDto restaurant)
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
        public List<RestaurantDto> returnList()
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                string Query = "select * from restaurants;";
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                List<RestaurantDto> restaurants = new List<RestaurantDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RestaurantDto entity = new RestaurantDto();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["restaurant_name"];
                            entity.Telephone = (int)reader["telephone"];
                            entity.Address = (string)reader["address"];
                            entity.Email = (string)reader["email"];
                            entity.Info = (string)reader["restaurant_info"];
                            restaurants.Add(entity);
                        }
                    }
                    return restaurants;
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Delete(int id)
        {
            _restaurantMemoryContext.Delete(id);
        }

        public RestaurantDto getRestaurantById(int id)
        {
            return _restaurantMemoryContext.getRestaurantById(id);
        }

        public void update(int id, RestaurantDto restaurant)
        {
            
        }
    }
}
