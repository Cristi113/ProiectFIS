using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System
{
    public partial class HotelSearch : Form
    {
        HotelSearchClass hotelSearch = new HotelSearchClass();
        public HotelSearch()
        {
            InitializeComponent();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_hotelName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_hotelName.Text == "")
            {
                MessageBox.Show("Required Field - Hotel Name", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string hotelName = textBox_hotelName.Text;
                Boolean selectHotel = hotelSearch.selectHotel(hotelName);
                if (selectHotel)
                {
                    getTable();
                }
                else
                {
                    MessageBox.Show("Hotel name not found", "Error Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    getTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HotelSearch_Load(object sender, EventArgs e)
        {
            getTable();
        }
        private void getTable()
        {
            dataGridView_hotelSearch.DataSource = hotelSearch.getHotel();
        }

        private void dataGridView_hotelSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_hotelName.Text = dataGridView_hotelSearch.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
