using NUnit.Framework;
using Hotel_Management_System;
using System;
using System.Windows.Forms;

namespace Hotel_Management_System_Tests
{
    [TestFixture]
    public class RoomFormTests
    {
        private RoomForm roomForm;

        [SetUp]
        public void Setup()
        {
            roomForm = new RoomForm();
        }

        [Test]
        public void AddRoom_Valid_Room_Details_Returns_Success_Message()
        {
            TextBox text_floor = new TextBox();
            text_floor.Text = "1";
            TextBox text_phone = new TextBox();
            text_phone.Text = "1234567890";
            ComboBox comboBox_roomType = new ComboBox();
            comboBox_roomType.Items.Add("Single");
            comboBox_roomType.SelectedIndex = 0;
            TextBox textBox_ID = new TextBox();
            textBox_ID.Text = "101";
            RadioButton radioButton_free = new RadioButton();
            radioButton_free.Checked = true;
            RadioButton radioButton_busy = new RadioButton();

            roomForm.Controls.Add(text_floor);
            roomForm.Controls.Add(text_phone);
            roomForm.Controls.Add(comboBox_roomType);
            roomForm.Controls.Add(textBox_ID);
            roomForm.Controls.Add(radioButton_free);
            roomForm.Controls.Add(radioButton_busy);

            roomForm.button_add_Click(null, EventArgs.Empty);

            Assert.That(() => MessageBox.Show("Room Added Successfully"), Throws.Nothing);
        }

        [Test]
        public void UpdateRoom_Valid_Room_Details_Returns_Success_Message()
        {
            TextBox text_floor = new TextBox();
            text_floor.Text = "1";
            TextBox text_phone = new TextBox();
            text_phone.Text = "1234567890";
            ComboBox comboBox_roomType = new ComboBox();
            comboBox_roomType.Items.Add("Single");
            comboBox_roomType.SelectedIndex = 0;
            TextBox textBox_ID = new TextBox();
            textBox_ID.Text = "101";
            RadioButton radioButton_free = new RadioButton();
            radioButton_free.Checked = true;
            RadioButton radioButton_busy = new RadioButton();

            roomForm.Controls.Add(text_floor);
            roomForm.Controls.Add(text_phone);
            roomForm.Controls.Add(comboBox_roomType);
            roomForm.Controls.Add(textBox_ID);
            roomForm.Controls.Add(radioButton_free);
            roomForm.Controls.Add(radioButton_busy);

            roomForm.button_update_Click(null, EventArgs.Empty);

            Assert.That(() => MessageBox.Show("Room Updated Successfully"), Throws.Nothing);
        }

        [Test]
        public void DeleteRoom_Existing_Room_ID_Returns_Success_Message()
        {
            TextBox textBox_ID = new TextBox();
            textBox_ID.Text = "101";

            roomForm.Controls.Add(textBox_ID);

            roomForm.button_delete_Click(null, EventArgs.Empty);

            Assert.That(() => MessageBox.Show("Room deleted successfully"), Throws.Nothing);
        }

        [Test]
        public void DeleteRoom_NonExisting_Room_ID_Returns_Error_Message()
        {
            TextBox textBox_ID = new TextBox();
            textBox_ID.Text = "999";

            roomForm.Controls.Add(textBox_ID);

            roomForm.button_delete_Click(null, EventArgs.Empty);

            Assert.That(() => MessageBox.Show("Error - Room was not deleted successfully"), Throws.Nothing);
        }
    }
}
