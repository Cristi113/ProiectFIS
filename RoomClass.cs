using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    internal class RoomClass
    {
        DataBaseConnection connect = new DataBaseConnection();
        public DataTable getRoomType()
        {
            string selectQuerry = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool addRoom(string id, int floor, string phone, string status, string type)
        {
            string insertQuerry = "INSERT INTO `room`(`roomID`, `roomFloor`, `roomPhone`, `roomStatus`, `roomType`) VALUES(@id,@floor,@phone,@status,@type)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@floor", MySqlDbType.Int32).Value = floor;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public DataTable getRooms()
        {
            string selectQuerry = "SELECT * FROM `room`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool updateRoom(string id, int floor, string phone, string status, string type)
        {
            string updateQuerry = "UPDATE `room` SET `roomID`=@ID,`roomFloor`=@floor,`roomPhone`=@phone,`roomStatus`=@status,`roomType`=@type WHERE `roomID`=@ID";
            MySqlCommand command = new MySqlCommand(updateQuerry, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@floor", MySqlDbType.Int32).Value = floor;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
        public bool deleteRoom(string id)
        {
            string deleteQuerry = "DELETE FROM `room` WHERE `roomID` = @id";
            MySqlCommand command = new MySqlCommand(deleteQuerry, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }
    }
}
