using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public  class Restaurant
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
        public Restaurant(int id, string name, string info, string address, int telephone, string email)
        {
            Id = id;
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            Email = email;
        }

        public Restaurant(string name, string info, string address, int telephone, string email)
        {
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            Email = email;
        }
        public Restaurant(RestaurantDto restaurantDto)
        {
            Id = restaurantDto.Id;
            Name = restaurantDto.Name;
            Info = restaurantDto.Info;
            Address = restaurantDto.Address;
            Telephone = restaurantDto.Telephone;
            Email = restaurantDto.Email;
        }
        public RestaurantDto convertToDto()
        {
            return new RestaurantDto(Id, Name, Info, Address, Telephone, Email);
        }
    }
}

