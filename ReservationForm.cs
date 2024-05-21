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
        HotelSearchClass hotelSearch = new HotelSearchClass();
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "label";
            comboBox_roomType.ValueMember = "categoryID";

            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());

            comboBox_roomId.DataSource = reservation.roomByType(type);
            comboBox_roomId.DisplayMember = "roomID";
            comboBox_roomId.ValueMember = "roomID";

            comboBox_hotelName.DataSource = hotelSearch.getHotel2();
            comboBox_hotelName.DisplayMember = "hotelName";
            comboBox_hotelName.ValueMember = "hotelName";


            getReservTable();
        }

        public void getReservTable()
        {
            dataGridView_reserv.DataSource = reservation.getReserv();
        }

        private void comboBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(comboBox_roomType.SelectedValue);
                comboBox_roomId.DataSource = reservation.roomByType(type);
                comboBox_roomId.DisplayMember = "roomID";
                comboBox_roomId.ValueMember = "roomID";
            }
            catch(Exception)
            {
                //
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string guestID = textBox_guestId.Text;
                string roomID = comboBox_roomId.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_dateIn.Value;
                DateTime dOut = dateTimePicker_dateOut.Value;
                string hotelName = comboBox_hotelName.SelectedValue.ToString();

                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation DateIn must be Today or After", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Reservation DateOut must be after DateIn", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.addReservation(guestID, roomID, dIn, dOut) && reservation.setReservRoom(roomID, "Busy"))
                    {
                        getReservTable();
                        MessageBox.Show("New reservation added Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation was not added Successfully", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_reserveId.Text = dataGridView_reserv.CurrentRow.Cells[0].Value.ToString();
            textBox_guestId.Text = dataGridView_reserv.CurrentRow.Cells[1].Value.ToString();

            string rid = dataGridView_reserv.CurrentRow.Cells[2].Value.ToString();
            comboBox_roomType.SelectedValue = reservation.typeByRoomID(rid);
            comboBox_roomId.Text = rid;

            string hotelName = dataGridView_reserv.CurrentRow.Cells[5].Value.ToString();
            comboBox_hotelName.SelectedValue = hotelSearch.typeByHotelName(hotelName);
            comboBox_hotelName.Text = hotelName;

            dateTimePicker_dateIn.Text = dataGridView_reserv.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_dateOut.Text = dataGridView_reserv.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_reserveId.Clear();
            textBox_guestId.Clear();
            comboBox_roomType.SelectedValue = 1;
            dateTimePicker_dateIn.Value = DateTime.Now;
            dateTimePicker_dateOut.Value = DateTime.Now;
        }
    }
}
