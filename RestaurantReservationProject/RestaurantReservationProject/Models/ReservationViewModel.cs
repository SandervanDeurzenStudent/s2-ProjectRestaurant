using BusinessLogic.Models;
using BusinessLogic.Models.Reservation;

namespace Presentation.Models
{
    public class ReservationViewModel
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
        

        public ReservationViewModel()
        {
        }
        public ReservationViewModel(ReservationModel restaurant)
        {
            Id = restaurant.Id;
            Date = restaurant.Date;
            Time = restaurant.Time;
            Restaurant_id = 3;
            User_id = 1;
        }
    }
}
