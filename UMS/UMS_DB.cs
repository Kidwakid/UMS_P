using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UMS
{
    internal class UMS_DB
    {
         // The connection
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Ums_db");

        // Function to get the connection

        public MySqlConnection getConnection
        {
            get
            {
                return conn;    
            }
        }

        // Function to open connection

        public void openConnection()
        {
          if (conn.State == ConnectionState.Closed) 
            {
                conn.Open();
            }
        }

        // Function to close connection
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
