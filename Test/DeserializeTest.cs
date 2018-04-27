using DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
using Newtonsoft.Json;

namespace Test
{
    [TestFixture]
    class DeserializeTest
    {
        [TestCase]
        public void TestDeserializeSingleObjectFromFile()
        {
            RestaurantInfo restaurant;

            //Arrange
            using (StreamReader file = File.OpenText(@"C:\Users\Raptor\Downloads\singleRestaurantJson.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                restaurant = (RestaurantInfo)serializer.Deserialize(file, typeof(RestaurantInfo));
            }
            //Act
            int actual = restaurant.restaurantId;
            int expected = 1;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestCase]
        public void TestDeserializeMultipleObjectsFromFile()
        {
            List<RestaurantInfo> restaurants;

            //Arrange
            using (StreamReader file = File.OpenText(@"C:\Users\Raptor\Downloads\restaurantJson.json"))
            {
                restaurants = JsonConvert.DeserializeObject<List<RestaurantInfo>>(File.ReadAllText(@"C:\Users\Raptor\Downloads\restaurantJson.json"));
            }
            //Act
            int actualCount = restaurants.Count;
            int expectedCount = 2;

            //Assert
            Assert.Greater(actualCount, expectedCount);
        }

    }
}
