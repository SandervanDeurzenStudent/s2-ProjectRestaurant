using BusinessLogic.Models;
using System;


namespace Presentation.models
{
    public class RestaurantModel
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Info
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int Telephone
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public Restaurant convertToLogic()
        {
            return new Restaurant(Id, Name, Info, Address, Telephone, Email);
        }
        public RestaurantModel(Restaurant restaurant)
        {
            Id = restaurant.Id;
            Name = restaurant.Name;
            Info = restaurant.Info;
            Address = restaurant.Address;
            Telephone = restaurant.Telephone;
            Email = restaurant.Email;

        }
    }
}
