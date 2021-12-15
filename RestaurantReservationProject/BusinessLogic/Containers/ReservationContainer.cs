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

        IReservationContainerContext _reservationContainerDal;
        ReservationLogicConverter _reservationLogicConverter;
        public ReservationContainer(IReservationContainerContext reservationContainerDal, ReservationLogicConverter reservationLogicConverter)
        {
            _reservationContainerDal = reservationContainerDal;
            _reservationLogicConverter = reservationLogicConverter;
        }
        public void create(ReservationModel reservation, int d, int s)
        {
            _reservationContainerDal.create(_reservationLogicConverter.Convert_To_ReservationDto(reservation));
            //if created return
            //else exeption return message
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservationModel> GetList()
        {
            List<ReservationModel> reservations = _reservationLogicConverter.Convert_To_ReservationModel(_reservationContainerDal.GetList());
            return reservations;
        }

        public ReservationModel getReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
