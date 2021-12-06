using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
        public class Restaurant : IRestaurantLogic
    {
        IRestaurantDal restaurantDal;
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
        public Restaurant()
        {
           
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
        //convert the data from the view to Dto
        public RestaurantDto convertToDto()
        {
            return new RestaurantDto(Id, Name, Info, Address, Telephone, Email);
        }
        public RestaurantDto convertToDto(List<RestaurantContainer> restaurant)
        {
            return new RestaurantDto(Id, Name, Info, Address, Telephone, Email);
        }
        public void update(int id, Restaurant restaurant)
        {
             restaurantDal.update(id, restaurant.convertToDto());
        }
       
    }
}

