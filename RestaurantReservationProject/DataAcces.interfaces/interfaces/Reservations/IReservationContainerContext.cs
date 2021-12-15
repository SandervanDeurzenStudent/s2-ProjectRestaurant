using DataAccess.interfaces.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.interfaces.interfaces.Reservations
{
    public interface IReservationContainerContext
    {
        void create(ReservationDto restaurant);
        void Delete(int id);
        List<ReservationDto> GetList();
        ReservationDto getReservationById(int id);
    }
}
