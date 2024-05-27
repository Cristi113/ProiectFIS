using NUnit.Framework;
using Hotel_Management_System;

namespace HotelManagementSystemTests
{
    [TestFixture]
    public class MainFormClientTests
    {
        MainFormClient mainForm;

        [SetUp]
        public void Setup()
        {
            mainForm = new MainFormClient();
        }

        [Test]
        public void Test_ExitApplication()
        {
            mainForm.label2_Click_1(null, null);
            Assert.IsFalse(mainForm.Visible);
        }

        [Test]
        public void Test_Logout()
        {
            mainForm.button_logout_Click_1(null, null);
            Assert.IsTrue(mainForm.Owner is LoginForm);
        }

        [Test]
        public void Test_HotelSearch()
        {
            mainForm.button_hotelSearch_Click_1(null, null);
            Assert.IsTrue(mainForm.panel_main.Controls.Count > 0);
        }

        [Test]
        public void Test_OpenReception()
        {
            mainForm.button_reception_Click(null, null);
            Assert.IsTrue(mainForm.panel_main.Controls.Count > 0);
        }

        [Test]
        public void Test_OpenHome()
        {
            mainForm.button_home_Click(null, null);
            Assert.IsTrue(mainForm.panel_main.Controls.Contains(mainForm.panel_cover));
        }

        [Test]
        public void Test_OpenRoomReservation()
        {
            mainForm.button_room_Click(null, null);
            Assert.IsTrue(mainForm.panel_main.Controls.Count > 0);
        }

        [Test]
        public void Test_OpenFeedbackForm()
        {
            mainForm.button1_Click(null, null);
            Assert.IsTrue(mainForm.panel_main.Controls.Count > 0);
        }
    }
}
