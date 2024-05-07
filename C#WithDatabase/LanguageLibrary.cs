using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_WithDatabase
{
    public class LanguageLibrary
    {
        public static void SetLanguage()
        {
            switch (Utilities.Language)
            {
                case "Japanese":
                    //Login
                    StringsResources.Login = "ログイン";
                    StringsResources.Shutdown = "シャットダウン";
                    StringsResources.Restart = "リスタート";
                    StringsResources.SyncShutdown = "同期とシャットダウン";
                    StringsResources.SyncRestart = "同期とリスタート";
                    StringsResources.InvalidUserorPassword = "PC タグかパスワードが無効です。";
                    StringsResources.NoServerConnection = "サーバー接続エラー。";
                    StringsResources.SyncInProgress = "オフラインデータ同期中です。";

                    //Override
                    StringsResources.SystemOverride = "システム オーバーライド";
                    StringsResources.Override = "オーバーライド";
                    StringsResources.EmptyFields = "空のフィールドがあります。";
                    StringsResources.OverrideNoSuccess = "オーバーライドが失敗しました。 詳細を確認して、もう一度試してください。";

                    //Main
                    StringsResources.Home = "ホーム";
                    StringsResources.ReportMenu = "レポート";
                    StringsResources.Timesheet = "タイムシート";
                    StringsResources.Activity = "活動";
                    StringsResources.Admin = "管理者";
                    StringsResources.Asset = "資産";
                    StringsResources.Departments = "部門";
                    StringsResources.Roles = "役割";
                    StringsResources.Users = "ユーザー";
                    StringsResources.Sites = "サイト";
                    StringsResources.Permissions = "サイトの許可";
                    StringsResources.Settings = "設定";
                    StringsResources.UseCheckout = "チェックアウトを使用してセッションを終了し、ログイン ページに戻ります。";
                    StringsResources.ActionInvalid = "アクションが無効です!";
                    StringsResources.LogoutConfirm = "ログアウトしてもよろしいですか?";
                    StringsResources.Logout = "ログアウト";
                    StringsResources.Idle = "アイドル状態";
                    StringsResources.Active = "アクティブ";
                    StringsResources.Break = "休憩";
                    StringsResources.InBreak = "休憩中";
                    StringsResources.Lunch = "ランチ";
                    StringsResources.InLunch = "ランチ中";
                    StringsResources.Overbreak = "オーバーブレイク";
                    StringsResources.Unauthorized = "無許可";

                    //Home
                    StringsResources.Status = "ステータス";
                    StringsResources.Breaks = "休憩";
                    StringsResources.TodaySummary = "今日のまとめ";
                    StringsResources.Minutes = "分";
                    StringsResources.Break1End = "休憩1を終了しますか？";
                    StringsResources.LunchStart = "休憩1は無効になります 続行しますか？";
                    StringsResources.LunchEnd = "昼食を終了しますか？";
                    StringsResources.Break2Start = "休憩1と昼食は無効になります。続行しますか？";
                    StringsResources.Break2End = "休憩2を終了しますか？";

                    //Timesheets
                    StringsResources.PCTag = "PC タグ";
                    StringsResources.Department = "部門";
                    StringsResources.Date = "年月日";
                    StringsResources.Summary = "まとめ";
                    StringsResources.TimeInOut = "タイムインとアウト";
                    StringsResources.BreakInOut = "休憩インとアウト";
                    StringsResources.Total = "トタル";
                    StringsResources.Filter = "フィルター";
                    StringsResources.Print = "プリント";
                    StringsResources.DateEndCheck = "終了日を開始日より前にすることはできません。";
                    StringsResources.SelectAsset = "対象のPCタグを選択してください。";
                    StringsResources.StartDate = "開始日";
                    StringsResources.EndDate = "終了日";
                    StringsResources.To = "ー";

                    // Activity
                    StringsResources.SelectActivity = "アクティビティを選択してください。";

                    //Activity
                    StringsResources.AddAsset = "アセットの追加";
                    StringsResources.EditAsset = "アセットの編集";
                    StringsResources.No = "番号";
                    StringsResources.Description = "説明";
                    StringsResources.Save = "保存";
                    StringsResources.EnterAsset = "PCタグを入力してください。";

                    //Department
                    StringsResources.AddDepartment = "部門の追加";
                    StringsResources.EditDepartment = "部門の編集";
                    StringsResources.EnterDepartment = "部門名を入力してください。";

                    //Role
                    StringsResources.Role = "役割";
                    StringsResources.AddRole = "役割を追加";
                    StringsResources.EditRole = "役割の編集";
                    StringsResources.RoleName = "役割名";
                    StringsResources.CanOverride = "オーバーライドできます";
                    StringsResources.SitePermissions = "サイトの許可";
                    StringsResources.EnterRole = "役割名を入力してください。";

                    //User
                    StringsResources.AddUser = "ユーザーを追加";
                    StringsResources.EditUser = "ユーザーの編集";
                    StringsResources.EmployeeID = "従業員ID";
                    StringsResources.FamilyName = "苗字";
                    StringsResources.FirstName = "名";
                    StringsResources.MiddleName = "ミドルネーム";
                    StringsResources.Reset = "リセット";
                    StringsResources.PasswordReset = "パスワードのリセット";
                    StringsResources.PasswordResetOK = "パスワードのリセットが成功しました。";
                    StringsResources.PasswordResetNG = "パスワードのリセットに失敗しました。";

                    //Site
                    StringsResources.SiteName = "サイト名";
                    StringsResources.AddSite = "サイトを追加";
                    StringsResources.EditSite = "サイトの編集";
                    StringsResources.EnterSiteName = "サイト名を入力してください。";

                    //Site Permissions
                    StringsResources.Site = "サイト";
                    StringsResources.BatchUpdate = "バッチアップデート";
                    StringsResources.UserSitePermission = "ユーザーサイトの権限";
                    StringsResources.EnterSiteName = "部門を選択してください。";

                    //Settings
                    StringsResources.Change = "変化";
                    StringsResources.Password = "パスワード";
                    StringsResources.OldPassword = "以前のパスワード";
                    StringsResources.NewPassword = "新しいパスワード";
                    StringsResources.ConfirmPassword = "繰り返しパスワード";
                    StringsResources.PasswordRequirement = "パスワードは 8 ～ 16 文字の英数字である必要があります。";
                    StringsResources.OldPasswordInvalid = "古いパスワードは無効です。";
                    StringsResources.NewPasswordInvalid = "新しいパスワードが無効です。.";
                    StringsResources.ConfirmPasswordInvalid = "繰り返しパスワードが無効です";
                    StringsResources.PasswordNotMatch = "新しいパスワードが一致しません。";
                    StringsResources.PasswordChangeOK = "パスワードが更新されました。";
                    StringsResources.PasswordChangeNG = "パスワードが更新されていません。";
                    StringsResources.OK = "オーケー";
                    StringsResources.Cancel = "キャンセル";
                    StringsResources.Profile = "プロフィール";
                    StringsResources.Edit = "編集";
                    StringsResources.FamilyNameInvalid = "苗字は空白です。";
                    StringsResources.FirstNameInvalid = "名は空白です。";
                    StringsResources.ProfileUpdateOK = "プロフィール更新。";
                    StringsResources.ProfileUpdateNG = "プロフィールは更新されていません。";
                    StringsResources.Language = "言語";
                    StringsResources.English = "英語";
                    StringsResources.Japanese = "日本語";
                    break;

                case "English":
                default:
                    //Login
                    StringsResources.Login = "Login";
                    StringsResources.Shutdown = "Shutdown";
                    StringsResources.Restart = "Restart";
                    StringsResources.SyncShutdown = "Sync and shutdown";
                    StringsResources.SyncRestart = "Sync and restart";
                    StringsResources.InvalidUserorPassword = "Invalid PC Tag or Password";
                    StringsResources.NoServerConnection = "Server connection error.";
                    StringsResources.SyncInProgress = "Offline data sync in progress.";

                    //Override
                    StringsResources.SystemOverride = "System Override";
                    StringsResources.Override = "Override";
                    StringsResources.EmptyFields = "There are empty fields.";
                    StringsResources.OverrideNoSuccess = "Override unsuccessful. Please check details and try again.";

                    //Main
                    StringsResources.Home = "Home";
                    StringsResources.ReportMenu = "Reports";
                    StringsResources.Timesheet = "Timesheets";
                    StringsResources.Activity = "Activity";
                    StringsResources.Admin = "Admin";
                    StringsResources.Asset = "Assets";
                    StringsResources.Departments = "Departments";
                    StringsResources.Roles = "Roles";
                    StringsResources.Users = "Users";
                    StringsResources.Sites = "Sites";
                    StringsResources.Permissions = "Permissions";
                    StringsResources.Settings = "Settings";
                    StringsResources.UseCheckout = "Use checkout to end session and return to login page.";
                    StringsResources.ActionInvalid = "Action Invalid!";
                    StringsResources.LogoutConfirm = "Are you sure you want to logout?";
                    StringsResources.Logout = "Logout";
                    StringsResources.Idle = "Idle";
                    StringsResources.Active = "Active";
                    StringsResources.Break = "Break";
                    StringsResources.InBreak = "Break";
                    StringsResources.Lunch = "Lunch";
                    StringsResources.InLunch = "Lunch";
                    StringsResources.Overbreak = "Over Break";
                    StringsResources.Unauthorized = "Unauthorized";

                    //Home
                    StringsResources.Status = "Status";
                    StringsResources.Breaks = "Breaks";
                    StringsResources.TodaySummary = "Today's Summary";
                    StringsResources.Minutes = "Minutes";
                    StringsResources.Break1End = "Ending Break 1. Proceed?";
                    StringsResources.LunchStart = "Break 1 will be voided. Proceed?";
                    StringsResources.LunchEnd = "Ending Lunch break. Proceed?";
                    StringsResources.Break2Start = "Break 1 and Lunch will be voided. Proceed?";
                    StringsResources.Break2End = "Ending Break 2. Proceed?";

                    //Timesheet
                    StringsResources.PCTag = "PC Tag";
                    StringsResources.Department = "Department";
                    StringsResources.Date = "Date";
                    StringsResources.Summary = "Summary";
                    StringsResources.TimeInOut = "Time in and out";
                    StringsResources.BreakInOut = "Break in and out";
                    StringsResources.Total = "Total";
                    StringsResources.Filter = "Filter";
                    StringsResources.Print = "Print";
                    StringsResources.DateEndCheck = "End Date cannot be before Start Date.";
                    StringsResources.SelectAsset = "Please select target PC Tag.";
                    StringsResources.StartDate = "Start Date";
                    StringsResources.EndDate = "End Date";
                    StringsResources.To = "to";

                    //Activity
                    StringsResources.SelectActivity = "Please select target Activity.";

                    //Activity
                    StringsResources.AddAsset = "Add Asset";
                    StringsResources.EditAsset = "Edit Asset";
                    StringsResources.No = "No.";
                    StringsResources.Description = "Description";
                    StringsResources.Save = "Save";
                    StringsResources.EnterAsset = "Please enter PC Tag.";

                    //Department
                    StringsResources.AddDepartment = "Add Department";
                    StringsResources.EditDepartment = "Edit Department";
                    StringsResources.EnterDepartment = "Please enter Department.";

                    //Role
                    StringsResources.Role = "Role";
                    StringsResources.AddRole = "Add Role";
                    StringsResources.EditRole = "Edit Role";
                    StringsResources.RoleName = "Role Name";
                    StringsResources.CanOverride = "Can Override";
                    StringsResources.SitePermissions = "Site Permissions";
                    StringsResources.EnterRole = "Please enter role name.";

                    //User
                    StringsResources.AddUser = "Add User";
                    StringsResources.EditUser = "Edit User";
                    StringsResources.EmployeeID = "Employee ID";
                    StringsResources.FamilyName = "Family name";
                    StringsResources.FirstName = "First name";
                    StringsResources.MiddleName = "Middle name";
                    StringsResources.Reset = "Reset";
                    StringsResources.PasswordReset = "Password Reset";
                    StringsResources.PasswordResetOK = "Password reset successful!";
                    StringsResources.PasswordResetNG = "Password reset unsuccessful!";

                    //Site
                    StringsResources.SiteName = "Site Name";
                    StringsResources.AddSite = "Add Site";
                    StringsResources.EditSite = "Edit Site";
                    StringsResources.EnterSiteName = "Please enter site name.";

                    //Site Permissions
                    StringsResources.Site = "Site";
                    StringsResources.BatchUpdate = "Batch Update";
                    StringsResources.UserSitePermission = "User Site Permissions";
                    StringsResources.EnterSiteName = "Please select a department.";

                    //Settings
                    StringsResources.Change = "Change";
                    StringsResources.Password = "Password";
                    StringsResources.OldPassword = "Old Password";
                    StringsResources.NewPassword = "New Password";
                    StringsResources.ConfirmPassword = "Confirm Password";
                    StringsResources.PasswordRequirement = "Password must be alphanumeric and 8 - 16 characters long";
                    StringsResources.OldPasswordInvalid = "Old Password is invalid.";
                    StringsResources.NewPasswordInvalid = "New Password is invalid.";
                    StringsResources.ConfirmPasswordInvalid = "Confirm Password is invalid.";
                    StringsResources.PasswordNotMatch = "New Passwords does not match.";
                    StringsResources.PasswordChangeOK = "Password updated.";
                    StringsResources.PasswordChangeNG = "Password not updated.";
                    StringsResources.OK = "OK";
                    StringsResources.Cancel = "Cancel";
                    StringsResources.Profile = "Profile";
                    StringsResources.Edit = "Edit";
                    StringsResources.FamilyNameInvalid = "Family name is blank.";
                    StringsResources.FirstNameInvalid = "First name is blank.";
                    StringsResources.ProfileUpdateOK = "Profile updated.";
                    StringsResources.ProfileUpdateNG = "Profile not updated.";
                    StringsResources.Language = "Language";
                    StringsResources.English = "English";
                    StringsResources.Japanese = "Japanese";
                    //break;

                    //default: 
                    break;
            }
        }
    }
}
