using BusinessLogic.Models.Reservation;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Converter
{
    public class ReservationViewConverter
    {
        public ReservationViewModel Convert_To_ReservationViewModel(ReservationModel reservation)
        {
            return new ReservationViewModel
            {
                Id = reservation.Id,
                Date = reservation.Date,
                Time = reservation.Time,
                Restaurant_id = reservation.Restaurant_id,
                User_id = reservation.User_id,
            };
        }
        public List<ReservationViewModel> Convert_To_ReservationViewModel(List<ReservationModel> restaurant)
        {
            return restaurant.Select(x => Convert_To_ReservationViewModel(x)).ToList();
        }

        public ReservationModel Convert_To_ReservationModel(ReservationViewModel ReservationView)
        {
            return new ReservationModel
            {
                Id = ReservationView.Id,
                Date = ReservationView.Date,
                Time = ReservationView.Time,
                Restaurant_id = ReservationView.Restaurant_id,
                User_id = ReservationView.User_id,
            };
        }

        public List<ReservationModel> Convert_To_ReservationModel(List<ReservationViewModel> restaurantView)
        {
            return restaurantView.Select(x => Convert_To_ReservationModel(x)).ToList();
        }
    }
}
