using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models.Reservation
{
    public class ReservationModel
    {
        public int Id
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public int Restaurant_id
        {
            get;
            set;
        }
        public int User_id
        {
            get;
            set;
        }


        public ReservationModel()
        {
        }
    }
}
