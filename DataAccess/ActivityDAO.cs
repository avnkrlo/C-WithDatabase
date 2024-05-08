using MySql.Data.MySqlClient;
using System.Collections;
using System.Data.SQLite;

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
                        recordLogCMD.Parameters.AddWithValue("@time_start", time_start);

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

        public void recordOut(string user_id, int activity_type, string time_start, string time_end, float time_elapsed, bool isOnline)
        {
            bool hasConnection = false;
            bool hasLocalConnection = false;

            using (var localConnection = GetLocalConnection())
            {
                try
                {
                    localConnection.Open();
                    hasLocalConnection = true;
                }
                catch (SQLiteException mysqle)
                {

                }

                if (hasLocalConnection)
                {
                    using (SQLiteCommand recordLogsCMD = new SQLiteCommand())
                    {
                        recordLogsCMD.Connection = localConnection;
                        recordLogsCMD.CommandText = "UPDATE emp_activities SET time_end = @time_end, time_elapsed = @time_elapsed WHERE user_id = @user_id AND activity_type = AND time_start = @time_start";
                        recordLogsCMD.Parameters.AddWithValue("@user_id", user_id);
                        recordLogsCMD.Parameters.AddWithValue("@activity_type", activity_type);
                        recordLogsCMD.Parameters.AddWithValue("@time_start", time_start);
                        recordLogsCMD.Parameters.AddWithValue("@time_end", time_end);
                        recordLogsCMD.Parameters.AddWithValue("@time_elapsed", time_elapsed);

                        var errors = recordLogsCMD.ExecuteNonQuery();

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
                    catch (MySqlException mysqle)
                    {
                        switch (mysqle.Number)
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
                            recordLogsCMD.CommandText = "UPDATE emp_activities SET time_end = @time_end, time_elapsed = @time_elapsed WHERE user_id = @user_id AND activity_type = @activity_type AND time_start = @time_start";
                            recordLogsCMD.Parameters.AddWithValue("@user_id", user_id);
                            recordLogsCMD.Parameters.AddWithValue("@activity_type", activity_type);
                            recordLogsCMD.Parameters.AddWithValue("@time_start", time_start);
                            recordLogsCMD.Parameters.AddWithValue("@time_end", time_end);
                            recordLogsCMD.Parameters.AddWithValue("@time_elapsed", time_elapsed);

                            var errors = recordLogsCMD.ExecuteNonQuery();

                            if (errors <= 0)
                            {

                            }

                            connection.Close();
                        }
                    }
                }
            }
        }

        public string createMinutes(string user_id, string shiftDate, bool isOnline)
        {
            string activity_id = "";
            bool hasConnection = false;
            bool hasLocalConnection = false;

            if (isOnline)
            {
                using (var connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        hasConnection = true;
                    }
                    catch (MySqlException mysqle)
                    {
                        switch (mysqle.Number)
                        {
                            case 0:
                                break;

                            case 1045:
                                break;
                        }
                    }

                    if (hasConnection)
                    {
                        using (MySqlCommand recordLogCMD = new MySqlCommand())
                        {
                            recordLogCMD.Connection = connection;
                            recordLogCMD.CommandText = "INSERTED INTO emp_activities_summary (user_id, date) VALUES (@user_id, @shiftdate)";
                            recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                            recordLogCMD.Parameters.AddWithValue("@shiftdate", shiftDate);

                            var errors = recordLogCMD.ExecuteNonQuery();

                            if (errors <= 0)
                            {
                                Console.WriteLine("Error inserting data!");
                                connection.Close();
                                return activity_id;
                            }
                        }

                        using (MySqlCommand loginCMD = new MySqlCommand())
                        {
                            loginCMD.Connection = connection;
                            loginCMD.CommandText = "SELECT * FROM emp_activities_summary WHERE user_id = @user_id and date = @shiftdate ORDER BY id DESC LIMIT 1";
                            loginCMD.Parameters.AddWithValue("@user_id", user_id);
                            loginCMD.Parameters.AddWithValue("@shiftdate", shiftDate);

                            MySqlDataReader dataReader = loginCMD.ExecuteReader();

                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    activity_id = dataReader["id"].ToString();
                                }
                            }

                            dataReader.Close();

                            connection.Close();
                        }
                    }
                }
            }

            using (var localConnection = GetLocalConnection())
            {
                try
                {
                    localConnection.Open();
                    hasLocalConnection = true;
                }
                catch (SQLiteException sqlex)
                {

                }

                if (hasLocalConnection)
                {
                    using (SQLiteCommand recordLogCMD = new SQLiteCommand())
                    {
                        recordLogCMD.Connection = localConnection;
                        recordLogCMD.CommandText = "INSERT INTO emp_activities_summary (id, user_id, date) VALUES (@id, @user_id, @shiftdate)";
                        recordLogCMD.Parameters.AddWithValue("@id", activity_id);
                        recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                        recordLogCMD.Parameters.AddWithValue("@shiftdate", shiftDate);

                        var errors = recordLogCMD.ExecuteNonQuery();

                        if (errors < 0)
                        {
                            Console.WriteLine("Error inserting data!");
                        }
                    }

                    localConnection.Close();
                }
            }

            return activity_id;
        }

        public void recordMinutes(string id, string user_id, string shiftDate, int activity_type, float minutes, bool isOnline)
        {
            bool hasConnection = false;
            bool hasLocalConnection = false;

            using (var localConnection = GetLocalConnection())
            {
                try
                {
                    localConnection.Open();
                    hasLocalConnection = true;
                }
                catch (SQLiteException sqlex)
                {

                }

                if (hasLocalConnection)
                {
                    using (SQLiteCommand recordLogCMD = new SQLiteCommand())
                    {
                        recordLogCMD.Connection = localConnection;

                        switch (activity_type)
                        {
                            case 1:
                                recordLogCMD.CommandText = "UPDATE emp_activities_summary SET active = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                break;
                            case 2:
                                recordLogCMD.CommandText = "UPDATE emp_activities_summary SET idle = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                break;
                            case 3:
                                recordLogCMD.CommandText = "UPDATE emp_activities_summary SET unauthorized = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                break;
                            case 4:
                                recordLogCMD.CommandText = "UPDATE emp_activities_summary SET break = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                break;
                            default:
                                localConnection.Close();
                                return;
                                break;
                        }

                        recordLogCMD.Parameters.AddWithValue("@minutes", minutes);
                        recordLogCMD.Parameters.AddWithValue("@id", id);
                        recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                        recordLogCMD.Parameters.AddWithValue("@shiftDate", shiftDate);

                        var errors = recordLogCMD.ExecuteNonQuery();

                        if (errors < 0)

                            Console.WriteLine("Error inserting data!");

                        localConnection.Close();
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
                            return;
                        }

                        if (hasConnection)
                        {
                            using (MySqlCommand recordLogCMD = new MySqlCommand())
                            {
                                recordLogCMD.Connection = connection;

                                switch (activity_type)
                                {
                                    case 1:
                                        recordLogCMD.CommandText = "UPDATE emp_activities_summary SET active = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                        break;
                                    case 2:
                                        recordLogCMD.CommandText = "UPDATE emp_activities_summary SET idle = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                        break;
                                    case 3:
                                        recordLogCMD.CommandText = "UPDATE emp_activities_summary SET unauthorized = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                        break;
                                    case 4:
                                        recordLogCMD.CommandText = "UPDATE emp_activities_summary SET break = @minutes WHERE id = @id AND user_id = @user_id AND date = @shiftDate";
                                        break;
                                    default:
                                        connection.Close();
                                        return;
                                        break;
                                }

                                recordLogCMD.Parameters.AddWithValue("@minutes", minutes);
                                recordLogCMD.Parameters.AddWithValue("id", id);
                                recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                                recordLogCMD.Parameters.AddWithValue("@shiftDate", shiftDate);

                                var errors = recordLogCMD.ExecuteNonQuery();

                                if (errors < 0)
                                    Console.WriteLine("Error inserting data!");

                                connection.Close();
                            }
                        }
                    }
                }
            }
        }

        public ArrayList getLocalActivities()
        {
            bool hasLocalConnection = false;

            ArrayList arrLocal = new ArrayList();

            using (var localConnection = GetLocalConnection())
            {
                try
                {
                    localConnection.Open();
                    hasLocalConnection = true;
                }
                catch (SQLiteException sqle)
                {

                }

                if (hasLocalConnection)
                {
                    using (SQLiteCommand recordLogsCMD = new SQLiteCommand())
                    {
                        recordLogsCMD.Connection = localConnection;
                        recordLogsCMD.CommandText = "SELECT * FROM emp_activities;";

                        SQLiteDataReader dataReader = recordLogsCMD.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                List<string> arrData = new List<string>();
                                arrData.Add(dataReader["id"].ToString());
                                arrData.Add(dataReader["user_id"].ToString());
                                arrData.Add(dataReader["activity_type"].ToString());

                                DateTime tStart = DateTime.Parse(dataReader["time_start"].ToString());
                                arrData.Add(tStart.ToString("yyyy-MM-dd HH:mm:ss"));

                                DateTime tEnd = DateTime.Parse(dataReader["time_end"].ToString());
                                arrData.Add(tEnd.ToString("yyyy-MM-dd HH:mm:ss"));

                                float tElapsed = float.Parse(dataReader["time_elapsed"].ToString());
                                arrData.Add(tElapsed.ToString("0.00"));

                                arrLocal.Add(arrData);

                                arrData = null;
                            }
                        }

                        localConnection.Close();
                    }
                }
            }

            return arrLocal;
        }

        public ArrayList getServerActivities(string user_id, string startDate, string endDate)
        {
            bool result = false;
            bool hasConnection = false;

            ArrayList arrServer = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    hasConnection = true;
                }
                catch (MySqlException mysqle)
                {

                }

                if (hasConnection)
                {
                    using (MySqlCommand recordLogCMD = new MySqlCommand())
                    {
                        recordLogCMD.Connection = connection;
                        recordLogCMD.CommandText = "SELECT * FROM emp_activities " +
                            "WHERE user_id = @user_id AND time_start >= @startdate AND time_start <= @enddate;";
                        recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                        recordLogCMD.Parameters.AddWithValue("@startdate", startDate);
                        recordLogCMD.Parameters.AddWithValue("@enddate", endDate);

                        MySqlDataReader dataReader = recordLogCMD.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                List<string> arrData = new List<string>();
                                arrData.Add(dataReader["id"].ToString());
                                arrData.Add(dataReader["user_id"].ToString());
                                arrData.Add(dataReader["activity_type"].ToString());

                                DateTime time_start = DateTime.Parse(dataReader["time_start"].ToString());
                                arrData.Add(time_start.ToString("yyyy-MM-dd HH:mm:ss"));

                                DateTime time_end = DateTime.Parse(dataReader["time_end"].ToString());
                                arrData.Add(time_end.ToString("yyyy-MM-dd HH:mm:ss"));

                                float time_elapsed = float.Parse(dataReader["time_elapsed"].ToString());
                                arrData.Add(time_elapsed.ToString("0.00"));

                                arrServer.Add(arrData);

                                arrData = null;
                            }
                        }

                        connection.Close();
                    }
                }
            }

            return arrServer;
        }

        public ArrayList getServerActivitiesSummary(string user_id, string startdate, string enddate)
        {
            bool result = false;
            bool hasConnection = false;

            ArrayList arrServer = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    hasConnection = true;
                }
                catch (MySqlException mysqle)
                {

                }

                if (hasConnection)
                {
                    using (MySqlCommand recordLogCMD = new MySqlCommand())
                    {
                        recordLogCMD.Connection = connection;
                        recordLogCMD.CommandText = "SELECT * FROM emp_activities_summary " +
                            "WHERE user_id = @user_id AND date >= @startdate AND date <= @enddate;";
                        recordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                        recordLogCMD.Parameters.AddWithValue("@startdate", startdate);
                        recordLogCMD.Parameters.AddWithValue("@enddate", enddate);

                        MySqlDataReader dataReader = recordLogCMD.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                List<string> arrData = new List<string>();
                                arrData.Add(dataReader["id"].ToString());
                                arrData.Add(dataReader["user_id"].ToString());

                                DateTime recDate = DateTime.Parse(dataReader["date"].ToString());
                                arrData.Add(recDate.ToString("yyyy-MM-dd"));

                                float recIdle = float.Parse(dataReader["idle"].ToString());
                                arrData.Add(recIdle.ToString("0.00"));

                                float recActive = float.Parse(dataReader["active"].ToString());
                                arrData.Add(recActive.ToString("0.00"));

                                float recUnauthorized = float.Parse(dataReader["unauthorized"].ToString());
                                arrData.Add(recUnauthorized.ToString("0.00"));

                                float recBreak = float.Parse(dataReader["break"].ToString());
                                arrData.Add(recBreak.ToString("0.00"));

                                arrServer.Add(arrData);

                                arrData = null;
                            }
                        }

                        connection.Close();
                    }
                }
            }

            return arrServer;
        }

        public ArrayList getLocalActivitiesSummary()
        {
            bool hasLocalConnection = false;

            ArrayList arrLocal = new ArrayList();

            using (var localConnection = GetLocalConnection())
            {
                try
                {
                    localConnection.Open();
                    hasLocalConnection = true;
                }
                catch (SQLiteException sqle)
                {

                }

                if (hasLocalConnection)
                {
                    using (SQLiteCommand recordLogsCMD = new SQLiteCommand())
                    {
                        recordLogsCMD.Connection = localConnection;
                        recordLogsCMD.CommandText = "SELECT * FROM emp_activities_summary;";
                        SQLiteDataReader dataReader = recordLogsCMD.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                List<string> arrData = new List<string>();
                                arrData.Add(dataReader["id"].ToString());
                                arrData.Add(dataReader["user_id"].ToString());

                                DateTime recDate = DateTime.Parse(dataReader["date"].ToString());
                                arrData.Add(recDate.ToString("yyyy-MM-dd"));

                                float recIdle = float.Parse(dataReader["idle"].ToString());
                                arrData.Add(recIdle.ToString("0.00"));

                                float active = float.Parse(dataReader["active"].ToString());
                                arrData.Add(active.ToString("0.00"));

                                float recUnauthorized = float.Parse(dataReader["unauthorized"].ToString());
                                arrData.Add(recUnauthorized.ToString("0.00"));

                                float recBreak = float.Parse(dataReader["break"].ToString());
                                arrData.Add(recBreak.ToString("0.00"));

                                arrLocal.Add(arrData);
                                arrData = null;
                            }
                        }

                        localConnection.Close();
                    }
                }
            }

            return arrLocal;
        }

        public bool empActivitiesSummarySync(ArrayList ar_local)
        {
            bool result = false;
            bool recordFound = false;
            bool hasConnection = false;
            using (var connection = GetConnection())
            {
                try
                    {
                        connection.Open();
                        hasConnection = true;
                    }
                catch (MySqlException mysqle)
                    {
                    switch (mysqle.Number)
                    {
                        case 0:
                            break;

                        case 1045:
                            break;
                    }

                    return result;
                }

                if (hasConnection)
                    {
                    try
                    {
                        foreach (List<string> activeRec in ar_local)
                        {
                            string id = activeRec[0];
                            string user_id = activeRec[1];
                            string record_date = activeRec[2];
                            string idle = activeRec[3];
                            string active = activeRec[4];
                            string unauthorized = activeRec[5];
                            string record_break = activeRec[6];

                        using (MySqlCommand checkRecordLogCMD = new MySqlCommand())
                        {
                            checkRecordLogCMD.Connection = connection;
                            checkRecordLogCMD.CommandText = "SELECT * FROM emp_activities_summary WHERE(id = @id, user_id = @user_id, DATE= @date)";
                            checkRecordLogCMD.Parameters.AddWithValue("@id", id);
                            checkRecordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                            checkRecordLogCMD.Parameters.AddWithValue("@date", record_date);

                            MySqlDataReader dataReader = checkRecordLogCMD.ExecuteReader();

                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    recordFound = true;
                                }
                            }

                            dataReader.Close();
                        }

                        if (recordFound)
                        {
                            using (MySqlCommand updateRecordLogCMD = new MySqlCommand())
                            {
                                updateRecordLogCMD.Connection = connection;
                                updateRecordLogCMD.CommandText = "UPDATE emp_activities_summary SET idle = @idle, active = @active, unauthorized = @unauthorized, break = @break WHERE id = @id AND user_id = @user_id AND date = @date";
                                updateRecordLogCMD.Parameters.AddWithValue("@id", id);
                                updateRecordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                                updateRecordLogCMD.Parameters.AddWithValue("@date", record_date);
                                updateRecordLogCMD.Parameters.AddWithValue("@idle", idle);
                                updateRecordLogCMD.Parameters.AddWithValue("@active", active);
                                updateRecordLogCMD.Parameters.AddWithValue("@unauthorized", unauthorized);
                                updateRecordLogCMD.Parameters.AddWithValue("break", record_break);

                                var errors = updateRecordLogCMD.ExecuteNonQuery();

                                if (errors <= 0)
                                {
                                    Console.WriteLine("Error updating data!");
                                }
                                else
                                {
                                    result = true;
                                }
                                }
                            }

                            else
                            {
                                using (MySqlCommand insertRecordLogCMD = new MySqlCommand())
                                {
                                    insertRecordLogCMD.Connection = connection;
                                    insertRecordLogCMD.CommandText = "INSERT INTO emp_activities_summary (user_id, record_date, idle, active, unauthorized, break) " +
                                        "VALUES (@user_id, @record_date, @idle, @active, @unauthorized, @break)";
                                    insertRecordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                                    insertRecordLogCMD.Parameters.AddWithValue("@date", record_date);
                                    insertRecordLogCMD.Parameters.AddWithValue("@idle", idle);
                                    insertRecordLogCMD.Parameters.AddWithValue("@active", active);
                                    insertRecordLogCMD.Parameters.AddWithValue("@unauthorized", unauthorized);
                                    insertRecordLogCMD.Parameters.AddWithValue("@break", record_break);

                                    var errors = insertRecordLogCMD.ExecuteNonQuery();

                                    if (errors <= 0)
                                    {

                                    }
                                    else
                                    {
                                        result = true;
                                    }
                                }
                            }
                        }

                            connection.Close();
                        }

                    catch (MySqlException mysqle)
                    {
                        switch (mysqle.Number)
                        {
                            case 0:
                                break;

                            case 1045:
                                break;
                        }

                        return result;
                    }
                }
            }

            return result;
        }

            public bool empActivitiesSync(ArrayList arr_Local)
            {
                bool result = false;
                bool recordFound = false;
                bool hasConnection = false;
                string id = "";

                using (var connection = GetConnection())
                {
                    try
                    {
                        connection.Open();
                        hasConnection = true;
                    }
                    catch (MySqlException msqle)
                    {
                        switch (msqle.Number)
                        {
                            case 0:
                                break;

                            case 1045:
                                break;
                        }
                        return result;
                    }

                    if (hasConnection)
                    {
                        try
                        {
                            foreach (List<string> activeRec in arr_Local)
                            {
                                string user_id = activeRec[1];
                                string activity_type = activeRec[2];
                                string time_start = activeRec[3];
                                string time_end = activeRec[4];
                                string time_elapsed = activeRec[5];

                                using (MySqlCommand checkRecordLogCMD = new MySqlCommand())
                                {
                                    checkRecordLogCMD.Connection = connection;
                                    checkRecordLogCMD.CommandText = "SELECT * FROM emp_activities WHERE (user_id = @user_id, activity_type = @activity_type, time_start = @time_start)";
                                    checkRecordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                                    checkRecordLogCMD.Parameters.AddWithValue("@activity_type", activity_type);
                                    checkRecordLogCMD.Parameters.AddWithValue("@time_start", time_start);

                                    MySqlDataReader dataReader = checkRecordLogCMD.ExecuteReader();

                                    if (dataReader.HasRows)
                                    {
                                        while (dataReader.Read())
                                        {
                                            id = dataReader["id"].ToString();
                                            recordFound = true;
                                        }
                                    }

                                    dataReader.Close();
                                }

                                if (recordFound)
                                {
                                    using (MySqlCommand updateRecordLogCMD = new MySqlCommand())
                                    {
                                        updateRecordLogCMD.Connection = connection;
                                        updateRecordLogCMD.CommandText = "UPDATE emp_activities SET time_end = @time_end, time_elapsed = @time_elapsed WHERE id = @id AND user_id = @user_id AND activity_type = @activity_type AND time_start = @time_start";
                                        updateRecordLogCMD.Parameters.AddWithValue("@id", id);
                                        updateRecordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                                        updateRecordLogCMD.Parameters.AddWithValue("@activity_type", activity_type);
                                        updateRecordLogCMD.Parameters.AddWithValue("@time_start", time_start);
                                        updateRecordLogCMD.Parameters.AddWithValue("@time_end", time_end);
                                        updateRecordLogCMD.Parameters.AddWithValue("@time_elapsed", time_elapsed);

                                        var errors = updateRecordLogCMD.ExecuteNonQuery();

                                        if (errors <= 0)
                                        {
                                            Console.WriteLine("Error updating data!");
                                        }
                                        else
                                        {
                                            result = true;
                                        }
                                    }
                                }

                                else
                                {
                                    using (MySqlCommand insertRecordLogCMD = new MySqlCommand())
                                    {
                                        insertRecordLogCMD.Connection = connection;
                                        insertRecordLogCMD.CommandText = "INSERT INTO emp_activities (user_id, activity_type, time_start, time_end, time_elapsed) " +
                                            "VALUES (@user_id, @activity_type, @time_start, @time_end, @time_elapsed);";
                                        insertRecordLogCMD.Parameters.AddWithValue("@user_id", user_id);
                                        insertRecordLogCMD.Parameters.AddWithValue("@activity_type", activity_type);
                                        insertRecordLogCMD.Parameters.AddWithValue("@time_start", time_start);
                                        insertRecordLogCMD.Parameters.AddWithValue("@time_end", time_end);
                                        insertRecordLogCMD.Parameters.AddWithValue("@time_elapsed", time_elapsed);

                                        var errors = insertRecordLogCMD.ExecuteNonQuery();

                                        if (errors < 0)
                                        {

                                        }
                                        else
                                        {
                                            result = true;
                                        }
                                    }
                                }
                            }

                            connection.Close();
                        }

                        catch (MySqlException mysqle)
                        {
                            switch (mysqle.Number)
                            {
                                case 0:
                                    break;

                                case 1045:
                                    break;
                            }

                            return result;
                        }
                    }
                }

                return result;
            }

            public void resetLocalEmpActivities()
            {
                bool hasLocalConnection = false;

                using (var localConnection = GetLocalConnection())
                {
                    try
                    {
                        localConnection.Open();
                        hasLocalConnection = true;
                    }
                    catch (SQLiteException sqlex)
                    {

                    }

                    if (hasLocalConnection)
                    {
                        using (SQLiteCommand recordLogCMD = new SQLiteCommand())
                        {
                            recordLogCMD.Connection = localConnection;
                            recordLogCMD.CommandText = "DROP TABLE IF EXISTS emp_activities;";
                            recordLogCMD.CommandText += "CREATE TABLE 'emp_activities'(" +
                                "'id' INTEGER NOT NULL," +
                                "'user_id' INTEGER," +
                                "'activity_type' INTEGER," +
                                "'time_start' TEXT," +
                                "'time_end' TEXT," +
                                "'time_elapsed' NUMERIC," +
                                "PRIMARY KEY('id' AUTOINCREMENT)" +
                                ");";

                            var errors = recordLogCMD.ExecuteNonQuery();

                            if (errors <= 0)
                            {

                            }

                            localConnection.Close();
                        }
                    }
                }
            }

            public void resetLocalEmpActivitiesSummary()
            {
                bool hasLocalConnection = false;

                using (var localConnection = GetLocalConnection())
                {
                    try
                    {
                        localConnection.Open();
                        hasLocalConnection = true;
                    }
                    catch (SQLiteException mysqle)
                    {

                    }

                    if (hasLocalConnection)
                    {
                        using (SQLiteCommand recordLogCMD = new SQLiteCommand())
                        {
                            recordLogCMD.Connection = localConnection;
                            recordLogCMD.CommandText = "DROP TABLE IF EXISTS emp_activities_summary";
                            recordLogCMD.CommandText += "CREATE TABLE 'emp_activities_summary'(" +
                                "'id' INTEGER, " +
                                "'userid' INTEGER, " +
                                "'date' TEXT, " +
                                "'idle' NUMERIC, " +
                                "'active' NUMERIC, " +
                                "'unauthorized' NUMERIC, " +
                                "'break' NUMERIC " +
                                ");";

                            var errors = recordLogCMD.ExecuteNonQuery();

                            if (errors < 0)
                            {

                            }

                            localConnection.Close();
                        }
                    }
                }
            }

        public bool syncEmpActivities(string values)
        {
            bool result = false;
            bool hasConnection = false;

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
                    using (MySqlCommand recordLogCMD = new MySqlCommand())
                    {
                        recordLogCMD.Connection = connection;
                        recordLogCMD.CommandText = "INSERT INTO emp_activities (user_id, activity_type, time_start, time_end, time_elapsed)";
                        recordLogCMD.CommandText += values;

                        var errors = recordLogCMD.ExecuteNonQuery();

                        if (errors < 0)
                        {
                            Console.WriteLine("Error inserting data!");
                        }
                        else
                        {
                            result = true;
                        }

                        connection.Close();
                    }
                }
            }

            return result;
        }

        public bool syncEmpActivitiesSummary(string values)
        {
            bool result = false;
            bool hasConnection = false;

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
                    using (MySqlCommand recordLogCMD = new MySqlCommand())
                    {
                        recordLogCMD.Connection = connection;
                        recordLogCMD.CommandText = "INSERT INTO emp_activities_summary (user_id, date, idle, active, unauthorized, break)";
                        recordLogCMD.CommandText += values;

                        var errors = recordLogCMD.ExecuteNonQuery();

                        if ( errors < 0)
                        {
                            Console.WriteLine("Error inserting data!");
                        }
                        else
                        {
                            result = true;
                        }

                        connection.Close();
                    }
                }
            }
        }
    }
}

