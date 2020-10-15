using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.CloudSync.model
{
    public class CloudSyncConn
    {
        public Int64 id { get; set; }
        public Int64 link_status { get; set; }
        public string status { get; set; }
        public string task_display_name { get; set; }
        public string task_name { get; set; }
        public string type { get; set; }
        public Int64 type_id { get; set; }
        public Int64 unfinished_files { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
    }
}
