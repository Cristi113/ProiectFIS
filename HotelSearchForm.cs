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
    public partial class HotelSearchForm : Form
    {
        HotelSearchClass hotelSearch = new HotelSearchClass();
        public HotelSearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_hotelName.Clear();
        }

        private void button_search_Click(object sender, EventArgs e)
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
                    getTable(); 
                    //dataGridView_hotelSearch.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //dataGridView_hotelSearch.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void getTable(string hotelName = null)
        {
            dataGridView_hotelSearch.DataSource = hotelSearch.getHotel(hotelName);

            if (dataGridView_hotelSearch.Columns.Count > 0)
            {
                dataGridView_hotelSearch.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_hotelSearch.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewRow row in dataGridView_hotelSearch.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(hotelName, StringComparison.OrdinalIgnoreCase))
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.Font = new Font(dataGridView_hotelSearch.Font, FontStyle.Bold);
                }
            }
        }

        private void HotelSearchForm_Load(object sender, EventArgs e)
        {
            //getTable();

            //dataGridView_hotelSearch.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView_hotelSearch.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView_hotelSearch_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_hotelName.Text = dataGridView_hotelSearch.CurrentRow.Cells[0].Value.ToString();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
