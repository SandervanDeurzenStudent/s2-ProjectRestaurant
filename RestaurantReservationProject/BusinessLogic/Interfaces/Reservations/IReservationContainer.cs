using BusinessLogic.Models.Reservation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces.Reservations
{
    public interface IReservationContainer
    {
        void create(ReservationModel reservation, int Restaurant_id, int user_id);
        void Delete(int id);
        List<ReservationModel> GetList();
        ReservationModel getReservationById(int id);
    }
}
