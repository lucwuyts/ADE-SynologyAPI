using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.CloudSync.model
{
    public class CloudSyncData
    {
        public List<CloudSyncConn> conn { get; set; }
        public bool is_admin_mode { get; set; }
        public bool is_pause { get; set; }
        public CloudSyncNotification notification { get; set; }
        public Int64 total { get; set; }
        public string tray_status { get; set; }
    }
}
