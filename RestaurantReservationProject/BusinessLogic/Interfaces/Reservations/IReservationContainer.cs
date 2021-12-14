using BusinessLogic.Models.Reservation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces.Reservations
{
    interface IReservationContainer
    {
        void create(ReservationModel restaurant);
        void Delete(int id);
        List<ReservationModel> GetList();
        ReservationModel getReservationById(int id);
    }
}
