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
    public partial class RoomForm : Form
    {
        RoomClass room = new RoomClass();
        public RoomForm()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "label";
            comboBox_roomType.ValueMember = "categoryID";
            getRooms();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int floor = Convert.ToInt32(text_floor.Text);
            string phone = text_phone.Text;
            string status = radioButton_free.Checked ? "Free" : "Busy";
            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            string id = textBox_ID.Text;
            try
            {

                if (room.addRoom(id, floor, phone, status, type))
                {
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRooms();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            text_floor.Clear();
            text_phone.Clear();
            textBox_ID.Clear();
            comboBox_roomType.SelectedIndex = 0;
        }

        private void getRooms()
        {
            dataGridView_room.DataSource = room.getRooms();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string phone = text_phone.Text;
            string status = radioButton_free.Checked ? "Free" : "Busy";
            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            string id = textBox_ID.Text;
            int floor = Convert.ToInt32(text_floor.Text);

            try
            {
                if (room.updateRoom(id, floor, phone, status, type))
                {
                    MessageBox.Show("Room Updated Successfully", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRooms();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Updated Successfully", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridView_room.CurrentRow.Cells[0].Value.ToString();
            comboBox_roomType.SelectedValue = dataGridView_room.CurrentRow.Cells[1].Value.ToString();
            text_phone.Text = dataGridView_room.CurrentRow.Cells[2].Value.ToString();
            string rButton = dataGridView_room.CurrentRow.Cells[3].Value.ToString();
            if (rButton.Equals("Free"))
            {
                radioButton_free.Checked = true;
            }
            else
            {
                radioButton_busy.Checked = true;
            }
            text_floor.Text = dataGridView_room.CurrentRow.Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Required field Room ID is missing:", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_ID.Text;
                    Boolean deleteGuest = room.deleteRoom(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("Room deleted successfully", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRooms();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error - Room was not deleted successfully", "Error Deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}