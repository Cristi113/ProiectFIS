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
    }
}
