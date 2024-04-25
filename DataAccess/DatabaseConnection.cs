using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public abstract class DatabaseConnection
    {

        private string connectionString;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        public DatabaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "192.168.98.102";
            port = "3306";
            database = "user_info.db";
            uid = "root";
            password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }

        private void RemoteServerConnection()
        {
            server = "192.168.98.102";
            port = "3306";
            database = "user_info.db";
            uid = "root";
            password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }

        private void LocalServer()
        {
            if (!File.Exists("./user_info.db"))
            {
                SQLiteConnection.CreateFile("user_info.db");

                using(var localDatabaseConnection = new SQLiteConnection("Data Source=user_info.db"))
                {
                    try
                    {
                        localDatabaseConnection.Open();

                        string create_mst_logs_tablequery = @"";
                    }
                    catch(SQLiteException sqle)
                    {
                        Console.WriteLine(sqle.Message);
                    }
                }
            }
        }

        protected SQLiteConnection GetLocalConnection()
        {
            return new SQLiteConnection("Data Source=user_info.db");
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
