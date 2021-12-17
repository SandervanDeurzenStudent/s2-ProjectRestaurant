using BusinessLogic.Converter;
using BusinessLogic.Interfaces.Reservations;
using BusinessLogic.Models.Reservation;
using DataAccess.interfaces.interfaces.Reservations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Containers
{
    public class ReservationContainer : IReservationContainer
    {

        IReservationContainerContext _reservationContainerContext;
        ReservationLogicConverter _reservationLogicConverter = new ReservationLogicConverter();
        public ReservationContainer(IReservationContainerContext reservationContainerContext)
        {
            _reservationContainerContext = reservationContainerContext;
        }
        public void create(ReservationModel reservation, int d, int s)
        {
            _reservationContainerContext.create(_reservationLogicConverter.Convert_To_ReservationDto(reservation));
            //if created return
            //else exeption return message
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservationModel> GetList()
        {
            List<ReservationModel> reservations = _reservationLogicConverter.Convert_To_ReservationModel(_reservationContainerContext.GetList());
            return reservations;
        }

        public ReservationModel getReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
