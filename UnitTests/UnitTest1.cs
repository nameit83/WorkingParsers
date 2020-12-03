using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using FluentAssertions;
using System;

using AutoFixture;
using Chef;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void FridgeListDeserialiseTest()
        {
            var testJSON = new Fixture().Create<FridgeList>();

            var json = JsonConvert.SerializeObject(testJSON);
            var deserializedMessage = JsonConvert.DeserializeObject<FridgeList>(json);

            deserializedMessage.Should().BeEquivalentTo(testJSON);

            Console.WriteLine("Unit Test for Fridger List Deserialiser succesful");

        }
        [TestMethod]
        public void MealDBDeserialiseTest()
        {
            var testJSON = new Fixture().Create<MealDBObj>();

            var json = JsonConvert.SerializeObject(testJSON);
            var deserializedMessage = JsonConvert.DeserializeObject<MealDBObj>(json);

            deserializedMessage.Should().BeEquivalentTo(testJSON);

            Console.WriteLine("Unit Test for MealDB Deserialiser succesful");

        }
    }
}
