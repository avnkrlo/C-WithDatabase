using System;

namespace C_WithDatabase
{
    public class StringsResources
    {
        //Login
        public static string Login {  get; set; }
        public static string Shutdown { get; set; }
        public static string Restart { get; set; }
        public static string SyncShutdown { get; set; }
        public static string SyncRestart { get; set; }
        public static string InvalidUserorPassword { get; set; }
        public static string NoServerConnection { get; set; }
        public static string SyncInProgress { get; set; }

        //Override
        public static string SystemOverride { get; set; }
        public static string Override { get; set; }
        public static string EmptyFields { get; set; }
        public static string OverrideNoSuccess { get; set; }

        //Main
        public static string Home { get; set; }
        public static string ReportMenu { get; set; }
        public static string Timesheet { get; set; }
        public static string Activity {  get; set; }
        public static string Admin {  get; set; }
        public static string Asset { get; set;}
        public static string Department { get; set; }
        public static string Roles { get; set; }
        public static string Users { get; set; }
        public static string Sites { get; set; }
        public static string Permissions { get; set; }
        public static string Settings { get; set; }
        public static string UseCheckout { get; set; }
        public static string ActionInvalid { get; set; }
        public static string LogoutConfirm { get; set; }
        public static string Logout { get; set; }
        public static string Idle { get; set; }
        public static string Active { get; set; }
        public static string Break {  get; set; }
        public static string InBreak { get; set; }
        public static string Lunch { get; set; }
        public static string InLunch { get; set; }
        public static string Overbreak {  get; set; }
        public static string Unauthorized { get; set; }

        //Home
        public static string Status { get; set; }
        public static string Breaks { get; set; }
        public static string TodaySummary { get; set; }
        public static string Minutes {  get; set; }
        public static string Break1End {  get; set; }
        public static string LunchStart { get; set; }
        public static string LunchEnd { get; set; }
        public static string Break2Start {  get; set; }
        public static string Break2End { get; set; }

        //Timesheet
        public static string PCTag { get; set; }
        public static string Departments { get; set; }
        public static string Date { get; set; }
        public static string Summary { get; set; }
        public static string TimeInOut { get; set; }
        public static string BreakInOut { get; set; }
        public static string Total { get; set; }
        public static string Filter { get; set; }
        public static string Print { get; set; }
        public static string DateEndCheck { get; set; }
        public static string SelectAsset { get; set; }
        public static string StartDate { get; set; }
        public static string EndDate { get; set; }
        public static string To { get; set; }

        //Activity
        public static string SelectActivity { get; set; }

        //Asset
        public static string AddAsset { get; set; }
        public static string EditAsset { get; set; }
        public static string No { get; set; }
        public static string Description { get; set; }
        public static string Save { get; set; }
        public static string EnterAsset { get; set; }

        //Department
        public static string AddDepartment { get; set; }
        public static string EditDepartment { get; set; }
        public static string EnterDepartment { get; set; }

        //Roles
        public static string Role { get; set; }
        public static string AddRole { get; set; }
        public static string EditRole { get; set; }
        public static string RoleName { get; set; }
        public static string CanOverride { get; set; }
        public static string SitePermissions { get; set; }
        public static string EnterRole { get; set; }

        //Users
        public static string AddUser { get; set; }
        public static string EditUser { get; set; }
        public static string EmployeeID { get; set; }
        public static string FamilyName { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string Reset { get; set; }
        public static string PasswordReset { get; set; }
        public static string PasswordResetOK { get; set; }
        public static string PasswordResetNG { get; set; }

        //Site
        public static string SiteName { get; set; }
        public static string AddSite { get; set; }
        public static string EditSite { get; set; }
        public static string EnterSiteName { get; set; }

        //Site Permissions
        public static string Site { get; set; }
        public static string BatchUpdate { get; set; }
        public static string UserSitePermission { get; set; }
        public static string SelectDepartment { get; set; }

        //Settings
        public static string Change { get; set; }
        public static string Password { get; set; }
        public static string OldPassword { get; set; }
        public static string NewPassword { get; set; }
        public static string ConfirmPassword { get; set; }
        public static string PasswordRequirement { get; set; }
        public static string OldPasswordInvalid { get; set; }
        public static string NewPasswordInvalid { get; set; }
        public static string ConfirmPasswordInvalid { get; set; }
        public static string PasswordNotMatch { get; set; }
        public static string PasswordChangeOK { get; set; }
        public static string PasswordChangeNG { get; set; }
        public static string OK { get; set; }
        public static string Cancel { get; set; }
        public static string Profile { get; set; }
        public static string Edit { get; set; }
        public static string FamilyNameInvalid { get; set; }
        public static string FirstNameInvalid { get; set; }
        public static string ProfileUpdateOK { get; set; }
        public static string ProfileUpdateNG { get; set; }
        public static string Language { get; set; }
        public static string English { get; set; }
        public static string Japanese { get; set; }
    }
}