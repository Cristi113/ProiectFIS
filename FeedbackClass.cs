using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    internal class FeedbackClass
    {
        DataBaseConnection connection = new DataBaseConnection();

        public bool addFeedback(int hotelID, string staffFriendliness, string roomCleanliness, string rating)
        {
            string insertQuery = "INSERT INTO `feedback` (`hotelID`,`staffFriendliness`,`roomCleanliness`,`rating`) VALUES (@hotelID,@staffFriendliness,@roomCleanliness,@rating)";
            MySqlCommand command = new MySqlCommand(insertQuery, connection.GetConnection());
            command.Parameters.Add("@hotelID",MySqlDbType.Int32).Value = hotelID; 
            command.Parameters.Add("@staffFriendliness",MySqlDbType.VarChar).Value = staffFriendliness;
            command.Parameters.Add("@roomCleanliness", MySqlDbType.VarChar).Value = roomCleanliness;
            command.Parameters.Add("@rating", MySqlDbType.VarChar).Value = rating;

            connection.OpenCon();
            if(command.ExecuteNonQuery()==1)
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
