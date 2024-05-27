using NUnit.Framework;
using MySql.Data.MySqlClient;
using System.Data;
using Hotel_Management_System;

namespace HotelManagementSystem.Tests
{
    [TestFixture]
    public class GuestClassTests
    {
        private GuestClass guestClass;
        private DataBaseConnection dbConnection;

        [SetUp]
        public void Setup()
        {
            dbConnection = new DataBaseConnection();
            guestClass = new GuestClass();
        }

        [Test]
        public void InsertGuest_ValidData_ReturnsTrue()
        {
            string id = "1";
            string fname = "John";
            string lname = "Doe";
            string phone = "1234567890";
            string city = "New York";

            bool result = guestClass.insertGuest(id, fname, lname, phone, city);

            Assert.IsTrue(result);
        }

        [Test]
        public void GetGuest_ReturnsDataTable()
        {
            DataTable result = guestClass.getGuest();
            Assert.IsInstanceOf<DataTable>(result);
        }

        [Test]
        public void GuestEdit_ValidData_ReturnsTrue()
        {
            string id = "1";
            string fname = "Jane";
            string lname = "Doe";
            string phone = "0987654321";
            string city = "Los Angeles";
            bool result = guestClass.guestEdit(id, fname, lname, phone, city);
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteGuest_ValidId_ReturnsTrue()
        {
            string id = "1";
            bool result = guestClass.deleteGuest(id);
            Assert.IsTrue(result);
        }
    }
}