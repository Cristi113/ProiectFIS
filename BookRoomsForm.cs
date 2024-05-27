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
    public partial class BookRoomsForm : Form
    {
        BookRoomClass room = new BookRoomClass();
        HotelSearchClass hotelSearch = new HotelSearchClass();
        public BookRoomsForm()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_hotelName.Text == "")
            {
                MessageBox.Show("Required Field - Hotel Name", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string hotelName = textBox_hotelName.Text;
                Boolean selectHotel = hotelSearch.selectHotel(hotelName);
                if (selectHotel)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("HotelInfo", typeof(string));
                    dataTable.Rows.Add(hotelSearch.getHotelName(hotelName));

                    // Set the DataTable as the DataSource for the DataGridView
                    dataGridView_room.DataSource = dataTable;
                    //getTable();
                   
                    //dataGridView_hotelSearch.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //dataGridView_hotelSearch.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    getTable();
                    MessageBox.Show("Hotel name not found", "Error Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getTable(string hotelName = null)
        {
            dataGridView_room.DataSource = hotelSearch.getHotel(hotelName);

            if (dataGridView_room.Columns.Count > 0)
            {
                dataGridView_room.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_room.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewRow row in dataGridView_room.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(hotelName, StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                    row.DefaultCellStyle.Font = new Font(dataGridView_room.Font, FontStyle.Bold);
                }
            }
        }

        private void dataGridView_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_hotelName.Text = dataGridView_room.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
