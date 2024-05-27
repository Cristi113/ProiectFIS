using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System
{
    internal class OccupiedRoomsClass
    {
        DataBaseConnection connection = new DataBaseConnection();
        public DataTable selectRooms()
        {
            string query = "select r.roomID,r.roomType,r.roomPhone,r.roomStatus,r.roomFloor from room r join reservation res on r.roomID = res.roomID where r.roomStatus = 'Busy' AND extract(day from CURRENT_DATE) BETWEEN extract(day from res.dateIn) and extract(day from res.dateOut) ";
            MySqlCommand command = new MySqlCommand(query, connection.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            try
            {
                connection.OpenCon();
                adapter.Fill(table);
            }
            finally
            {
                connection.CloseCon();
            }

            return table;
        }
    }
}