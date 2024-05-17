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
    public partial class ReservationForm : Form
    {
        RoomClass room = new RoomClass();
        ReservationClass reservation = new ReservationClass();
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReservationForm_Load(object sender, EventArgs e) //////////////////// AICI NU GASESTE ROOMID
        {
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "label";
            comboBox_roomType.ValueMember = "categoryID";

            string type = comboBox_roomType.SelectedValue.ToString();
            comboBox_roomId.DataSource = reservation.roomByType(type);
            comboBox_roomId.DisplayMember = "roomID";
            comboBox_roomId.ValueMember = "roomID";
        }

        private void comboBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox_roomType.SelectedValue.ToString();
            comboBox_roomId.DataSource = reservation.roomByType(type);
            comboBox_roomId.DisplayMember = "roomID";
            comboBox_roomId.ValueMember = "roomID";
        }
    }
}
