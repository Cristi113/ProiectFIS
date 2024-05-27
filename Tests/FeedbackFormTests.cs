using NUnit.Framework;
using Hotel_Management_System;
using System;

namespace HotelManagementSystemTests
{
    [TestFixture]
    public class FeedbackFormTests
    {
        [Test]
        public void ButtonClean_Click_Should_Reset_Controls()
        {
            var feedbackForm = new FeedbackForm();
            feedbackForm.guna2RatingStar_room.Value = 3;
            feedbackForm.guna2RatingStar_staff.Value = 4;
            feedbackForm.guna2RatingStar.Value = 5;
            feedbackForm.outputRatings.Text = "5";
            feedbackForm.label_staff0.Text = "4";
            feedbackForm.label_room0.Text = "3";
            feedbackForm.comboBox_hotel.SelectedIndex = 1; 

            feedbackForm.button_clean_Click(null, null);

            Assert.AreEqual(0, feedbackForm.guna2RatingStar_room.Value);
            Assert.AreEqual(0, feedbackForm.guna2RatingStar_staff.Value);
            Assert.AreEqual(0, feedbackForm.guna2RatingStar.Value);
            Assert.AreEqual("0", feedbackForm.outputRatings.Text);
            Assert.AreEqual("0", feedbackForm.label_staff0.Text);
            Assert.AreEqual("0", feedbackForm.label_room0.Text);
            Assert.AreEqual(0, feedbackForm.comboBox_hotel.SelectedIndex);
        }

        [Test]
        public void ButtonSave_Click_Without_Hotel_Selected_Should_Show_Error_Message()
        {
            var feedbackForm = new FeedbackForm();
            feedbackForm.comboBox_hotel.Text = "";

            feedbackForm.button_save_Click(null, null);

            Assert.AreEqual("Feedback Not Added Successfully", feedbackForm.MessageShown);
        }

        [Test]
        public void ButtonSave_Click_With_Hotel_Selected_Should_Show_Success_Message()
        {
            var feedbackForm = new FeedbackForm();
            feedbackForm.comboBox_hotel.Text = "1";

            feedbackForm.button_save_Click(null, null);

            Assert.AreEqual("Feedback Added Successfully", feedbackForm.MessageShown);
        }

        [Test]
        public void FeedbackForm_Load_Should_Load_Hotels_In_ComboBox()
        {
            var feedbackForm = new FeedbackForm();

            feedbackForm.FeedbackForm_Load(null, EventArgs.Empty);

            Assert.IsNotNull(feedbackForm.comboBox_hotel.DataSource);
        }

        [Test]
        public void Guna2RatingStar_ValueChanged_Should_Update_OutputRatings_Text()
        {
            var feedbackForm = new FeedbackForm();

            feedbackForm.guna2RatingStar_ValueChanged(null, EventArgs.Empty);

            Assert.AreEqual("1", feedbackForm.outputRatings.Text);
        }

        [Test]
        public void Guna2RatingStarStaff_ValueChanged_Should_Update_LabelStaff0_Text()
        {
            var feedbackForm = new FeedbackForm();

            feedbackForm.guna2RatingStar_staff_ValueChanged(null, EventArgs.Empty);

            Assert.AreEqual("1", feedbackForm.label_staff0.Text);
        }
    }
}
