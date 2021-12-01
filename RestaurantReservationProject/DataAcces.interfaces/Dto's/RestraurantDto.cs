﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.interfaces.RestaurantsDto
{
    public  class RestaurantDto
    {
        private RestaurantDto restaurantDto;
        private RestaurantDto dto;

        public RestaurantDto()
        {
        }

        public RestaurantDto(RestaurantDto dto)
        {
            this.dto = dto;
        }

        public RestaurantDto(int id, string name, string info, string address, int telephone, string email)
        {
            Id = id;
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            Email = email;
        }
      

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
        public RestaurantDto convertToDto()
        {
            return new RestaurantDto(Id, Name, Info, Address, Telephone, Email);
        }
    }
}

