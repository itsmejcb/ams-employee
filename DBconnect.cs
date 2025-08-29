using System;
using System.Collections.Generic;
using System.Text;
//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace GenerateReport
{
    class DBconnect
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=employee;sslMode=none");
        //MySqlConnection connect = new MySqlConnection("Server=thesis-mysql-server.mysql.database.azure.com; UserID = aleck12123; Password=Thesisdatabase12123; Database=studentdb; SslMode=none");
        //Get Connection
        public MySqlConnection GetConnection
        {
            get
            {
                return connect;
            }
        }

        //Create a function to open connection
        public void openConnect()
        {

            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a function to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
