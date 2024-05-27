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
    public partial class DenyRoomsForm : Form
    {
        DenyRoomsClass denyRoom = new DenyRoomsClass();
        public DenyRoomsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_reservID.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_reservID.Text == "")
            {
                MessageBox.Show("Required Field - Reservation ID", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int id = Convert.ToInt32(textBox_reservID.Text);
                Boolean deleteReservation = denyRoom.deleteReservation(id);
                if (deleteReservation)
                {
                    MessageBox.Show("Reservation deleted successfully", "Reservation Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTable();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error - Reservation was not deleted successfully", "Error Deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getTable()
        {
            dataGridView_denyRoom.DataSource = denyRoom.getReservation();
        }

        private void DenyRoomsForm_Load(object sender, EventArgs e)
        {
            dataGridView_denyRoom.DefaultCellStyle.ForeColor = Color.Red;
            getTable();
        }

        private void dataGridView_denyRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_reservID.Text = dataGridView_denyRoom.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
