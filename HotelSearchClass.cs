﻿using System;
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

        public DataTable getHotel()
        {
            string selectQuerry = "SELECT hotelName FROM `hotel`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connection.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table; 
        }
        public Boolean selectHotel(string hotelName)
        {
            string selectQuery = "SELECT hotelName FROM `hotel` WHERE `hotelName` = @hotelName";
            MySqlCommand command = new MySqlCommand(selectQuery, connection.GetConnection());
            command.Parameters.Add("@hotelName", MySqlDbType.VarChar).Value = hotelName;
            
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
