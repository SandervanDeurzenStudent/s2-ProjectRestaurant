using DataAcces.interfaces.interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using Repositories.interfaces.dtos;
using DataAcces.interfaces.Dto_s;

namespace DataAccess
{
    public class CommentDal : ICommentContainerDal
    {
        public CommentDal()
        {

        }

        public void Create(CommentDto comment, int commentId)
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand("INSERT INTO comments (`name`, `description`, `restaurant_id` ) VALUES (@name, @info, @restaurantId)", MyConn);
                MyCommand.Parameters.AddWithValue("@name", comment.Name);
                MyCommand.Parameters.AddWithValue("@info", comment.Info);
                MyCommand.Parameters.AddWithValue("@restaurantId", commentId);
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

        public List<CommentRepositoryDto> GetCommentsById(int id)
        {
            DB db = new DB();
            string connString = db.ReturnConnectionString();
            try
            {
                string Query = string.Format("select * from comments where id = {0}", id);
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                List<CommentRepositoryDto> comments = new List<CommentRepositoryDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentRepositoryDto entity = new CommentRepositoryDto();
                            entity.Id = (int)reader["id"];
                            entity.Name = (string)reader["restaurant_name"];
                            entity.Info = (string)reader["description"];
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


        void ICommentContainerDal.Delete(int id)
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

        List<CommentDto> ICommentContainerDal.GetCommentsById(int id)
        {
            throw new NotImplementedException();
        }

        List<CommentRepositoryDto> GetList()
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
                List<CommentRepositoryDto> comments = new List<CommentRepositoryDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CommentRepositoryDto entity = new CommentRepositoryDto();
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

        List<CommentDto> ICommentContainerDal.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
