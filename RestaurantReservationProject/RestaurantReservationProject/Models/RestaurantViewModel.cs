using BusinessLogic.Models;
using System;


namespace Presentation.models
{
    public class RestaurantViewModel
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

        public RestaurantViewModel()
        {
        }

        public RestaurantViewModel(int id, string name, string info, string address, int telephone, string email)
        {
            Id = id;
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            this.Email = email;
        }

        public RestaurantViewModel(string name, string info, string address, int telephone, string email)
        {
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            this.Email = email;
        }
        public RestaurantModel convertToLogic()
        {
            return new RestaurantModel(Id, Name, Info, Address, Telephone, Email);
        }
        public RestaurantViewModel(RestaurantModel restaurant)
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
