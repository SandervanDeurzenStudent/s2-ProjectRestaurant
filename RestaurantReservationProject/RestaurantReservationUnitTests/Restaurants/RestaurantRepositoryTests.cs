using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;
using BusinessLogic.Restraurants;
using DataAcces.interfaces.interfaces;
using DataAccess.interfaces.RestaurantsDto;
using DataAccess.Repositories;
using DataAccess.Repository;
using NUnit.Framework;

namespace RestaurantReservationUnitTests.Restaurants
{
    public class RestaurantRepositoryTests
    {
        RestaurantMemoryContext _restaurantMemoryContext;
        RestaurantRepository _restaurantRepository;

        [SetUp]
        public void SetUp()
        {
            // initialize here
            _restaurantMemoryContext = new RestaurantMemoryContext();
            _restaurantRepository = new RestaurantRepository(_restaurantMemoryContext, _restaurantMemoryContext);
        }
        //CREATE
        [Test]
        public void Should_createRestaurant()
        {
        //Arrange
        //act
         _restaurantRepository.create(new RestaurantDto(3, "restaurantName", "Info", "111166 AA", 32432, "frfjr"));
        //Assert
         Assert.AreEqual(_restaurantMemoryContext.restaurantList.Count, 2);
        }

        [Test]
        public void Create_Restaurant_Should_createRestaurant_DifferentId()
        {
            //Arrange
            //act
            _restaurantRepository.create(new RestaurantDto(234, "restaurantName", "Info", "111166 AA", 32432, "frfjr"));
            //Assert
            Assert.AreEqual(_restaurantMemoryContext.restaurantList.Count, 2);
        }

        [Test]
        public void Create_Restaurant_Should_GiveExeption()
        {
            //Arrange
            
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantMemoryContext.create(new RestaurantDto(-5, "restaurantName", "Info", "1111 AA", 32432, "frfjr"))); 
        }



        //GETRESTAURANTBYID
        [Test]
        public void getRestaurantByid_Should_return_Restaurant()
        {
            //Arrange
            
            //act
            var result = _restaurantRepository.getRestaurantById(1);
            //Assert
            var newRestaurantDto = ( 1, "restaurantName", "Info", "1111 AA", 32432, "frfjr");
            Assert.AreEqual(result.Id, newRestaurantDto.Item1);
        }

        [Test]
        public void getRestaurantById_Should_return_IdNotFoundExeption()
        {
            //Arrange
            
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.getRestaurantById(14335));
        }



        //DELETE
        [Test]
        public void deleteRestaurant_Should_deleteRestaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            f.Delete(1);
            //Assert
            Assert.AreEqual(f.restaurantList.Count, 0);
        }

        [Test]
        public void deleteRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.Delete(234565));
        }



        //Update
        [Test]
        public void updateRestaurant_Should_updateRestaurant()
        {
            //Arrange
            
            //act
            _restaurantRepository.update(1, new RestaurantDto(1, "NewRestaurantName", "Info", "1111 AA", 32432, "fddrfjr"));
            //Assert
            Assert.AreEqual(_restaurantMemoryContext.restaurantList[0].Name, "NewRestaurantName");
        }

        [Test]
        public void updateRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.update(234565, new RestaurantDto(3456, "NewrestaurantName", "Info", "1111 AA", 32432, "fddrfjr")));
        }

    }
}
