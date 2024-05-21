using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class MainFormClient : Form
    {
        public MainFormClient()
        {
            InitializeComponent();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_hotelSearch_Click_1(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            HotelSearch hotelSearch = new HotelSearch();
            hotelSearch.TopLevel = false;
            hotelSearch.Dock = DockStyle.Fill;
            hotelSearch.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(hotelSearch);
            hotelSearch.Show();
        }

        private void button_reception_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            RequestServicesForm services = new RequestServicesForm();
            services.TopLevel = false;
            services.Dock = DockStyle.Fill;
            services.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(services);
            services.Show();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            panel_main.Controls.Add(panel_cover);
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            ReservationForm rooms = new ReservationForm();
            rooms.TopLevel = false;
            rooms.Dock = DockStyle.Fill;
            rooms.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(rooms);
            rooms.Show();
        }
    }
}
