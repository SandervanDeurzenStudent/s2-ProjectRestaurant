using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void returnlist_restaurantReturnList_returnList()
        {
            //Arrange
            var f = new BusinessLogic.Restraurants.RestaurantCollectionController();
            //act
            var result = f.ReturnList(5);
            //Assert
            Assert.IsNotEmpty(result.ToString());
        }
    }
}