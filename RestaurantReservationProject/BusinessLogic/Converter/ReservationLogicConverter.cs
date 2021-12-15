using BusinessLogic.Models.Reservation;
using DataAccess.interfaces.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Converter
{
    public class ReservationLogicConverter
    {
        public ReservationModel Convert_To_ReservationModel(ReservationDto reservation)
        {
            return new ReservationModel
            {
                Id = reservation.Id,
                Date = reservation.Date,
                Time = reservation.Time,
                Restaurant_id = reservation.Restaurant_id,
                User_id = reservation.User_id,
            };
        }
        public List<ReservationModel> Convert_To_ReservationModel(List<ReservationDto> restaurant)
        {
            return restaurant.Select(x => Convert_To_ReservationModel(x)).ToList();
        }

        public ReservationDto Convert_To_ReservationDto(ReservationModel ReservationView)
        {
            return new ReservationDto
            {
                Id = ReservationView.Id,
                Date = ReservationView.Date,
                Time = ReservationView.Time,
                Restaurant_id = ReservationView.Restaurant_id,
                User_id = ReservationView.User_id,
            };
        }

        public List<ReservationDto> Convert_To_ReservationDto(List<ReservationModel> restaurantView)
        {
            return restaurantView.Select(x => Convert_To_ReservationDto(x)).ToList();
        }
    }
}
