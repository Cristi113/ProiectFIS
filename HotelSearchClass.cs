using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
<<<<<<< Updated upstream
    
=======
>>>>>>> Stashed changes
    internal class HotelSearchClass
    {
        DataBaseConnection connection = new DataBaseConnection();

<<<<<<< Updated upstream
        public DataTable getHotel()
        {
            string selectQuerry = "SELECT hotelName FROM `hotel`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connection.GetConnection());
=======
        public DataTable getHotel(string hotelName = null)
        {
            string selectQuery;
            if (string.IsNullOrEmpty(hotelName))
            {
                selectQuery = "SELECT hotelName FROM `hotel`";
            }
            else
            {
                selectQuery = "SELECT hotelName FROM `hotel` WHERE `hotelName` = @hotelName";
            }

            MySqlCommand command = new MySqlCommand(selectQuery, connection.GetConnection());

            if (!string.IsNullOrEmpty(hotelName))
            {
                command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;
            }

>>>>>>> Stashed changes
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

<<<<<<< Updated upstream
            return table; 
        }
=======
            return table;
        }

>>>>>>> Stashed changes
        public Boolean selectHotel(string hotelName)
        {
            string selectQuery = "SELECT hotelName FROM `hotel` WHERE `hotelName` = @hotelName";
            MySqlCommand command = new MySqlCommand(selectQuery, connection.GetConnection());
            command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;
<<<<<<< Updated upstream
            
            connection.OpenCon();
            if(command.ExecuteNonQuery() == 1)
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
=======

            connection.OpenCon();
            MySqlDataReader reader = command.ExecuteReader();
            bool exists = reader.HasRows;
            connection.CloseCon();

            return exists;
        }
    }
}
>>>>>>> Stashed changes
