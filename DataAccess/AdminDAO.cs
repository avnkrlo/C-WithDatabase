using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

namespace DataAccess
{
    public class AdminDAO : DatabaseConnection
    {
        public ArrayList getAssetsList()
        {
            ArrayList arAssets = new ArrayList();


            string[] all = { "" };

            arAssets.Add(all);


            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT asset_number FROM emp_assets;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[1];

                            ardata[0] = (dataReader["asset_number"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getemployeeidlist()
        {
            ArrayList arAssets = new ArrayList();


            string[] all = { "" };

            arAssets.Add(all);


            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT employee_id FROM mst_users;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[1];

                            ardata[0] = (dataReader["employee_id"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getDepartmentList()
        {
            ArrayList arAssets = new ArrayList();


            string[] all = { "" };

            arAssets.Add(all);


            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT name FROM mst_departments;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[1];

                            ardata[0] = (dataReader["name"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getlastnamelist()
        {
            ArrayList arAssets = new ArrayList();


            string[] all = { "" };

            arAssets.Add(all);


            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT DISTINCT last_name FROM mst_users;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[1];

                            ardata[0] = (dataReader["last_name"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getfirstnamelist()
        {
            ArrayList arAssets = new ArrayList();


            string[] all = { "" };

            arAssets.Add(all);


            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT DISTINCT first_name FROM mst_users;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[1];

                            ardata[0] = (dataReader["first_name"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getrolelist()
        {
            ArrayList arAssets = new ArrayList();

            string[] all = { "" };

            arAssets.Add(all);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_roles;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[1];
                            ardata[0] = (dataReader["role"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getsiteslist()
        {
            ArrayList arAssets = new ArrayList();

            string[] all = { "" };

            arAssets.Add(all);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_sites;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[3];
                            ardata[0] = (dataReader["name"].ToString());
                            ardata[1] = "false";
                            ardata[2] = (dataReader["id"].ToString());
                            arAssets.Add(ardata);

                            ardata = null;


                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getassets(string asset_number)
        {
            ArrayList arAssets = new ArrayList();

            string[] arheaders = { "NO", "PC TAG", "DESCRIPTION" };

            arAssets.Add(arheaders);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    if (asset_number == "")
                    {
                        getactminscmd.CommandText = "SELECT * FROM mst_assets;";
                    }
                    else
                    {
                        getactminscmd.CommandText = "SELECT * FROM mst_assets " +
                            "WHERE asset_number = @asset_number;";

                        getactminscmd.Parameters.AddWithValue("@asset_number", asset_number);
                    }


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            List<string> ardata = new List<string>();
                            ardata.Add(dataReader["id"].ToString());
                            ardata.Add(dataReader["asset_number"].ToString());
                            ardata.Add(dataReader["description"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getdepartments(string department_name)
        {
            ArrayList arDepartments = new ArrayList();

            string[] arheaders = { "ID", "DEPARTMENT NAME" };

            arDepartments.Add(arheaders);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arDepartments;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_departments ";

                    if (department_name != "")
                    {
                        getactminscmd.CommandText += "WHERE UPPER(name) = @department_name ";

                        getactminscmd.Parameters.AddWithValue("@department_name", department_name);
                    }

                    getactminscmd.CommandText += "ORDER BY id ASC;";


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            List<string> ardata = new List<string>();
                            ardata.Add(dataReader["id"].ToString());
                            ardata.Add(dataReader["name"].ToString());

                            arDepartments.Add(ardata);

                            ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arDepartments;
        }

        public ArrayList getroles(string role_name)
        {
            ArrayList arRoles = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arRoles;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_roles ";

                    if (role_name != "")
                    {
                        getactminscmd.CommandText += "WHERE UPPER(role) = @role_name ";

                        getactminscmd.Parameters.AddWithValue("@role_name", role_name);
                    }

                    getactminscmd.CommandText += "ORDER BY id ASC;";


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            List<string> ardata = new List<string>();
                            ardata.Add(dataReader["id"].ToString());
                            ardata.Add(dataReader["role"].ToString());
                            ardata.Add(dataReader["timesheet_reports"].ToString());
                            ardata.Add(dataReader["activity_reports"].ToString());
                            ardata.Add(dataReader["override_reports"].ToString());
                            ardata.Add(dataReader["override_authorize"].ToString());
                            ardata.Add(dataReader["assets"].ToString());
                            ardata.Add(dataReader["departments"].ToString());
                            ardata.Add(dataReader["roles"].ToString());
                            ardata.Add(dataReader["users"].ToString());
                            ardata.Add(dataReader["sites"].ToString());
                            ardata.Add(dataReader["site_permissions"].ToString());

                            arRoles.Add(ardata);

                            ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arRoles;
        }

        public ArrayList getusers(string filter, string keyword)
        {
            ArrayList arAssets = new ArrayList();

            string[] arheaders = { "NO", "EMPLOYEE ID", "DEPARTMENT", "LAST NAME", "FIRST NAME", "MIDDLE NAME", "ASSET NUMBER", "ROLE" };

            arAssets.Add(arheaders);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT mst_users.id AS id, employee_id, mst_departments.name AS department, last_name, first_name, middle_name, mst_assets.asset_number AS asset_number, mst_roles.role AS role FROM mst_users " +
                        "INNER JOIN mst_assets ON mst_users.asset_id = mst_assets.id " +
                        "INNER JOIN mst_departments ON mst_users.department_id = mst_departments.id " +
                        "INNER JOIN mst_roles ON mst_users.role_id = mst_roles.id ";

                    if (keyword != "")
                    {
                        switch (filter)
                        {
                            case "Department":
                                getactminscmd.CommandText += "WHERE mst_departments.name = @keyword ";
                                break;
                            case "Last name":
                                getactminscmd.CommandText += "WHERE last_name = @keyword ";
                                break;
                            case "First name":
                                getactminscmd.CommandText += "WHERE first_name = @keyword ";
                                break;
                            case "Asset Number":
                                getactminscmd.CommandText += "WHERE asset_number = @keyword ";
                                break;
                            case "Employee ID":
                            default:
                                getactminscmd.CommandText += "WHERE employee_id = @keyword ";
                                break;
                        }
                    }

                    getactminscmd.CommandText += "ORDER BY id ASC;";

                    getactminscmd.Parameters.AddWithValue("@keyword", keyword);

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            List<string> ardata = new List<string>();
                            ardata.Add(dataReader["id"].ToString());
                            ardata.Add(dataReader["employee_id"].ToString());
                            ardata.Add(dataReader["department"].ToString());
                            ardata.Add(dataReader["last_name"].ToString());
                            ardata.Add(dataReader["first_name"].ToString());
                            ardata.Add(dataReader["middle_name"].ToString());
                            ardata.Add(dataReader["asset_number"].ToString());
                            ardata.Add(dataReader["role"].ToString());

                            arAssets.Add(ardata);

                            ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getsites(string sitename)
        {

            ArrayList arAssets = new ArrayList();

            string[] arheaders = { "NO", "SITE" };

            arAssets.Add(arheaders);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_sites ";

                    if (sitename != "")
                    {
                        getactminscmd.CommandText += "WHERE name = @sitename ";

                        getactminscmd.Parameters.AddWithValue("@sitename", sitename);
                    }

                    getactminscmd.CommandText += "ORDER BY id ASC;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            List<string> ardata = new List<string>();
                            ardata.Add(dataReader["id"].ToString());
                            ardata.Add(dataReader["name"].ToString());
                            arAssets.Add(ardata);

                            ardata = null;

                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getsitespermissions(string filter, string keyword, string site, string isallowed)
        {
            ArrayList arSites = new ArrayList();

            string[] arheaders = { "PC TAG", "DEPARTMENT", "EMPLOYEE ID", "SITE NAME", "ALLOWED" };

            arSites.Add(arheaders);

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arSites;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT mst_sites.id AS site_id, mst_assets.asset_number AS pctag, mst_departments.name AS department, mst_users.employee_id AS employee_id, mst_sites.name AS site_name, is_allowed " +
                        "FROM mst_site_permissions " +
                        "INNER JOIN mst_users ON mst_users.id = mst_site_permissions.user_id " +
                        "INNER JOIN mst_departments ON mst_departments.id = mst_users.department_id " +
                        "INNER JOIN mst_roles ON mst_roles.id = mst_users.role_id " +
                        "INNER JOIN mst_assets ON mst_assets.id = mst_users.asset_id " +
                        "INNER JOIN mst_sites ON mst_sites.id = mst_site_permissions.site_id ";

                    if (keyword != "")
                    {
                        switch (filter)
                        {
                            case "0":
                                getactminscmd.CommandText += "WHERE mst_assets.asset_number = @keyword ";
                                break;
                            case "1":
                                getactminscmd.CommandText += "WHERE mst_departments.name = @keyword ";
                                break;
                            case "2":
                                getactminscmd.CommandText += "WHERE mst_roles.role = @keyword ";
                                break;

                            case "3":
                            default:
                                getactminscmd.CommandText += "WHERE mst_users.employee_id = @keyword ";
                                break;
                        }

                        getactminscmd.Parameters.AddWithValue("@keyword", keyword);
                    }

                    if (site != "")
                    {
                        if (getactminscmd.CommandText.Contains("WHERE"))
                        {
                            getactminscmd.CommandText += "AND site_name = @site ";
                        }
                        else
                        {
                            getactminscmd.CommandText += "WHERE site_name = @site ";
                        }
                        getactminscmd.Parameters.AddWithValue("@site", site);
                    }

                    if (isallowed != "")
                    {
                        if (getactminscmd.CommandText.Contains("WHERE"))
                        {
                            getactminscmd.CommandText += "AND is_allowed = @isallowed ";
                        }
                        else
                        {
                            getactminscmd.CommandText += "WHERE is_allowed = @isallowed ";
                        }

                        bool allowed = false;

                        if (isallowed == "Not Allowed")
                        {
                            allowed = false;
                        }

                        if (isallowed == "Allowed")
                        {
                            allowed = true;
                        }
                        getactminscmd.Parameters.AddWithValue("@isallowed", allowed);
                    }

                    getactminscmd.CommandText += "ORDER BY pctag, site_id ASC;";

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            List<string> ardata = new List<string>();
                            ardata.Add(dataReader["pctag"].ToString());
                            ardata.Add(dataReader["department"].ToString());
                            ardata.Add(dataReader["employee_id"].ToString());
                            ardata.Add(dataReader["site_name"].ToString());
                            ardata.Add(dataReader["is_allowed"].ToString());

                            arSites.Add(ardata);

                            ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arSites;
        }

        public ArrayList getasset(string asset_id)
        {
            ArrayList arAssets = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_assets " +
                        "WHERE id = @asset_id;";

                    getactminscmd.Parameters.AddWithValue("@asset_id", asset_id);


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //List<string> ardata = new List<string>();
                            arAssets.Add(dataReader["id"].ToString());
                            arAssets.Add(dataReader["asset_number"].ToString());
                            arAssets.Add(dataReader["description"].ToString());

                            //arAssets.Add(ardata);

                            //ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getdepartment(string department_id)
        {
            ArrayList arAssets = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_departments " +
                        "WHERE id = @department_id;";

                    getactminscmd.Parameters.AddWithValue("@department_id", department_id);


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //List<string> ardata = new List<string>();
                            arAssets.Add(dataReader["id"].ToString());
                            arAssets.Add(dataReader["name"].ToString());

                            //arAssets.Add(ardata);

                            //ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getrole(string role_id)
        {
            ArrayList arRole = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arRole;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_roles " +
                        "WHERE id = @role_id;";

                    getactminscmd.Parameters.AddWithValue("@role_id", role_id);

                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //List<string> ardata = new List<string>();
                            arRole.Add(dataReader["id"].ToString());
                            arRole.Add(dataReader["role"].ToString());
                            arRole.Add(dataReader["timesheet_reports"].ToString());
                            arRole.Add(dataReader["activity_reports"].ToString());
                            arRole.Add(dataReader["override_reports"].ToString());
                            arRole.Add(dataReader["override_authorize"].ToString());
                            arRole.Add(dataReader["assets"].ToString());
                            arRole.Add(dataReader["departments"].ToString());
                            arRole.Add(dataReader["roles"].ToString());
                            arRole.Add(dataReader["users"].ToString());
                            arRole.Add(dataReader["sites"].ToString());
                            arRole.Add(dataReader["site_permissions"].ToString());
                            //arAssets.Add(ardata);

                            //ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arRole;
        }

        public ArrayList getuser(string user_id)
        {
            ArrayList arUser = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arUser;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT mst_users.id AS id, employee_id, mst_departments.name AS department, last_name, first_name, middle_name, mst_assets.asset_number AS asset_number, mst_roles.role AS role FROM mst_users " +
                        "INNER JOIN mst_assets ON mst_users.asset_id = mst_assets.id " +
                        "INNER JOIN mst_departments ON mst_users.department_id = mst_departments.id " +
                        "INNER JOIN mst_roles ON mst_users.role_id = mst_roles.id " +
                        "WHERE mst_users.id = @user_id;";

                    getactminscmd.Parameters.AddWithValue("@user_id", user_id);


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            arUser.Add(dataReader["id"].ToString());
                            arUser.Add(dataReader["employee_id"].ToString());
                            arUser.Add(dataReader["department"].ToString());
                            arUser.Add(dataReader["last_name"].ToString());
                            arUser.Add(dataReader["first_name"].ToString());
                            arUser.Add(dataReader["middle_name"].ToString());
                            arUser.Add(dataReader["asset_number"].ToString());
                            arUser.Add(dataReader["role"].ToString());

                            //arAssets.Add(ardata);

                            //ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arUser;
        }

        public ArrayList getsite(string site_id)
        {
            ArrayList arAssets = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arAssets;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT * FROM mst_sites " +
                        "WHERE id = @site_id;";

                    getactminscmd.Parameters.AddWithValue("@site_id", site_id);


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //List<string> ardata = new List<string>();
                            arAssets.Add(dataReader["id"].ToString());
                            arAssets.Add(dataReader["name"].ToString());

                            //arAssets.Add(ardata);

                            //ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arAssets;
        }

        public ArrayList getusersitespermissions(string asset_id)
        {
            ArrayList arSites = new ArrayList();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return arSites;
                }

                //Get Activity Minutes Command
                using (MySqlCommand getactminscmd = new MySqlCommand())
                {
                    getactminscmd.Connection = connection;
                    getactminscmd.CommandText = "SELECT site_id, mst_sites.name AS site_name, is_allowed " +
                        "FROM mst_site_permissions " +
                        "INNER JOIN mst_users ON mst_users.id = mst_site_permissions.user_id " +
                        "INNER JOIN mst_assets ON mst_assets.id = mst_users.asset_id " +
                        "INNER JOIN mst_sites ON mst_sites.id = mst_site_permissions.site_id " +
                        "WHERE mst_assets.asset_number = @asset_id " +
                        "ORDER BY site_id ASC;";

                    getactminscmd.Parameters.AddWithValue("@asset_id", asset_id);


                    MySqlDataReader dataReader = getactminscmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string[] ardata = new string[3];

                            ardata[0] = dataReader["site_name"].ToString();
                            ardata[1] = dataReader["is_allowed"].ToString();
                            ardata[2] = dataReader["site_id"].ToString();

                            arSites.Add(ardata);

                            ardata = null;
                        }
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    connection.Close();
                    //this.CloseConnection();
                }
            }
            return arSites;
        }

        public bool saveasset(string asset_number, string description)
        {
            bool result = false;

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }
                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "INSERT INTO mst_assets (asset_number, description) VALUES (@asset_number, @description)";
                    recordlogcmd.Parameters.AddWithValue("@asset_number", asset_number);
                    recordlogcmd.Parameters.AddWithValue("@description", description);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updateasset(string asset_id, string asset_number, string description)
        {
            bool result = false;

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }
                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "UPDATE mst_assets SET asset_number = @asset_number, description = @description WHERE id = @asset_id";
                    recordlogcmd.Parameters.AddWithValue("@asset_id", asset_id);
                    recordlogcmd.Parameters.AddWithValue("@asset_number", asset_number);
                    recordlogcmd.Parameters.AddWithValue("@description", description);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool savedepartment(string department_name)
        {
            bool result = false;

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }
                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "INSERT INTO mst_departments (name, description) VALUES (@department_name)";
                    recordlogcmd.Parameters.AddWithValue("@department_name", department_name);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updatedepartment(string department_id, string department_name)
        {
            bool result = false;

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }
                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "UPDATE mst_sites SET name = @department_name WHERE id = @department_id";
                    recordlogcmd.Parameters.AddWithValue("@site_id", department_id);
                    recordlogcmd.Parameters.AddWithValue("@department_name", department_name);



                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool saverole(string role, string rpt_timesheets, string rpt_activity, string rpt_override, string can_override, string assets, string departments, string roles, string users, string sites, string site_permissions)
        {
            bool result = false;
            string asset_id = "";
            string user_id = "";
            string department_id = "";
            string role_id = "";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "INSERT INTO mst_roles (role, timesheet_reports, activity_reports, override_reports, override_authorize, assets, departments, roles, users, sites, site_permissions) " +
                        "VALUES (@role, @rpt_timesheets, @rpt_activity, @rpt_override, @can_override, @assets, @departments, @roles, @users, @sites, @site_permissions)";

                    recordlogcmd.Parameters.AddWithValue("@role", role);
                    recordlogcmd.Parameters.AddWithValue("@rpt_timesheets", rpt_timesheets);
                    recordlogcmd.Parameters.AddWithValue("@rpt_activity", rpt_activity);
                    recordlogcmd.Parameters.AddWithValue("@rpt_override", rpt_override);
                    recordlogcmd.Parameters.AddWithValue("@can_override", can_override);
                    recordlogcmd.Parameters.AddWithValue("@assets", assets);
                    recordlogcmd.Parameters.AddWithValue("@departments", departments);
                    recordlogcmd.Parameters.AddWithValue("@roles", roles);
                    recordlogcmd.Parameters.AddWithValue("@users", users);
                    recordlogcmd.Parameters.AddWithValue("@sites", sites);
                    recordlogcmd.Parameters.AddWithValue("@site_permissions", site_permissions);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updaterole(string role_id, string role, string rpt_timesheets, string rpt_activity, string rpt_override, string can_override, string assets, string departments, string roles, string users, string sites, string site_permissions)
        {
            bool result = false;

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "UPDATE mst_roles SET role = @role, timesheet_reports = @rpt_timesheets, activity_reports = @rpt_activity, override_reports = @rpt_override, " +
                        "override_authorize = @can_override, assets = @assets, departments = @departments, roles = @roles, users = @users, sites = @sites, site_permissions = @site_permissions ) " +
                        "WHERE id = @role_id;";

                    recordlogcmd.Parameters.AddWithValue("@role", role_id);
                    recordlogcmd.Parameters.AddWithValue("@role", role);
                    recordlogcmd.Parameters.AddWithValue("@rpt_timesheets", rpt_timesheets);
                    recordlogcmd.Parameters.AddWithValue("@rpt_activity", rpt_activity);
                    recordlogcmd.Parameters.AddWithValue("@rpt_override", rpt_override);
                    recordlogcmd.Parameters.AddWithValue("@can_override", can_override);
                    recordlogcmd.Parameters.AddWithValue("@assets", assets);
                    recordlogcmd.Parameters.AddWithValue("@departments", departments);
                    recordlogcmd.Parameters.AddWithValue("@roles", roles);
                    recordlogcmd.Parameters.AddWithValue("@users", users);
                    recordlogcmd.Parameters.AddWithValue("@sites", sites);
                    recordlogcmd.Parameters.AddWithValue("@site_permissions", site_permissions);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool saveuser(string asset_number, string department, string role, string employee_id, string last_name, string first_name, string middle_name)
        {
            bool result = false;
            string asset_id = "";
            string user_id = "";
            string department_id = "";
            string role_id = "";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand getassetidcmd = new MySqlCommand())
                {
                    getassetidcmd.Connection = connection;
                    getassetidcmd.CommandText = "SELECT * FROM mst_assets WHERE asset_number = @asset_number";
                    getassetidcmd.Parameters.AddWithValue("@asset_number", asset_number);

                    MySqlDataReader dataReader = getassetidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            asset_id = dataReader["id"].ToString();
                        }
                    }

                    if (asset_id == "" ||
                        asset_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                using (MySqlCommand getdeptidcmd = new MySqlCommand())
                {
                    getdeptidcmd.Connection = connection;
                    getdeptidcmd.CommandText = "SELECT * FROM mst_departments WHERE name = @department";
                    getdeptidcmd.Parameters.AddWithValue("@department", department);

                    MySqlDataReader dataReader = getdeptidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            department_id = dataReader["id"].ToString();
                        }
                    }

                    if (department_id == "" ||
                        department_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                using (MySqlCommand getroleidcmd = new MySqlCommand())
                {
                    getroleidcmd.Connection = connection;
                    getroleidcmd.CommandText = "SELECT * FROM mst_roles WHERE role = @role";
                    getroleidcmd.Parameters.AddWithValue("@role", role);

                    MySqlDataReader dataReader = getroleidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            role_id = dataReader["id"].ToString();
                        }
                    }

                    if (role_id == "" ||
                        role_id == null)
                    {
                        return result;
                    }

                    dataReader.Close();
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    string password = "Password01";

                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "INSERT INTO mst_users (employee_id, department_id, last_name, first_name, middle_name, asset_id, role_id, password) " +
                        "VALUES (@employee_id, @department_id, @last_name, @first_name, @middle_name, @asset_id, @role_id, @password)";

                    recordlogcmd.Parameters.AddWithValue("@employee_id", employee_id);
                    recordlogcmd.Parameters.AddWithValue("@department_id", department_id);
                    recordlogcmd.Parameters.AddWithValue("@last_name", last_name);
                    recordlogcmd.Parameters.AddWithValue("@first_name", first_name);
                    recordlogcmd.Parameters.AddWithValue("@middle_name", middle_name);
                    recordlogcmd.Parameters.AddWithValue("@asset_id", asset_id);
                    recordlogcmd.Parameters.AddWithValue("@role_id", role_id);
                    recordlogcmd.Parameters.AddWithValue("@password", password);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                using (MySqlCommand getuseridcmd = new MySqlCommand())
                {
                    getuseridcmd.Connection = connection;
                    getuseridcmd.CommandText = "SELECT mst_users.id AS user_id FROM mst_users " +
                        "INNER JOIN mst_assets ON mst_assets.id = mst_users.asset_id " +
                        "INNER JOIN mst_departments ON mst_departments.id = mst_users.department_id " +
                        "WHERE mst_assets.asset_number = @asset_number AND mst_departments.name = @department AND employee_id = @employee_id;";

                    getuseridcmd.Parameters.AddWithValue("@asset_number", asset_number);
                    getuseridcmd.Parameters.AddWithValue("@department", department);
                    getuseridcmd.Parameters.AddWithValue("@employee_id", employee_id);

                    MySqlDataReader dataReader = getuseridcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            user_id = dataReader["user_id"].ToString();
                        }
                    }

                    if (user_id == "" ||
                        user_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                using (MySqlCommand recordsitespermissionscmd = new MySqlCommand())
                {
                    recordsitespermissionscmd.Connection = connection;
                    recordsitespermissionscmd.CommandText = "INSERT INTO mst_site_permissions (user_id, site_id, department_id, role_id) " +
                        "SELECT @user_id, id, @department_id, @role_id " +
                        "FROM mst_sites;";

                    recordsitespermissionscmd.Parameters.AddWithValue("@user_id", user_id);
                    recordsitespermissionscmd.Parameters.AddWithValue("@department_id", department_id);
                    recordsitespermissionscmd.Parameters.AddWithValue("@role_id", role_id);

                    var errors = recordsitespermissionscmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updateuser(string user_id, string asset_number, string department, string role, string employee_id, string last_name, string first_name, string middle_name)
        {
            bool result = false;
            string asset_id = "";
            string department_id = "";
            string role_id = "";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand getassetidcmd = new MySqlCommand())
                {
                    getassetidcmd.Connection = connection;
                    getassetidcmd.CommandText = "SELECT * FROM mst_assets WHERE asset_number = @asset_number";
                    getassetidcmd.Parameters.AddWithValue("@asset_number", asset_number);

                    MySqlDataReader dataReader = getassetidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            asset_id = dataReader["id"].ToString();
                        }
                    }

                    if (asset_id == "" ||
                        asset_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                using (MySqlCommand getdeptidcmd = new MySqlCommand())
                {
                    getdeptidcmd.Connection = connection;
                    getdeptidcmd.CommandText = "SELECT * FROM mst_departments WHERE name = @department";
                    getdeptidcmd.Parameters.AddWithValue("@department", department);

                    MySqlDataReader dataReader = getdeptidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            department_id = dataReader["id"].ToString();
                        }
                    }

                    if (department_id == "" ||
                        department_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                using (MySqlCommand getroleidcmd = new MySqlCommand())
                {
                    getroleidcmd.Connection = connection;
                    getroleidcmd.CommandText = "SELECT * FROM mst_roles WHERE role = @role";
                    getroleidcmd.Parameters.AddWithValue("@role", role);

                    MySqlDataReader dataReader = getroleidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            role_id = dataReader["id"].ToString();
                        }
                    }

                    if (role_id == "" ||
                        role_id == null)
                    {
                        return result;
                    }

                    dataReader.Close();
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "UPDATE mst_users SET employee_id = @employee_id, department_id = @department_id, last_name = @last_name, first_name = @first_name, middle_name = @middle_name, asset_id = @asset_id, role_id = @role_id " +
                        "WHERE id = @user_id";

                    recordlogcmd.Parameters.AddWithValue("@user_id", user_id);
                    recordlogcmd.Parameters.AddWithValue("@employee_id", employee_id);
                    recordlogcmd.Parameters.AddWithValue("@department_id", department_id);
                    recordlogcmd.Parameters.AddWithValue("@last_name", last_name);
                    recordlogcmd.Parameters.AddWithValue("@first_name", first_name);
                    recordlogcmd.Parameters.AddWithValue("@middle_name", middle_name);
                    recordlogcmd.Parameters.AddWithValue("@asset_id", asset_id);
                    recordlogcmd.Parameters.AddWithValue("@role_id", role_id);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool savesite(string site_name)
        {
            bool result = false;
            string site_id = "";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "INSERT INTO mst_sites (name) VALUES (@site_name)";
                    recordlogcmd.Parameters.AddWithValue("@site_name", site_name);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                using (MySqlCommand getsiteidcmd = new MySqlCommand())
                {
                    getsiteidcmd.Connection = connection;
                    getsiteidcmd.CommandText = "SELECT id FROM mst_sites " +
                        "WHERE name = @site_name;";

                    getsiteidcmd.Parameters.AddWithValue("@site_name", site_name);

                    MySqlDataReader dataReader = getsiteidcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            site_id = dataReader["id"].ToString();
                        }
                    }

                    if (site_id == "" ||
                        site_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                using (MySqlCommand recordsitespermissionscmd = new MySqlCommand())
                {
                    recordsitespermissionscmd.Connection = connection;
                    recordsitespermissionscmd.CommandText = "INSERT INTO mst_site_permissions (user_id, site_id) " +
                        "SELECT id, @site_id, department_id, role_id " +
                        "FROM mst_users;";

                    recordsitespermissionscmd.Parameters.AddWithValue("@site_id", site_id);

                    var errors = recordsitespermissionscmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updatesite(string site_id, string site_name)
        {
            bool result = false;

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "UPDATE mst_sites SET name = @site_name WHERE id=@site_id";

                    recordlogcmd.Parameters.AddWithValue("@site_id", site_id);
                    recordlogcmd.Parameters.AddWithValue("@site_name", site_name);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updateusersitespermission(string asset_number, string allowed_ids, string notallowed_ids)
        {
            bool result = false;
            string user_id = "";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand getuseridcmd = new MySqlCommand())
                {
                    getuseridcmd.Connection = connection;
                    getuseridcmd.CommandText = "SELECT mst_users.id AS user_id FROM mst_users " +
                        "INNER JOIN mst_assets ON mst_assets.id = mst_users.asset_id " +
                        "WHERE mst_assets.asset_number = @asset_number;";

                    getuseridcmd.Parameters.AddWithValue("@asset_number", asset_number);

                    MySqlDataReader dataReader = getuseridcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            user_id = dataReader["user_id"].ToString();
                        }
                    }

                    if (user_id == "" ||
                        user_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }
                if (allowed_ids != "")
                {
                    using (MySqlCommand updateallowedcmd = new MySqlCommand())
                    {
                        updateallowedcmd.Connection = connection;
                        updateallowedcmd.CommandText = "UPDATE mst_site_permissions " +
                            "SET is_allowed = true ";

                        updateallowedcmd.CommandText += allowed_ids;
                        updateallowedcmd.CommandText += "AND user_id = @user_id;";

                        updateallowedcmd.Parameters.AddWithValue("@user_id", user_id);

                        var errors = updateallowedcmd.ExecuteNonQuery();

                        // Check Error
                        if (errors <= 0)
                        {
                            //result = false;
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
                if (notallowed_ids != "")
                {
                    using (MySqlCommand updatenotallowedcmd = new MySqlCommand())
                    {
                        updatenotallowedcmd.Connection = connection;
                        updatenotallowedcmd.CommandText = "UPDATE mst_site_permissions " +
                            "SET is_allowed = false ";

                        updatenotallowedcmd.CommandText += notallowed_ids;
                        updatenotallowedcmd.CommandText += "AND user_id = @user_id;";

                        updatenotallowedcmd.Parameters.AddWithValue("@user_id", user_id);

                        var errors = updatenotallowedcmd.ExecuteNonQuery();

                        // Check Error
                        if (errors <= 0)
                        {
                            //result = false;
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool updatebatchsitespermission(string filter, string keyword, string allowed_ids, string notallowed_ids)
        {
            bool result = false;
            string result_id = "";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand getuseridcmd = new MySqlCommand())
                {
                    getuseridcmd.Connection = connection;
                    if (filter == "0")
                    {
                        getuseridcmd.CommandText = "SELECT id FROM mst_departments " +
                            "WHERE name = @keyword;";
                    }
                    else
                    {
                        getuseridcmd.CommandText = "SELECT id FROM mst_roles " +
                            "WHERE role = @keyword;";
                    }

                    getuseridcmd.Parameters.AddWithValue("@keyword", keyword);

                    MySqlDataReader dataReader = getuseridcmd.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            result_id = dataReader["id"].ToString();
                        }
                    }

                    if (result_id == "" ||
                        result_id == null)
                    {
                        return result;
                    }
                    dataReader.Close();
                }

                if (allowed_ids != "")
                {
                    using (MySqlCommand updateallowedcmd = new MySqlCommand())
                    {
                        updateallowedcmd.Connection = connection;
                        updateallowedcmd.CommandText = "UPDATE mst_site_permissions SET is_allowed = true ";
                        updateallowedcmd.CommandText += allowed_ids;

                        if (filter == "0")
                        {
                            updateallowedcmd.CommandText += "AND department_id = @result_id;";
                        }
                        else
                        {
                            updateallowedcmd.CommandText += "AND role_id = @result_id;";
                        }


                        updateallowedcmd.Parameters.AddWithValue("@result_id", result_id);

                        var errors = updateallowedcmd.ExecuteNonQuery();

                        // Check Error
                        if (errors <= 0)
                        {
                            //result = false;
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }

                if (notallowed_ids != "")
                {
                    using (MySqlCommand updatenotallowedcmd = new MySqlCommand())
                    {
                        updatenotallowedcmd.Connection = connection;
                        updatenotallowedcmd.CommandText = "UPDATE mst_site_permissions SET is_allowed = false ";
                        updatenotallowedcmd.CommandText += notallowed_ids;
                        if (filter == "0")
                        {
                            updatenotallowedcmd.CommandText += "AND department_id = @result_id;";
                        }
                        else
                        {
                            updatenotallowedcmd.CommandText += "AND role_id = @result_id;";
                        }

                        updatenotallowedcmd.Parameters.AddWithValue("@result_id", result_id);

                        var errors = updatenotallowedcmd.ExecuteNonQuery();

                        // Check Error
                        if (errors <= 0)
                        {
                            //result = false;
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

        public bool resetpassword(string user_id)
        {
            bool result = false;
            string password = "Password01";

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            //MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            //MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    //return result;
                }

                using (MySqlCommand recordlogcmd = new MySqlCommand())
                {
                    recordlogcmd.Connection = connection;
                    recordlogcmd.CommandText = "UPDATE mst_users SET password = @password WHERE id = @user_id";

                    recordlogcmd.Parameters.AddWithValue("@user_id", user_id);
                    recordlogcmd.Parameters.AddWithValue("@password", password);

                    var errors = recordlogcmd.ExecuteNonQuery();

                    // Check Error
                    if (errors <= 0)
                    {
                        //result = false;
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        result = true;
                    }
                }

                //close Connection
                connection.Close();

                return result;
            }
        }

    }
}

