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
            MySqlCommand command = new MySqlCommand(selectQuerry,connect.GetConnection());
            command.Parameters.Add("@type",MySqlDbType.VarChar).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
