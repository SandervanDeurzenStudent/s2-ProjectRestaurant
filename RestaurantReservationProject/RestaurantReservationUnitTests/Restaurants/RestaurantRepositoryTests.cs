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

        private IRestaurantContainerContext _restaurantContainerContext;
        private IRestaurantContext _restaurantContext;
        private RestaurantMemoryContext _restaurantMemoryContext = new RestaurantMemoryContext();
        
        private RestaurantRepository _restaurantRepository = new RestaurantRepository();

        [SetUp]
        public void SetUp()
        {
            // initialize here
            _restaurantContainerContext = new RestaurantMemoryContext();
            _restaurantContext = new RestaurantMemoryContext();
            _restaurantRepository = new RestaurantRepository(_restaurantContainerContext, _restaurantContext);
        }
        //CREATE
        [Test]
        public void Should_createRestaurant()
        {
            //Arrange
            //act
             _restaurantRepository.create(new RestaurantDto(3, "restaurantName", "Info", "111166 AA", 32432, "frfjr"));
            //Assert
            //Assert.AreEqual(_restaurantRepository., 1);
            
        }

        [Test]
        public void Create_Restaurant_Should_createRestaurant_DifferentId()
        {
            //Arrange
            //act
            _restaurantRepository.create(new RestaurantDto(33434, "restaurantttttName", "Info", "111166tt5 AA", 32432, "frfjr"));
            //Assert
            Assert.AreEqual(_restaurantContainerContext.returnList().Count, 1);
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
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _restaurantRepository.getRestaurantById(1));
        }



        //DELETE
        [Test]
        public void deleteRestaurant_Should_deleteRestaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
             _restaurantRepository.Delete(1);
            //Assert
            Assert.AreEqual(f.restaurantList.Count, 0);
        }

        [Test]
        public void deleteRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.Delete(234565));
        }



        //Update
        [Test]
        public void updateRestaurant_Should_updateRestaurant()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            f.update(1, new RestaurantDto(1, "NewRestaurantName", "Info", "1111 AA", 32432, "fddrfjr"));
            //Assert
            Assert.AreEqual(f.restaurantList[0].Name, "NewRestaurantName");
        }

        [Test]
        public void updateRestaurant_Should_giveException_IdNotFound()
        {
            //Arrange
            var f = new RestaurantMemoryContext();
            //act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => f.update(234565, new RestaurantDto(3456, "NewrestaurantName", "Info", "1111 AA", 32432, "fddrfjr")));
        }

    }
}
