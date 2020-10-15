using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.CloudSync.model
{
    public class CloudSyncSess
    {
        public string cloud_type_str { get; set; }
        public Int64 conn_id { get; set; }
        public Int64 error { get; set; }
        public string error_desc { get; set; }
        public Int64 link_status { get; set; }
        public string local_sync_path { get; set; }
        public string remote_folder_id { get; set; }
        public string remote_sync_path { get; set; }
        public Int64 sess_id { get; set; }
        public string sync_status { get; set; }
    }
}
