using NUnit.Framework;
using System;
using Hotel_Management_System;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem.Tests
{
    [TestFixture]
    public class ReservationClassTests
    {
        private ReservationClass reservation;

        [SetUp]
        public void Setup()
        {
            reservation = new ReservationClass();
        }

        [Test]
        public void RoomByType_ReturnsDataTable()
        {
            int roomType = 1;

            DataTable result = reservation.roomByType(roomType);

            Assert.IsNotNull(result);
            Assert.Greater(result.Rows.Count, 0);
        }

        [Test]
        public void TypeByRoomID_ReturnsRoomType()
        {
            string roomID = "1";
            int expectedRoomType = 1;

            int result = reservation.typeByRoomID(roomID);

            Assert.AreEqual(expectedRoomType, result);
        }

        [Test]
        public void GetReserv_ReturnsDataTable()
        {
            DataTable result = reservation.getReserv();

            Assert.IsNotNull(result);
            Assert.Greater(result.Rows.Count, 0);
        }

        [Test]
        public void SetReservRoom_ValidRoomIDAndStatus_ReturnsTrue()
        {
            string roomID = "1";
            string status = "Busy";

            bool result = reservation.setReservRoom(roomID, status);

            Assert.IsTrue(result);
        }

        [Test]
        public void AddReservation_ValidData_ReturnsTrue()
        {
            string guestID = "1";
            string roomID = "1";
            DateTime dateIn = DateTime.Now;
            DateTime dateOut = DateTime.Now.AddDays(1);
            int hotelID = 1;

            bool result = reservation.addReservation(guestID, roomID, dateIn, dateOut, hotelID);

            Assert.IsTrue(result);
        }
    }
}
