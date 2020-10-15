using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class BusinessOtherParams
    {
        public Int64 backup_type { get; set; }
        public Int64 device_id { get; set; }
        public string device_name { get; set; }
        public Int64 task_id { get; set; }
        public string task_name { get; set; }
        public Int64 user_id { get; set; }
        public string user_name { get; set; }
        public Int64? trigger_event { get; set; }
        public Int64? trigger_type { get; set; }
    }
}
