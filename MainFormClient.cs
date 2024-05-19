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
    }
}
