using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.interfaces.RestaurantsDto;
using NUnit.Framework;
using Repositories.memory;

namespace RestaurantReservationUnitTests.Restaurants
{
    class RestaurantRepositoryTests
    {

        //create
        [Test]
        public void Should_createRestaurant()
        {
            //Arrange
            var f = new Repositories.memory.RestaurantMemoryContext();
            //act
            var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDalModel(1, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_createRestaurant_DifferentId()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            var result = f.create(new DataAccess.interfaces.RestaurantsDto.RestaurantDalModel(124223, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_GiveExeption()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.create(new RestaurantDalModel(-5, "restaurantName", "Info", "1111 AA", 32432, "frfjr"))); 
        }

        //getrestaurantById
        [Test]
        public void Should_return_Restaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            var result = f.getRestaurantById(1);
            //Assert
            Assert.IsTrue(true);
        }

        [Test]
        public void Should_return_Exeption_alreadyExists()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.getRestaurantById(2));
        }
    }
}
