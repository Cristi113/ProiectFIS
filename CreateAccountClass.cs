using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class CreateAccountClass
    {
        DataBaseConnection connection = new DataBaseConnection();

        public bool insertGuest(string id, string fname, string lname, string phone, string city)
        {
            string insertQuerry = "INSERT INTO `guest`(`GuestID`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES(@id,@fname,@lname,@phone,@city)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connection.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

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
        public bool insertUser(string id, string username, string password)
        {
            string insertQuerry = "INSERT INTO `users`(`id`, `username`, `password`) VALUES(@id,@username,@password)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connection.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            

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
