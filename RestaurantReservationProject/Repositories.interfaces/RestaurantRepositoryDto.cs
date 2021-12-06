using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.interfaces
{
    class RestaurantRepositoryDto
    {
        public RestaurantRepositoryDto()
        {
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
        public RestaurantRepositoryDto(int id, string name, string info, string address, int telephone, string email)
        {
            Id = id;
            Name = name;
            Info = info;
            Address = address;
            Telephone = telephone;
            Email = email;
        }
        public RestaurantRepositoryDto convertToDto()
        {
            return new RestaurantRepositoryDto(Id, Name, Info, Address, Telephone, Email);
        }
    }
}

