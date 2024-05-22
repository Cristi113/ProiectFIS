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
        public bool selectRooms(string id, int floor, string phone, string status, string type)
        {
            string insertQuery = "select r.roomID,r.roomType,r.roomPhone,r.roomStatus,r.roomFloor from room r join reservation res on r.roomID = res.roomID where r.roomStatus = 'Busy' AND extract(day from CURRENT_DATE) BETWEEN extract(day from res.dateIn) and extract(day from res.dateOut) ";
            MySqlCommand command = new MySqlCommand(insertQuery, connection.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@floor", MySqlDbType.Int32).Value = floor;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            connection.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseCon();
                return true;
            }
            else
            {
                connection.CloseCon();
                return false;
            }
        }
    }
}
