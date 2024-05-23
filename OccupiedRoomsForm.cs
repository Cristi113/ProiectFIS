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
    public partial class OccupiedRoomsForm : Form
    {
        OccupiedRoomsClass rooms = new OccupiedRoomsClass();

        public OccupiedRoomsForm()
        {
            InitializeComponent();
        }

        private void getOccupiedTable()
        {
            guna2DataGridView_occupiedRooms.DataSource = rooms.selectRooms();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OccupiedRoomsForm_Load(object sender, EventArgs e)
        {
            guna2DataGridView_occupiedRooms.ColumnHeadersVisible = true;
            guna2DataGridView_occupiedRooms.ColumnHeadersHeight = 20;
            getOccupiedTable();
        }
    }
}
