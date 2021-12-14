using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.interfaces.Dtos
{
    public class ReservationDto
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

        public ReservationDto()
        {
        }
    }
}
