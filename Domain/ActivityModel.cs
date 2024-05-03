using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class ActivityModel
    {

        ActivityDAO activityDAO = new ActivityDAO();

        public void RecordActivityIn(string username, int log_type, string date_in, bool isOnline)
        {
            activityDAO.recordIn(username, log_type, date_in, isOnline);
        }

        public void RecordActivityOut(string username, int log_type, string date_in, string date_out, float time_elapsed, bool isOnline)
        {
            activityDAO.recordOut(username, log_type, date_in, date_out, time_elapsed, isOnline);
        }

        public string CreateActivityMinutes(string user_id, string shiftDate, bool isOnline)
        {
            return activityDAO.createMinutes(user_id, shiftDate, isOnline);
        }

        public void RecordActivityMinutes(string id, string user_id, string shiftDate, int activity_type, float minutes, bool isOnline)
        {
            activityDAO.recordMinutes(id, user_id, shiftDate, activity_type, minutes, isOnline);
        }

        public bool emp_activities_Sync()
        {
            bool result = false;
            ArrayList arr_Local = new ArrayList();

            arr_Local = activityDAO.getLocalActivities();
            result = activityDAO.empActivitiesSync(arr_Local);

            if (result)
            {
                activityDAO.resetLocalEmpActivities();
            }

            return result;
        }

        public bool Sync_emp_activities()
        {
            bool result = false;
            ArrayList arr_Local = new ArrayList();
            ArrayList arr_Server = new ArrayList();
            ArrayList arr_Diff = new ArrayList();
            string user_id = "";
            string start_date = "";
            string end_date = "";

            user_id = UserLogin.user_id;

            arr_Local = activityDAO.getLocalActivitiesSummary();
            if (arr_Local.Count >= 1)
            {
                List<string> arrLocalRecFirst = new List<string>();
                arrLocalRecFirst = (List<string>)arr_Local[0];
                user_id = arrLocalRecFirst[1].ToString();
                start_date = arrLocalRecFirst[2].ToString();

                List<string> arrLocalRecLast = new List<string>();
                arrLocalRecLast = (List<string>)arr_Local[arr_Local.Count - 1];
                end_date = arrLocalRecLast[3].ToString();
            }
            else
            {
                return result;
            }

            arr_Server = activityDAO.getServerActivities(user_id, start_date, end_date);
            if (arr_Server.Count <= 0)
            {
                return result;
            }

            for (int loc_ctr = 0; loc_ctr < arr_Local.Count; loc_ctr++)
            {
                List<string> arrLocalActiveRec = new List<string>();
                arrLocalActiveRec = (List<string>)arr_Local[loc_ctr];
                bool noMatch = true;

                for (int ser_ctr = 0; ser_ctr < arr_Server.Count; ser_ctr++)
                {
                    List<string> arrServerActiveRec = new List<string>();
                    arrServerActiveRec = (List<string>)arr_Server[ser_ctr];

                    if (String.Equals(arrLocalActiveRec[1].ToString(), arrServerActiveRec[1].ToString()) &&
                        String.Equals(arrLocalActiveRec[2].ToString(), arrServerActiveRec[2].ToString()) &&
                        String.Equals(arrLocalActiveRec[3].ToString(), arrServerActiveRec[3].ToString()) &&
                        String.Equals(arrLocalActiveRec[4].ToString(), arrServerActiveRec[4].ToString()) &&
                        String.Equals(arrLocalActiveRec[5].ToString(), arrServerActiveRec[5].ToString()) &&
                        String.Equals(arrLocalActiveRec[6].ToString(), arrServerActiveRec[6].ToString()))
                    {
                        noMatch = false;
                        break;
                    }
                }

                if (noMatch)
                {
                    arr_Diff.Add(arrLocalActiveRec);
                }
            }

            if(arr_Diff.Count > 0)
            {
                string values = "VALUES";
                for (int ctr = 0; ctr < arr_Diff.Count; ctr++)
                {
                    List<string> arrDiffActiveRec = new List<string>();
                    arrDiffActiveRec = (List<string>)arr_Diff[ctr];

                    string timeStart;
                    string timeEnd;

                    if (arrDiffActiveRec[3].ToString() == "")
                    {
                        timeStart = null;
                    }
                    else
                    {
                        timeStart = "'" + arrDiffActiveRec[3].ToString() + "'";
                    }

                    if (arrDiffActiveRec[4].ToString() == "")
                    {
                        timeEnd = null;
                    }
                    else
                    {
                        timeEnd = "'" + arrDiffActiveRec[4].ToString() + "'";
                    }

                    string record = "(" + arrDiffActiveRec[1].ToString() + "," + arrDiffActiveRec[2].ToString() + "," + timeStart + "," + timeEnd + "," + arrDiffActiveRec[5].ToString() + ")";
                    values += record;

                    if (ctr < arr_Diff.Count - 1)
                    {
                        values += ",";
                    }
                }

                result = activityDAO.syncEmpActivities(values);

                if (result)
                {
                    activityDAO.resetLocalEmpActivities();
                }
            }

            return result;
        }

        public bool emp_activities_summary_Sync()
        {
            bool result = false;
            ArrayList arr_Local = new ArrayList();

            arr_Local = activityDAO.getLocalActivitiesSummary();
            result = activityDAO.empActivitiesSummarySync(arr_Local);

            if (result)
            {
                activityDAO.resetLocalEmpActivitiesSummary();
            }

            return result;
        }

    }
}
