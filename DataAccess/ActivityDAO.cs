using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ActivityDAO : DatabaseConnection
    {
        public void recordIn(string user_id, int activity_type, string time_start, bool isOnline)
        {
            bool hasConnection = false;
            bool hasLocalConnection = false;

            using (var localConnection = GetLocalConnection())
            {
                try
                {
                    localConnection.Open();

                    hasConnection = true;
                }
                catch (SQLiteException)
                {

                }

                if (hasLocalConnection)
                {
                    using (SQLiteCommand recordLogCMD = new SQLiteCommand())
                    {
                        recordLogCMD.Connection = localConnection;
                        recordLogCMD.CommandText = "INSERT INTO emp_activities(user_id, activity_type, time_start) VALUES (@user_id, @activity_type, @time_start)";
                        recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                        recordLogCMD.Parameters.AddWithValue("@activity_type", activity_type);
                        recordLogCMD.Parameters.AddWithValue ("@time_start", time_start);

                        var errors = recordLogCMD.ExecuteNonQuery();

                        if (errors <= 0)
                        {
                            Console.WriteLine("Error inserting data!");
                        }

                        localConnection.Close();
                    }
                }
            }

            if (isOnline)
            {
                using (var connection = GetConnection())
                {
                    try
                    {
                        connection.Open();

                        hasConnection = true;
                    }
                    catch (MySqlException mysqlex)
                    {

                        switch (mysqlex.Number)
                        {
                            case 0:
                                break;

                            case 1045:
                                break;
                        }
                    }

                    if (hasConnection)
                    {
                        using (MySqlCommand recordLogsCMD = new MySqlCommand())
                        {
                            recordLogsCMD.Connection = connection;
                            recordLogsCMD.CommandText = "INSERT INTO emp_activities(user_id, activity_type, time_start) VALUES(@user_id, @activity_type, @time_start)";
                            recordLogsCMD.Parameters.AddWithValue("@user_id", user_id);
                            recordLogsCMD.Parameters.AddWithValue("@activity_type", activity_type);
                            recordLogsCMD.Parameters.AddWithValue("@time_start", time_start);

                            var errors = recordLogsCMD.ExecuteNonQuery();

                            if (errors <= 0)
                            {
                                Console.WriteLine("Error inserting data!");
                            }

                            connection.Close();
                        }
                    }
                }
            }
        }


    }
}
