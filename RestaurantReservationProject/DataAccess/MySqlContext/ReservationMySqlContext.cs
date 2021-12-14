using DataAccess.interfaces.Dtos;
using DataAccess.interfaces.interfaces.Reservations;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MySqlContext
{
    public class ReservationMySqlContext : IReservationContainerDal
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
                MyCommand.Parameters.AddWithValue("@restaurant_id", reservation.Restaurant_id);
                MyCommand.Parameters.AddWithValue("@user_id", reservation.User_id);
                MySqlDataReader MyReader2;
                MyConn.Open();
                MyReader2 = MyCommand.ExecuteReader();
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
            throw new NotImplementedException();
        }

        public ReservationDto getReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
