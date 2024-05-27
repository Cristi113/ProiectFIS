using NUnit.Framework;
using Hotel_Management_System;

namespace Hotel_Management_System_Test
{
    [TestFixture]
    public class RequestServicesFormTests
    {
        [Test]
        public void Test_SaveGuestRequests_Success()
        {
            RequestServicesClass requests = new RequestServicesClass();
            var form = new RequestServicesForm();

            var result = form.SaveGuestRequests("Yes", "Yes", "Yes", "Yes");

            Assert.IsTrue(result);
        }

        [Test]
        public void Test_SaveGuestRequests_Failure()
        {
            RequestServicesClass requests = new RequestServicesClass();
            var form = new RequestServicesForm();

            var result = form.SaveGuestRequests("Invalid", "Input", "Here", "No");
            Assert.IsFalse(result);
        }
    }
}
