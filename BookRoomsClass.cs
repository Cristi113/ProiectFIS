using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    internal class BookRoomClass
    {
        DataBaseConnection connection = new DataBaseConnection();

        public bool addRoom(string id, int floor, string phone, string status, string type)
        {
            string insertQuerry = "INSERT INTO `room`(`roomID`, `roomFloor`, `roomPhone`, `roomStatus`, `roomType`) VALUES(@id,@floor,@phone,@status,@type)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connection.GetConnection());
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
        public DataTable getHotel(string hotelName = null)
        {
            string selectQuery;
            if (string.IsNullOrEmpty(hotelName))
            {
                selectQuery = "SELECT hotelName FROM hotel";
            }
            else
            {
                selectQuery = "SELECT hotelName FROM hotel WHERE hotelName = @hotelName";
            }

            MySqlCommand command = new MySqlCommand(selectQuery, connection.GetConnection());

            if (!string.IsNullOrEmpty(hotelName))
            {
                command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public Boolean selectHotel(string hotelName)
        {
            string selectQuery = "SELECT hotelName FROM hotel WHERE hotelName = @hotelName";
            MySqlCommand command = new MySqlCommand(selectQuery, connection.GetConnection());
            command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;

            connection.OpenCon();
            MySqlDataReader reader = command.ExecuteReader();
            bool exists = reader.HasRows;
            connection.CloseCon();

            return exists;
        }

    }
}
