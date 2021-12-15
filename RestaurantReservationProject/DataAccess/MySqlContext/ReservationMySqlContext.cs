using DataAccess.interfaces.Dtos;
using DataAccess.interfaces.interfaces.Reservations;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MySqlContext
{
    public class ReservationMySqlContext : IReservationContainerContext
    {
        public void create(ReservationDto reservation)
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand("INSERT INTO reservations (`date`, `time`, `restaurant_id`, `user_id`) VALUES (@date, @time, @restaurant_id, @user_id);", MyConn);
                MyCommand.Parameters.AddWithValue("@date", reservation.Date);
                MyCommand.Parameters.AddWithValue("@time", reservation.Time);
                MyCommand.Parameters.AddWithValue("@restaurant_id", 1);
                MyCommand.Parameters.AddWithValue("@user_id", 2);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservationDto> GetList()
        {
            try
            {
                DB db = new DB();
                string connString = db.ReturnConnectionString();
                string Query = "select * from reservations;";
                MySqlConnection MyConn = new MySqlConnection(connString);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                List<ReservationDto> reservations = new List<ReservationDto>();

                using (MySqlCommand command = new MySqlCommand(Query, MyConn))
                {
                    MyConn.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReservationDto entity = new ReservationDto();
                            entity.Id = (int)reader["id"];
                            entity.Date = (string)reader["date"];
                            entity.Time = (string)reader["time"];
                            entity.Restaurant_id = (int)reader["restaurant_id"];
                            entity.User_id = (int)reader["user_id"];
                            reservations.Add(entity);
                        }
                    }
                    return reservations;
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException("error while processing the query");
            }
        }

        public ReservationDto getReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
