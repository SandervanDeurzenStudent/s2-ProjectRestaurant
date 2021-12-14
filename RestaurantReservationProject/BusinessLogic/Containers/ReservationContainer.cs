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

        IReservationContainerDal _reservationContainerDal;
        ReservationLogicConverter _reservationLogicConverter;
        public ReservationContainer(IReservationContainerDal reservationContainerDal, ReservationLogicConverter reservationLogicConverter)
        {
            _reservationContainerDal = reservationContainerDal;
            _reservationLogicConverter = reservationLogicConverter;
        }
        public void create(ReservationModel restaurant, int d, int s)
        {
            _reservationContainerDal.create(_reservationLogicConverter.Convert_To_ReservationDto(restaurant));
            //if created return
            //else exeption return message
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReservationModel> GetList()
        {
            throw new NotImplementedException();
        }

        public ReservationModel getReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
