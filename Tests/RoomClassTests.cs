using NUnit.Framework;
using Hotel_Management_System;
using System.Data;

namespace Hotel_Management_System_Tests
{
    [TestFixture]
    public class RoomClassTests
    {
        private RoomClass roomClass;

        [SetUp]
        public void Setup()
        {
            roomClass = new RoomClass();
        }

        [Test]
        public void GetRoomType_Returns_DataTable_With_Data()
        {

            DataTable result = roomClass.getRoomType();

            Assert.IsNotNull(result);
            Assert.Greater(result.Rows.Count, 0);
        }

        [Test]
        public void AddRoom_Valid_Room_Details_Returns_True()
        {
            string id = "101";
            int floor = 1;
            string phone = "1234567890";
            string status = "Free";
            string type = "Single";

            bool result = roomClass.addRoom(id, floor, phone, status, type);

            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateRoom_Valid_Room_Details_Returns_True()
        {
            string id = "101";
            int floor = 1;
            string phone = "1234567890";
            string status = "Free";
            string type = "Single";

            bool result = roomClass.updateRoom(id, floor, phone, status, type);

            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteRoom_Existing_Room_ID_Returns_True()
        {
            string id = "101";

            bool result = roomClass.deleteRoom(id);

            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteRoom_NonExisting_Room_ID_Returns_False()
        {
            string id = "999999";

            bool result = roomClass.deleteRoom(id);

            Assert.IsFalse(result);
        }
    }
}
