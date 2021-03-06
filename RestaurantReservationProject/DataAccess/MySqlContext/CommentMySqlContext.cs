using DataAcces.interfaces.interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using DataAcces.interfaces.dtos;

namespace DataAccess
{
    public class CommentMySqlContext : ICommentContainerContext
    {
        public void Create(CommentDto comment)
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand("INSERT INTO comments (`name`, `description`, `restaurant_id` ) VALUES (@name, @info, @restaurantId)", MyConn);
                MyCommand.Parameters.AddWithValue("@name", comment.Name);
                MyCommand.Parameters.AddWithValue("@info", comment.Info);
                MyCommand.Parameters.AddWithValue("@restaurantId", comment.RestaurantId);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                //command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
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
                        string Query = string.Format("Delete from comments where id = {0};", id);
                        MyConn.Open();
                        MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                        cmd.ExecuteNonQuery();
                        MyConn.Close();
                    }
                }
                catch (Exception)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public List<CommentDto> GetCommentsById(int id)
        {
            DB db = new DB();
            string connString = db.ReturnConnectionString();
            try
            {
                string Query = string.Format("select * from comments where restaurant_id = {0}", id);

                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                List<CommentDto> comments = new List<CommentDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentDto entity = new CommentDto();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["name"];
                            entity.Info = (string)reader["description"];
                            entity.RestaurantId = (int)reader["restaurant_id"];
                            comments.Add(entity);
                        }
                        // Call Close when done reading.
                        return comments;
                    }
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public List<CommentDto> GetList()
        {
            DB db = new DB();
            string connString = db.ReturnConnectionString();
            try
            {
                string Query = "select * from comments;";
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                List<CommentDto> comments = new List<CommentDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentDto entity = new CommentDto();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["name"];
                            entity.Info = (string)reader["description"];
                            comments.Add(entity);
                        }
                    }
                    return comments;
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
