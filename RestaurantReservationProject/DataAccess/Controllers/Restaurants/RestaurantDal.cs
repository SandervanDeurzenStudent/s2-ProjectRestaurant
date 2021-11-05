using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using DataAccess.Restaurants;





namespace DataAccess
{
    public class RestaurantDal 
    {
        public void create(Restaurant restaurant)
        {
            //inject local DB
            Dependecy dependecy = new Dependecy(new DB());
            //inject Online DB
            Dependecy dependecys = new Dependecy(new OnlineDB());
            try
            {
                DB db = new DB();
                string conn = db.ReturnConnectionString();
                string query = "INSERT INTO `restaurants` (`restaurant_name`, `restaurant_info`, `address`, `telephone`, `email`) VALUES( '"+ restaurant.Name + "', '" + restaurant.Info + "', '" + restaurant.Address + "', " + restaurant.Telephone + ", '" + restaurant.email + "')";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //MySqlCommand command = new MySqlCommand(cmd.CommandText, conn);

                //command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Restaurants.Restaurant> returnList()
        {
            DB db = new DB();
            string conn = db.ReturnConnectionString();
            try
            {
                string Query = "select * from restaurants;";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                List<Restaurant> restaurants = new List<Restaurant>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn2))
                {
                    MyConn2.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Restaurant entity = new Restaurant();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["restaurant_name"];
                            entity.Telephone = (int)reader["telephone"];
                            entity.Address = (string)reader["address"];
                            entity.email = (string)reader["email"];
                            entity.Info = (string)reader["restaurant_info"];
                            restaurants.Add(entity);
                        }
                        // Call Close when done reading.
                    }
                    return restaurants;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(int id)
        {
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
                        //MySqlParameter paramId = new MySqlParameter();
                        //paramId.ParameterName = "@Id";
                        //paramId.Value = id;
                        //cmd.Parameters.Add(paramId);
                        //MyConn.Open();
                        //cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public List<Restaurant> getRestaurantById(int id)
        {
            DB db = new DB();
            string conn = db.ReturnConnectionString();
            try
            {

                string Query = "select * from restaurants where id =" + id + ";";
                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                List<Restaurant> restaurants = new List<Restaurant>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn2))
                {
                    MyConn2.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Restaurant entity = new Restaurant();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["restaurant_name"];
                            entity.Telephone = (int)reader["telephone"];
                            entity.Address = (string)reader["address"];
                            entity.email = (string)reader["email"];
                            entity.Info = (string)reader["restaurant_info"];
                            restaurants.Add(entity);
                        }
                        // Call Close when done reading.
                        return restaurants;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void update(int id, Restaurant restaurant)
        {
            try
            {
                DB db = new DB();
                string conn = db.ReturnConnectionString();
                string query = "UPDATE Restaurants SET restaurant_name = @name, restaurant_info = @info, Address = @address, telephone = @telephone, email = @email Where id =" + id + ";";

                MySqlConnection MyConn2 = new MySqlConnection(conn);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MyCommand2.Parameters.AddWithValue("@name", restaurant.Name);
                MyCommand2.Parameters.AddWithValue("@info", restaurant.Info);
                MyCommand2.Parameters.AddWithValue("@address", restaurant.Address);
                MyCommand2.Parameters.AddWithValue("@telephone", restaurant.Telephone);
                MyCommand2.Parameters.AddWithValue("@email", restaurant.email);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //MySqlCommand command = new MySqlCommand(cmd.CommandText, conn);

                //command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
