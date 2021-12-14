using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWordService
{
    public class Connect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionstring;

        public Connect()
        {
          
            server = "localhost";
            database = "payment";
            uid = "root";
            password = "";

            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "SslMode=None;";

            connection = new MySqlConnection(connectionstring);
            
            connection.Open();
            
        }
    }
}