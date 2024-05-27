using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Management_System
{
    public partial class FeedbackForm : Form
    {
        FeedbackClass feedback = new FeedbackClass();
        HotelSearchClass hotelSearch = new HotelSearchClass();
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2RatingStar_ValueChanged(object sender, EventArgs e)
        {
            if(guna2RatingStar.Value == 1)
            {
                outputRatings.Text = Convert.ToString(1);
            }
            if (guna2RatingStar.Value == 2)
            {
                outputRatings.Text = Convert.ToString(2);
            }
            if (guna2RatingStar.Value == 3)
            {
                outputRatings.Text = Convert.ToString(3);
            }
            if (guna2RatingStar.Value == 4)
            {
                outputRatings.Text = Convert.ToString(4);
            }
            if (guna2RatingStar.Value == 5)
            {
                outputRatings.Text = Convert.ToString(5);
            }
            if (guna2RatingStar.Value == 1.5)
            {
                outputRatings.Text = Convert.ToString(1.5);
            }
            if (guna2RatingStar.Value == 2.5)
            {
                outputRatings.Text = Convert.ToString(2.5);
            }
            if (guna2RatingStar.Value == 3.5)
            {
                outputRatings.Text = Convert.ToString(3.5);
            }
            if (guna2RatingStar.Value == 4.5)
            {
                outputRatings.Text = Convert.ToString(4.5);
            }
        }

        private void guna2RatingStar_staff_ValueChanged(object sender, EventArgs e)
        {
            if (guna2RatingStar_staff.Value == 1)
            {
                label_staff0.Text = Convert.ToString(1);
            }
            if (guna2RatingStar_staff.Value == 2)
            {
                label_staff0.Text = Convert.ToString(2);
            }
            if (guna2RatingStar_staff.Value == 3)
            {
                label_staff0.Text = Convert.ToString(3);
            }
            if (guna2RatingStar_staff.Value == 4)
            {
                label_staff0.Text = Convert.ToString(4);
            }
            if (guna2RatingStar_staff.Value == 5)
            {
                label_staff0.Text = Convert.ToString(5);
            }
            if (guna2RatingStar_staff.Value == 1.5)
            {
                label_staff0.Text = Convert.ToString(1.5);
            }
            if (guna2RatingStar_staff.Value == 2.5)
            {
                label_staff0.Text = Convert.ToString(2.5);
            }
            if (guna2RatingStar_staff.Value == 3.5)
            {
                label_staff0.Text = Convert.ToString(3.5);
            }
            if (guna2RatingStar_staff.Value == 4.5)
            {
                label_staff0.Text = Convert.ToString(4.5);
            }
        }

        private void guna2RatingStar_room_ValueChanged(object sender, EventArgs e)
        {
            if (guna2RatingStar_room.Value == 1)
            {
                label_room0.Text = Convert.ToString(1);
            }
            if (guna2RatingStar_room.Value == 2)
            {
                label_room0.Text = Convert.ToString(2);
            }
            if (guna2RatingStar_room.Value == 3)
            {
                label_room0.Text = Convert.ToString(3);
            }
            if (guna2RatingStar_room.Value == 4)
            {
                label_room0.Text = Convert.ToString(4);
            }
            if (guna2RatingStar_room.Value == 5)
            {
                label_room0.Text = Convert.ToString(5);
            }
            if (guna2RatingStar_room.Value == 1.5)
            {
                label_room0.Text = Convert.ToString(1.5);
            }
            if (guna2RatingStar_room.Value == 2.5)
            {
                label_room0.Text = Convert.ToString(2.5);
            }
            if (guna2RatingStar_room.Value == 3.5)
            {
                label_room0.Text = Convert.ToString(3.5);
            }
            if (guna2RatingStar_room.Value == 4.5)
            {
                label_room0.Text = Convert.ToString(4.5);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(comboBox_hotel.Text=="")
            {
                MessageBox.Show("Feedback Not Added Successfully", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int hotelID = Convert.ToInt32(comboBox_hotel.Text);
            try
            {
                if(feedback.addFeedback(hotelID, outputRatings.Text, label_staff0.Text, label_room0.Text))
                {
                    MessageBox.Show("Feedback Added Successfully", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Feedback Not Added Successfully", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_clean.PerformClick();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            guna2RatingStar_room.Value = 0;
            guna2RatingStar_staff.Value = 0;
            guna2RatingStar.Value = 0;
            outputRatings.Text = Convert.ToString(0);
            label_staff0.Text = Convert.ToString(0);
            label_room0.Text = Convert.ToString(0);
            comboBox_hotel.SelectedIndex = 0;
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            comboBox_hotel.DataSource = hotelSearch.getHotelID();
            comboBox_hotel.DisplayMember = "hotelID";
            comboBox_hotel.ValueMember = "hotelID";
        }
    }
}
