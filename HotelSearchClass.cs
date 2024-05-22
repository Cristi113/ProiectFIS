using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    internal class HotelSearchClass
    {
        DataBaseConnection connection = new DataBaseConnection();

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
        public string getHotelName(string hotelName)
        {
            string selectQuery = "SELECT hotelName FROM hotel WHERE hotelName = @hotelName";
            MySqlCommand command = new MySqlCommand(selectQuery, connection.GetConnection());
            command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;

            connection.OpenCon();
            MySqlDataReader reader = command.ExecuteReader();
            bool exists = reader.HasRows;
            connection.CloseCon();
            if (exists)
            {
                return hotelName;
            }
            else
            {
                return "";
            }
        }
        public DataTable getHotel2()
        {
            string selectQuerry = "SELECT * FROM `hotel`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connection.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable getHotelID()
        {
            string selectQuerry = "SELECT hotelID FROM `hotel`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connection.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public string typeByHotelName(string hotelName)
        {
            string selectQuerry = "SELECT 'hotelName' FROM `hotel` WHERE `hotelName` = @hotelName";
            MySqlCommand command = new MySqlCommand(selectQuerry, connection.GetConnection());
            command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }
    }
}