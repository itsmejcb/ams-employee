using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace GenerateReport
{
    class UserClass
    {
        DBconnect connect = new DBconnect();
        //create a function to get users list
        public DataTable getUsers(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Funtion to edit user data
        public bool updateUser(int userId, string uname, string pass)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET `Username`=@uname,`Password`=@pass WHERE `User_ID`=@id", connect.GetConnection);

            //command.Parameters.Add("@id", MySqlDbType.Int32).Value = std_id;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = userId;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        //create a function to delete user
        public bool deleteUser(int Id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE `User_ID`=@Id", connect.GetConnection);

            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = Id;
            connect.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
