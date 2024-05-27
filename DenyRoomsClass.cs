using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class DenyRoomsClass
    {
        DataBaseConnection connection = new DataBaseConnection();

        public bool deleteReservation(int id)
        {
            string deleteQuerry = "DELETE FROM `reservation` WHERE `reservationID` = @id";
            MySqlCommand command = new MySqlCommand(deleteQuerry, connection.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

        public DataTable getReservation()
        {
            string selectQuerry = "SELECT * FROM `reservation`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connection.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
