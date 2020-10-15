using ADE_SynologyAPI.CloudSync.model;
using SynologyClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.CloudSync
{

    /// <summary>
    /// Did not use SynologyBaseApi as base since i didn't want to change visibility of _session
    /// </summary>
    public class SynologyCloudSyncApi
    {
        private readonly ISynologySession _session;

        public SynologyCloudSyncApi(ISynologySession session)
        {
            if (session == null)
                throw new ArgumentNullException("session");
            _session = session;

            if (string.IsNullOrEmpty(_session.sid))
                throw new SynologyClientException("Session Id is empty");
        }




        public CloudSyncData GetConnList()
        {
            var proc = new FuncProcessor<GetResponse<CloudSyncData>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.CloudSync",
                version = 1,
                method = "list_conn",
                node = "module_root",
                group_by = "group_by_user",
                is_tray = false
            });
            var obj = proc.Run();
            return obj.data as CloudSyncData;
        }



        public GetResponse<CloudSyncSessList> GetSessList(Int64 connId)
        {

            var proc = new FuncProcessor<GetResponse<CloudSyncSessList>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.CloudSync",
                version = 1,
                method = "list_sess",
                connection_id = connId
            });
            return proc.Run();            
        }

    }
}
