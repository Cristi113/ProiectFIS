using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace Hotel_Management_System.Tests
{
    [TestFixture]
    public class MainFormTests
    {
        [Test]
        public void ButtonHomeClick_PanelMainShouldContainPanelCover()
        {
            MainForm mainForm = new MainForm();

            mainForm.button_home_Click(null, EventArgs.Empty);

            Assert.IsTrue(mainForm.panel_main.Controls.Contains(mainForm.panel_cover));
        }

        [Test]
        public void ButtonGuestClick_PanelMainShouldContainGuestForm()
        {

            MainForm mainForm = new MainForm();

            mainForm.button_guest_Click(null, EventArgs.Empty);

            Assert.IsInstanceOf<GuestForm>(mainForm.panel_main.Controls[0]);
        }

        [Test]
        public void ButtonReceptionClick_PanelMainShouldContainReservationForm()
        {

            MainForm mainForm = new MainForm();

            mainForm.button_reception_Click(null, EventArgs.Empty);

            Assert.IsInstanceOf<ReservationForm>(mainForm.panel_main.Controls[0]);
        }

        [Test]
        public void ButtonRoomClick_PanelMainShouldContainRoomForm()
        {

            MainForm mainForm = new MainForm();

            mainForm.button_room_Click(null, EventArgs.Empty);

            Assert.IsInstanceOf<RoomForm>(mainForm.panel_main.Controls[0]);
        }

        [Test]
        public void ButtonLogoutClick_ShouldShowLoginFormAndHideMainForm()
        {
            // Arrange
            MainForm mainForm = new MainForm();
            LoginForm loginForm = new LoginForm();

          mainForm.button_logout_Click(null, EventArgs.Empty);

            Assert.IsFalse(mainForm.Visible);
            Assert.IsTrue(loginForm.Visible);
        }
    }
}
