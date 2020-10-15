using ADE_SynologyAPI.ActiveBackup.model;
using SynologyClient.ActiveBackup.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup
{
    /// <summary>
    /// Did not use SynologyBaseApi as base since i didn't want to change visibility of _session
    /// </summary>
    public class SynologyActiveBackupApi 
    {
        private readonly ISynologySession _session;

        public SynologyActiveBackupApi(ISynologySession session)         
        {
            if (session == null)
                throw new ArgumentNullException("session");
            _session = session;

            if (string.IsNullOrEmpty(_session.sid))
                throw new SynologyClientException("Session Id is empty");
        }


        public GetResponse<Office365ListTasks> GetOffice365_ListTasks()
        {
            var proc = new FuncProcessor<GetResponse<Office365ListTasks>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackupOffice365",
                version = 1,
                method = "list_tasks"
            });
            return proc.Run();
        }


        public GetResponse<Office365ListTaskLog> GetOffice365_TaskLog(DateTime startTime, DateTime endTime , Int64 _offset = 0, Int64 _limit = 10000 )
        {
            var proc = new FuncProcessor<GetResponse<Office365ListTaskLog>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackupOffice365",
                version = 1,
                method = "list_task_logs",
                job_type = 0,
                start_run_time = GetUnixDateTimeSeconds(startTime),
                end_run_time = GetUnixDateTimeSeconds(endTime),
                transfered_size_from = 0,
                offset = _offset,
                limit = _limit
            });
            return proc.Run();
        }


        public GetResponse<Office365ListGeneralLog> GetOffice365_GeneralLog(Int64 _offset = 0 , Int64 _limit = 200 )
        {
            var proc = new FuncProcessor<GetResponse<Office365ListGeneralLog>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackupOffice365",
                version = 1,
                method = "get_general_log",
                offset = _offset,
                limit = _limit
            });
            return proc.Run();
        }




        /* Not working - version list is not filled
         
        public GetResponse<BusinessTaskData2> GetBusiness_TaskList(int TaskId, int _offset=0, int _limit=50)
        {
            // did not wanted to include/use a library for json conversion
            var openTag = "{";
            var closeTag = "}";
            var jsonFilter = $"{openTag}\"offset\":{_offset},\"limit\":{_limit},\"task_id\":{TaskId},\"data_formats\":[1,4]{closeTag}";

            var proc = new FuncProcessor<GetResponse<BusinessTaskData2>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackup.Task",
                version = 1,
                method = "list",
                offset = _offset,
                limit = _limit,
                load_status = "true",
                load_result = "true",
                load_devices = "true",
                load_verify_status = "false",
                filter = jsonFilter
            });
            return proc.Run();
        }

        */

       
         
        public GetResponse<BusinessTaskData2> GetBusiness_TaskList( Enum_ActiveBackup_BackupType backupType)
        {
            // did not wanted to include/use a library for json conversion
            var openTag = "{";
            var closeTag = "}";
            var jsonFilter = $"{openTag}\"backup_type\":{(int)backupType}{closeTag}";

            var proc = new FuncProcessor<GetResponse<BusinessTaskData2>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackup.Task",                
                version = 1,
                method = "list",
                load_status = "true",
                load_result = "true",
                load_devices = "true",
                filter = jsonFilter
            }) ;
            return proc.Run();
        }
        

        public GetResponse<BusinessListActivityLog> GetBusiness_ActivityLog(Int64 _offset = 0, Int64 _limit = 200 )
        {
            var proc = new FuncProcessor<GetResponse<BusinessListActivityLog>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackup.Log",
                version = 1,
                method = "list_log",
                offset = _offset,
                limit = _limit
            });
            return proc.Run();
        }

        public GetResponse<BusinessListActivityLog> GetBusiness_ActivityLogByTaskId(Int64 TaskId, Int64 _offset = 0, Int64 _limit = 200)
        {
            var proc = new FuncProcessor<GetResponse<BusinessListActivityLog>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackup.Log",
                version = 1,
                method = "list_log",
                offset = _offset,
                limit = _limit,
                task_id = TaskId
            });
            return proc.Run();
        }

        public GetResponse<BusinessListInfoList> GetBusiness_InfoList( DateTime startTime, DateTime endTime )
        {   
            // did not wanted to include/use a library for json conversion
            var openTag = "{";
            var closeTag = "}";
            var jsonFilter = $"{openTag}\"time_start\":{GetUnixDateTimeSeconds(startTime)},\"time_end\":{GetUnixDateTimeSeconds(endTime)}{closeTag}";

            //var x = new { time_start = GetUnixDateTimeSeconds(startTime), time_end = GetUnixDateTimeSeconds(endTime) };
            //var jsonFilter = JsonConvert.SerializeObject(x);

            var proc = new FuncProcessor<GetResponse<BusinessListInfoList>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.ActiveBackup.Overview",
                version = 1,
                method = "list_result_status_summary",
                filter = jsonFilter 
            });
            return proc.Run();
        }


        int GetUnixDateTimeSeconds(DateTime dateTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (dateTime.ToUniversalTime() - epoch).TotalSeconds;
            return (int)unixDateTime;

            // Starting from .net 4.6
            // var tmp = new DateTimeOffset(dateTime);
            // return tmp.ToUnixTimeSeconds();
        }



    }
}
