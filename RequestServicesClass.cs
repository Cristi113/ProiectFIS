using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class RequestServicesClass
    {
        DataBaseConnection connection = new DataBaseConnection();
       public bool SaveGuestRequests(string roomService, string cleanService, string extraTowels, string extraBed) 
        { 
            string insertQuery ="INSERT INTO extraServices (roomService, cleanService, extraTowels, extraBed) VALUES (@roomService, @cleanService, @extraTowels, @extraBed)";
            MySqlCommand command = new MySqlCommand(insertQuery, connection.GetConnection());

            command.Parameters.Add("@roomService", MySqlDbType.VarChar).Value = roomService;
            command.Parameters.Add("@cleanService", MySqlDbType.VarChar).Value = cleanService;
            command.Parameters.Add("@extraTowels", MySqlDbType.VarChar).Value = extraTowels;
            command.Parameters.Add("@extraBed", MySqlDbType.VarChar).Value = extraBed;

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
