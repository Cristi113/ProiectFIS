using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    internal class ReservationClass
    {
        DataBaseConnection connect = new DataBaseConnection();

        public DataTable roomByType(string type)
        {
            string selectQuerry = "SELECT * FROM `room` WHERE `roomType` = @type AND `roomStatus` = 'Free'";
            MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string typeByRoomID(string rid)
        {
            string selectQuerry = "SELECT 'roomType' FROM `room` WHERE `roomID` = @rid";
            MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
            command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = rid;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }

        public DataTable getReserv()
        {
            string selectQuerry = "SELECT * FROM `reservation`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool setReservRoom(string rid, string sts)
        {
            string updateQuerry = "UPDATE 'room' SET 'RoomStatus'=@sts WHERE 'roomID' = @rid";
            MySqlCommand command = new MySqlCommand(updateQuerry, connect.GetConnection());

            command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = rid;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = sts;
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
        public bool addReservation(string guestID, string roomID, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "INSERT INTO `reservation`(`guestID`, `roomID`, `dateIn`, `dateOut`) VALUES (@gID,@rID,@Din,@Dout)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            command.Parameters.Add("@gID", MySqlDbType.VarChar).Value = guestID;
            command.Parameters.Add("@rID", MySqlDbType.VarChar).Value = roomID;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

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
        public bool deleteReservation(int id)
        {
            string deleteQuerry = "DELETE FROM `reservation` WHERE `reservationID` = @id";
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

        public bool updateReservation(int reserID, string guestID, string roomID, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "UPDATE `reservation` SET `guestID`=@gID,`roomID`=@rID,`dateIn`=@Din,`dateOut`=@Dout WHERE `reserID`=@rid";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = reserID;
            command.Parameters.Add("@gID", MySqlDbType.VarChar).Value = guestID;
            command.Parameters.Add("@rID", MySqlDbType.VarChar).Value = roomID;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

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
