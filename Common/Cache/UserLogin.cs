namespace Common.Cache
{
    public static class UserLogin
    {
        
        public static string asset_id {  get; set; }

        public static string asset_number { get; set; }

        public static string user_id { get; set; }

        public static string first_name { get; set; }

        public static string middle_name { get; set; }

        public static string last_name { get; set; }

        public static string department_id { get; set; }

        public static string department { get; set; }

        public static string role { get; set; }

        public static string timesheet_report { get; set; }

        public static string activity_report { get; set; }

        public static string override_report { get; set; }

        public static string override_authorize { get; set; }

        public static string Assets { get; set; }

        public static string Departments { get; set; }

        public static string Roles { get; set; }

        public static string Users { get; set; }

        public static string Sites { get; set; }

        public static string site_permissions { get; set; }

        public static void clear_data()
        {
            asset_id = "";
            asset_number = "";
            user_id = "";
            first_name = "";
            middle_name = "";
            last_name = "";
            department_id = "";
            department = "";
            role = "";
        }
    }
}
