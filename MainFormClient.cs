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
    public partial class MainFormClient : Form
    {
        public MainFormClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_logout.Height;
            panel_slide.Top = button_logout.Top;
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button_hotelSearch_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_hotelSearch.Height;
            panel_slide.Top = button_hotelSearch.Top;

            panel_main.Controls.Clear();
            HotelSearch hotelSearch = new HotelSearch();
            hotelSearch.TopLevel = false;
            hotelSearch.Dock = DockStyle.Fill;
            hotelSearch.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(hotelSearch);
            hotelSearch.Show();
        }
    }
}
