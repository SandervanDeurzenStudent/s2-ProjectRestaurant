using System;
using System.Collections.Generic;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using Repositories.interfaces;
using MySql.Data.MySqlClient;
using DataAccess;
using System.Linq;
using Repositories.interfaces.dtos;

namespace Repositories
{
    public class RestaurantMySqlContext : IRestaurantMySqlContext
    {
        public RestaurantMySqlContext()
        {

        }
        public void Create(RestaurantRepositoryDto restaurant)
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
        public List<RestaurantRepositoryDto> returnList()
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
                List<RestaurantRepositoryDto> restaurants = new List<RestaurantRepositoryDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RestaurantRepositoryDto entity = new RestaurantRepositoryDto();
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
                throw new IndexOutOfRangeException("error while processing the query");
            }
        }

        public void Delete(int id)
        {
            DB db = new DB();
            string conn = db.ReturnConnectionString();
            try
            {
                using (MySqlConnection MyConn = new MySqlConnection(conn))
                {
                    MySqlCommand cmd = new MySqlCommand("Delete from Restaurants where id =" + id + ";", MyConn);
                    MyConn.Open();
                    cmd.ExecuteNonQuery();
                    MyConn.Close();
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public RestaurantRepositoryDto getRestaurantById(int id)
        {
            DB db = new DB();
            string conn = db.ReturnConnectionString();
            try
            {
                string Query = string.Format("select * from restaurants where id = {0}", id);
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                List<RestaurantRepositoryDto> restaurants = new List<RestaurantRepositoryDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn2))
                {
                    MyConn2.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RestaurantRepositoryDto entity = new RestaurantRepositoryDto();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["restaurant_name"];
                            entity.Telephone = (int)reader["telephone"];
                            entity.Address = (string)reader["address"];
                            entity.Email = (string)reader["email"];
                            entity.Info = (string)reader["restaurant_info"];
                            restaurants.Add(entity);
                        }
                        // Call Close when done reading.
                        return restaurants.First();
                    }
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void update(int id, RestaurantDalModel restaurant)
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                string query = "UPDATE Restaurants SET restaurant_name = @name, restaurant_info = @info, Address = @address, telephone = @telephone, email = @email Where id =" + id + ";";

                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                MyCommand.Parameters.AddWithValue("@name", restaurant.Name);
                MyCommand.Parameters.AddWithValue("@info", restaurant.Info);
                MyCommand.Parameters.AddWithValue("@address", restaurant.Address);
                MyCommand.Parameters.AddWithValue("@telephone", restaurant.Telephone);
                MyCommand.Parameters.AddWithValue("@email", restaurant.Email);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
