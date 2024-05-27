using NUnit.Framework;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System.Tests
{
    [TestFixture]
    public class RequestServicesClassTests
    {
        [Test]
        public void SaveGuestRequests_ReturnsTrue_WhenInsertSucceeds()
        {
            string roomService = "Yes";
            string cleanService = "Yes";
            string extraTowels = "No";
            string extraBed = "Yes";
          
            var requestServicesClass = new RequestServicesClass();
          
            bool result = requestServicesClass.SaveGuestRequests(roomService, cleanService, extraTowels, extraBed);

            Assert.IsTrue(result);
        }
    }
}
