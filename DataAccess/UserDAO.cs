using Common.Cache;
using MySql.Data.MySqlClient;
using System.Collections;

namespace DataAccess
{
    public class UserDAO : DatabaseConnection
    {

        public bool checkConnection()
        {
            bool result;

            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    result = true;
                }
                catch (MySqlException mysqle)
                {
                    result = false;
                }

                if (result)
                {
                    conn.Close();
                }
            }

            return result;
        }

        public bool login(string asset_number, string password)
        {

            bool result = false;

            using (var conn = GetConnection())
            {

                try
                {
                    conn.Open();
                }
                catch (MySqlException mysqle)
                {
                    Console.WriteLine(mysqle.Number + " " + mysqle.Message);
                    switch (mysqle.Number)
                    {
                         case 0:
                            break;

                        case 1045:
                            break;
                    }
                    return result;
                }

                using (MySqlCommand loginCMD = new MySqlCommand())
                {
                    loginCMD.Connection = conn;
                    loginCMD.CommandText = "SELECT emp_info.id, asset_id, emp_assets.asset_number AS asset_number, department_id, emp_departments.name ASCII department_name, role_id, first_name, last_name, middle_name, password FROM emploteee_info" +
                            "INNER JOIN emp_assets ON emp_users.asset_id = emp.assets.id " +
                            "INNER JOIN emp_departments ON emp_users.department_id = emp_departments.id " +
                            "WHERE emp_assets.asset_number = @asset_number and password = @password;";
                    loginCMD.Parameters.AddWithValue("@asset_number", asset_number);
                    loginCMD.Parameters.AddWithValue("Password", password);

                    MySqlDataReader reader = loginCMD.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLogin.user_id = reader["id"].ToString();
                            UserLogin.asset_id = reader["asset_id"].ToString();
                            UserLogin.asset_number = reader["asset_number"].ToString();
                            UserLogin.department_id = reader["department_id"].ToString();
                            UserLogin.department = reader["department"].ToString();
                            UserLogin.role = reader["role_id"].ToString();
                            UserLogin.first_name = reader["first_name"].ToString();
                            UserLogin.middle_name = reader["middle_name"].ToString();
                            UserLogin.last_name = reader["last_name"].ToString();
                        }

                        result = true;
                    }

                    else
                    {
                        result = false;
                    }

                    reader.Close();
                }

                using (MySqlCommand getRoleCMD = new MySqlCommand())
                {
                    getRoleCMD.Connection = conn;
                    getRoleCMD.CommandText = "SELECT * FROM emp_roles WHERE id = @role_id;";
                    getRoleCMD.Parameters.AddWithValue("@role_id", UserLogin.role);

                    MySqlDataReader reader = getRoleCMD.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLogin.timesheet_report = reader["timesheet_reports"].ToString();
                            UserLogin.activity_report = reader["activity_reports"].ToString();
                            UserLogin.override_report = reader["override_reports"].ToString();
                            UserLogin.override_authorize = reader["override_authorize"].ToString();
                            UserLogin.Assets = reader["assets"].ToString();
                            UserLogin.Departments = reader["departments"].ToString();
                            UserLogin.Roles = reader["roles"].ToString();
                            UserLogin.Users = reader["users"].ToString();
                            UserLogin.Sites = reader["sites"].ToString();
                            UserLogin.site_permissions = reader["site_permissions"].ToString();
                        }

                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                    reader.Close();
                }

                conn.Close();
            }

            return result;
        }

        public bool changePassword(String password, string newPassword)
        {
            bool result = false;
            bool userFound = false;

            using(var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (MySqlException mysqle)
                {
                    switch(mysqle.Number)
                    {
                        case 0:
                            break;

                        case 1045:
                            break;
                    }

                }

                using (MySqlCommand loginCMD = new MySqlCommand())
                {
                    loginCMD.Connection = conn;
                    loginCMD.CommandText = "SELECT emp_users.id, asset_id, emp_assets.asset_number, department_id, role_id, first_name, last_name, middle_name, password FROM emp_users " +
                        "INNER JOIN emp_assets ON emp_users.asset_id = emp_assets.id " +
                        "WHERE emp_assets.asset_number = @asset_number and password = @password;";
                    loginCMD.Parameters.AddWithValue("@asset_number", UserLogin.asset_number);
                    loginCMD.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = loginCMD.ExecuteReader();

                    if(reader.HasRows)
                    {
                        userFound = true;
                    }

                    reader.Close();
                }

                if (userFound)
                {
                    using (MySqlCommand recordLogCMD = new MySqlCommand())
                    {
                        recordLogCMD.Connection = conn;
                        recordLogCMD.CommandText = "UPDATE emp_users SET password = @password WHERE id = @user_id AND asset_id = @asset_id";
                        recordLogCMD.Parameters.AddWithValue("@user_id", UserLogin.user_id);
                        recordLogCMD.Parameters.AddWithValue("@asset_id", UserLogin.asset_id);
                        recordLogCMD.Parameters.AddWithValue("@password", newPassword);

                        var errors = recordLogCMD.ExecuteNonQuery();

                        if (errors <= 0)
                        {

                            Console.WriteLine("Error inserting data!");
                        } else { 
                            result = true;
                        }
                    }
                }

                conn.Close();

                return result;
            }
        }

        public bool updateProfile(string last_name, string first_name, string middle_name)
        {
            bool result = false;
            bool userFound = false;

            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
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
                using (MySqlCommand recordLogCMD = new MySqlCommand())
                {
                    recordLogCMD.Connection = conn;
                    recordLogCMD.CommandText = "UPDATE emp_users SET last_name = @last_name, first_name = @first_name, middle_name = @middle_name WHERE id = @user_id";
                    recordLogCMD.Parameters.AddWithValue("@user_id", UserLogin.user_id);
                    recordLogCMD.Parameters.AddWithValue("@last_name", last_name);
                    recordLogCMD.Parameters.AddWithValue("@first_name", first_name);
                    recordLogCMD.Parameters.AddWithValue("@middle_name", middle_name);

                    var errors = recordLogCMD.ExecuteNonQuery();

                    if (errors <= 0)
                    {

                        Console.WriteLine("Error inserting data!");
                    } else { 

                        result = true;
                    }
                }

                if (result)
                {
                    using (MySqlCommand loginCMD = new MySqlCommand())
                    {
                        loginCMD.Connection = conn;
                        loginCMD.CommandText = "SELECT first_name, last_name, middle_name FROM emp_users WHERE id = @user_id;";
                        loginCMD.Parameters.AddWithValue("@user_id", UserLogin.user_id);

                        MySqlDataReader reader = loginCMD.ExecuteReader();

                        if(reader.HasRows)
                        {

                            while (reader.Read()) 
                            {
                                UserLogin.first_name = reader["first_name"].ToString();
                                UserLogin.last_name = reader["last_name"].ToString();
                                UserLogin.middle_name = reader["middle_name"].ToString();
                            }
                        }

                        reader.Close();
                    }
                }

                conn.Close();

                return result;
            }
        }

        public ArrayList loadUnauthorizedSites(string asset_tag)
        {
            ArrayList arrUnauthorizedSites = new ArrayList();

            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
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

                    return arrUnauthorizedSites;
                }

                using (MySqlCommand getSitesCMD = new MySqlCommand())
                {
                    getSitesCMD.Connection = conn;
                    getSitesCMD.CommandText = "SELECT emp_sites.name AS site_name FROM emp_site_permissions " +
                        "INNER JOIN emp_users ON emp_site_permissions.user_id = emp_users.IDENTITY " +
                        "INNER JOIN emp_assets ON emp_user.asset_id = emp_assets.id " +
                        "INNER JOIN emp_sites ON emp_site_permissions.site_id = emp_sites.IDENTITY " +
                        "WHERE emp_assets.asset_number = @asset_tag " +
                        "AND is_allowed = false;";
                    getSitesCMD.Parameters.AddWithValue("@asset_tag", asset_tag);

                    MySqlDataReader reader = getSitesCMD.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            arrUnauthorizedSites.Add(reader["@site_name"].ToString().ToUpper());
                        }
                    }

                    reader.Close();
                }

                conn.Close();
            }

            return arrUnauthorizedSites;
        }

        public bool softwareOverride(string asset_number, string department, string employee_id, string password, string reason)
        {
            bool result = false;
            string asset_id = "";
            string department_id = "";

            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (MySqlException mysqle)
                {

                    Console.WriteLine(mysqle.Number + " " + mysqle.Message);
                    switch (mysqle.Number)
                    {
                        case 0:
                            break;

                        case 1045:
                            break;
                    }

                    return result;
                }

                using (MySqlCommand loginCMD = new MySqlCommand())
                {
                    loginCMD.Connection = conn;
                    loginCMD.CommandText = "SELECT asset_id, emp_assets.asset_number, department_id, emp_departments.name FROM emp_users " +
                        "INNER JOIN emp_assets ON emp_users.asset_id = emp_assets.id " +
                        "INNER JOIN emp_departments ON emp_users.department_id = emp_departments.id " +
                        "WHERE emp_assets.asset_number = @asset_number and emp_departments.name = @department;";
                    loginCMD.Parameters.AddWithValue("@asset_number", asset_number);
                    loginCMD.Parameters.AddWithValue("@department", department);

                    MySqlDataReader reader = loginCMD.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            asset_id = reader["asset_id"].ToString();
                            department_id = reader["department_id"].ToString();
                        }

                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                    reader.Close();
                }

                if(result)
                {
                    using (MySqlCommand adminCMD = new MySqlCommand())
                    {
                        adminCMD.Connection = conn;
                        adminCMD.CommandText = "SELECT employee_id, password, role_id, emp_roles.role AS rolename, emp_roles.override_authorize AS canoverride FROM emp_users " +
                            "INNER JOIN emp_roles ON emp_users.role_id = emp_roles.id " +
                            "WHERE employee_id = @employee_id and password = @password;";
                        adminCMD.Parameters.AddWithValue("@employee_id", employee_id);
                        adminCMD.Parameters.AddWithValue("@password", password);

                        MySqlDataReader reader = adminCMD.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["canoverride"].ToString() == "all" ||
                                    reader["canoverride"].ToString() == "department")
                                {
                                    result = true;
                                }
                                else
                                {
                                    result = false;
                                }
                            }
                        }
                        else
                        {
                            result = false;
                        }

                        reader.Close();
                    }
                }

                if(result)
                {
                    using (MySqlCommand overrideCMD = new MySqlCommand())
                    {
                        overrideCMD.Connection = conn;
                        overrideCMD.CommandText = "INSERT INTO emp_override (asset_id, department_id, employee_id, reason) VALUES (@asset_id, @department_id, @employee_id, reason)";
                        overrideCMD.Parameters.AddWithValue("@asset_id", asset_id);
                        overrideCMD.Parameters.AddWithValue("@department_id", department_id);
                        overrideCMD.Parameters.AddWithValue("@employee_id", employee_id);
                        overrideCMD.Parameters.AddWithValue("@reason", reason);

                        var errors = overrideCMD.ExecuteNonQuery();

                        if (errors < 0)
                        {
                            result = false;
                            Console.WriteLine("Error inserting data!");
                        } else { 
                            result = true;
                        }
                    }
                }

                conn.Close();
            }

            return result;
        }
    }
}
