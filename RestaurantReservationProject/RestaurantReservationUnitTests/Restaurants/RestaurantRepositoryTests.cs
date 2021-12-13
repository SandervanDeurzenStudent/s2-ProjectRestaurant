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
            //var result = f.create(new RestaurantDalModel(-0, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert

            //Assert.Throws<ArgumentOutOfRangeException>(() => f.create(new RestaurantDalModel(-0, "restaurantName", "Info", "1111 AA", 32432, "frfjr")));

            //Assert.Contains("must be greater than or equal to zero.", ex.Message);
            Assert.Throws<ArgumentOutOfRangeException>(() => f.create((new RestaurantDalModel(-5, "restaurantName", "Info", "1111 AA", 32432, "frfjr")))); 
        }
        public void Should_Give()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            var result = f.create(new RestaurantDalModel(-0, "restaurantName", "Info", "1111 AA", 32432, "frfjr"));
            //Assert
            Assert.AreSame(new ArgumentException(), result);
        }
    }
}
