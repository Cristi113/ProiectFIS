using NUnit.Framework;
using System;
using Hotel_Management_System;

namespace HotelManagementSystem.Tests
{
    [TestFixture]
    public class HotelSearchClassTests
    {
        private HotelSearchClass hotelSearch;

        [SetUp]
        public void Setup()
        {
            hotelSearch = new HotelSearchClass();
        }

        [Test]
        public void SelectHotel_ExistingHotelName_ReturnsTrue()
        {
            string existingHotelName = "Hotel A";
            bool result = hotelSearch.selectHotel(existingHotelName);
            Assert.IsTrue(result);
        }

        [Test]
        public void SelectHotel_NonExistingHotelName_ReturnsFalse()
        {
            string nonExistingHotelName = "NonExistingHotel";
            bool result = hotelSearch.selectHotel(nonExistingHotelName);
            Assert.IsFalse(result);
        }

        [Test]
        public void GetHotelName_ExistingHotelName_ReturnsSameName()
        {
            string existingHotelName = "Hotel A";
            string result = hotelSearch.getHotelName(existingHotelName);
            Assert.AreEqual(existingHotelName, result);
        }

        [Test]
        public void GetHotelName_NonExistingHotelName_ReturnsEmptyString()
        {
            string nonExistingHotelName = "NonExistingHotel";
            string result = hotelSearch.getHotelName(nonExistingHotelName);
            Assert.AreEqual("", result);
        }
    }
}
