using NUnit.Framework;
using System;
using Hotel_Management_System;
using System.Data;

namespace HotelManagementSystem.Tests
{
    [TestFixture]
    public class OccupiedRoomsClassTests
    {
        private OccupiedRoomsClass occupiedRooms;

        [SetUp]
        public void Setup()
        {
            occupiedRooms = new OccupiedRoomsClass();
        }

        [Test]
        public void SelectRooms_ReturnsDataTable()
        {
            DataTable result = occupiedRooms.selectRooms();

            Assert.IsNotNull(result);
            Assert.Greater(result.Rows.Count, 0);
        }
    }
}
