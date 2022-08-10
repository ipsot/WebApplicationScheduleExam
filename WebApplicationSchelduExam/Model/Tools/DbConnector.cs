using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace WebApplicationSchelduExam.Model.Entities.Tools
{
    public class DbConnector
    {
        private MySqlCommand mySqlCommand;
        private MySqlConnection mySqlConnection;
        private static DbConnector instance = null;
        private DbConnector()
        {
            string connectionString = "Server=127.0.0.1;User=root;Password=1234;Port=3306;Database=exam;";
            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;
        }
        ~DbConnector()
        {
            mySqlConnection.Close();
        }
        public static DbConnector GetInstance()
        {
            if (instance==null)
            {
                instance = new DbConnector();
            }
            return instance;
        }
        public MySqlCommand GetMySqlCommand()
        {
            return mySqlCommand;
        }
    }
}