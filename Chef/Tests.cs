using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using AutoFixture;
using FluentAssertions;
using System.Text;

namespace Chef
{
    public class Tests
    {
        [Test]
        public void FridgeListDeserialiseTest()
        {
            var testJSON = new Fixture().Create<FridgeList>();

            var json = JsonConvert.SerializeObject(testJSON);
            var deserializedMessage = JsonConvert.DeserializeObject<FridgeList>(json);

            deserializedMessage.Should().BeEquivalentTo(testJSON);

            Console.WriteLine("Unit Test for Fridger List Deserialiser succesful");

        }
        [Test]
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
