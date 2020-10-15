
using ADE_SynologyAPI.HyperBackup.model;
using SynologyClient;
using System;

namespace ADE_SynologyAPI.ActiveBackup
{
    /// <summary>
    /// Did not use SynologyBaseApi as base since i didn't want to change visibility of _session
    /// </summary>
    public class SynologyHyperBackupApi 
    {
        private readonly ISynologySession _session;

        public SynologyHyperBackupApi(ISynologySession session)         
        {
            if (session == null)
                throw new ArgumentNullException("session");
            _session = session;

            if (string.IsNullOrEmpty(_session.sid))
                throw new SynologyClientException("Session Id is empty");
        }


        public GetResponse<DataTaskList> GetTaskList()
        {
            var proc = new FuncProcessor<GetResponse<DataTaskList>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.Backup.Task",
                version = 1,
                method = "list",
                node = "module_root",
                sort_by = "name",
                additional =  ""  
                // DSM uses this to request extra data in 1 query.
                //"[\"last_bkp_time\",\"last_bkp_result\",\"get_source\",\"is_modified\",\"progress_title_type\"]"
            });
            return proc.Run();
        }




        public GetResponse<ListVersionInfoList> GetVersions(Int64 taskId,string targetId, Int64 repoId, int _offset = 0, Int64 _limit = 50)
        {
            var proc = new FuncProcessor<GetResponse<ListVersionInfoList>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.Backup.Version",
                version = 2,
                method = "list",
                offset = _offset,
                limit = _limit,
                filter_name = "available",
                task_id= taskId,
                repo_id = repoId,
                target_id = targetId,
                additional = "[\"version_operate_property\"]",
                account_meta = "{\"scheduleRule\":\"unlimited\",\"versionDelete\":\"enable\",\"versionLock\":\"enable\",\"versionRotation\":\"custom\",\"statisticsDisplay\":\"all\",\"spaceUsage\":\"target\",\"quota\":0,\"expireTime\":0,\"planGroup\":\"\",\"planPeriod\":\"\",\"account\":\"\",\"isFresh\":false}"
            }) ;
            return proc.Run();
        }

       


    }
}
