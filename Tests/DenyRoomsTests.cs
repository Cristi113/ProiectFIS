using NUnit.Framework;
using System;
using Hotel_Management_System;
using System.Data;

namespace HotelManagementSystem.Tests
{
    [TestFixture]
    public class DenyRoomsClassTests
    {
        private DenyRoomsClass denyRooms;

        [SetUp]
        public void Setup()
        {
            denyRooms = new DenyRoomsClass();
        }

        [Test]
        public void DeleteReservation_ExistingReservationID_ReturnsTrue()
        {
            int existingReservationID = 1;
            bool result = denyRooms.deleteReservation(existingReservationID);
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteReservation_NonExistingReservationID_ReturnsFalse()
        {
            int nonExistingReservationID = 9999;
            bool result = denyRooms.deleteReservation(nonExistingReservationID);
            Assert.IsFalse(result);
        }

        [Test]
        public void GetReservation_ReturnsDataTable()
        {
            DataTable result = denyRooms.getReservation();

            Assert.IsNotNull(result);
            Assert.Greater(result.Rows.Count, 0);
        }
    }
}
