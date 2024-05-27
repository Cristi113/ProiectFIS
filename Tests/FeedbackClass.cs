using NUnit.Framework;
using System;

namespace Hotel_Management_System.Tests
{
    [TestFixture]
    public class FeedbackClassTests
    {
        private FeedbackClass feedbackClass;

        [SetUp]
        public void SetUp()
        {
            feedbackClass = new FeedbackClass();
        }

        [Test]
        public void AddFeedback_ValidFeedback_ReturnsTrue()
        {
            int hotelID = 1;
            string staffFriendliness = "Excellent";
            string roomCleanliness = "Very clean";
            string rating = "5";

            bool result = feedbackClass.addFeedback(hotelID, staffFriendliness, roomCleanliness, rating);

            Assert.IsTrue(result);
        }

        [Test]
        public void AddFeedback_InvalidFeedback_ReturnsFalse()
        {
            int hotelID = -1;
            string staffFriendliness = "Average";
            string roomCleanliness = "Dirty";
            string rating = "3";

            bool result = feedbackClass.addFeedback(hotelID, staffFriendliness, roomCleanliness, rating);

            Assert.IsFalse(result);
        }
    }
}
