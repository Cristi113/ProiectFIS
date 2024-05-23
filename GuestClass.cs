using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal class GuestClass
    {
        DataBaseConnection connect = new DataBaseConnection();
        public bool insertGuest(string id, string fname, string lname, string phone, string city)
        {
            string insertQuerry = "INSERT INTO `guest`(`guestID`, `GuestFirstName`, `GuestLastName`, `GuestPhone`, `GuestCity`) VALUES(@id,@fname,@lname,@phone,@city)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

            connect.OpenCon();
            if(command.ExecuteNonQuery() == 1)
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
        public DataTable getGuest()
        {
            string selectQuerry = "SELECT * FROM `guest`";
            MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool guestEdit(string id, string fname, string lname, string phone, string city)
        {
            string editQuerry = "UPDATE `guest` SET `GuestFirstName`=@fname,`GuestLastName`=@lname,`GuestPhone`=@phone,`GuestCity`=@city WHERE `guestID`=@id";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

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

        public bool deleteGuest(string id)
        {
            string deleteQuerry = "DELETE FROM `guest` WHERE `guestID` = @id";
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