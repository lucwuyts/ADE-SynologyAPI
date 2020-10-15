using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class BusinessActivityLog
    {
        public Int64 backup_type { get; set; }
        public Int64 device_id { get; set; }
        public string device_name { get; set; }
        public Int64 error_code { get; set; }
        public Int64 log_id { get; set; }
        public Int64 log_level { get; set; }
        public Int64 log_time { get; set; }
        public Int64 log_type { get; set; }
        public BusinessOtherParams other_params { get; set; }
        public Int64 result_id { get; set; }
        public Int64 task_id { get; set; }
        public string task_name { get; set; }
        public Int64 user_id { get; set; }
        public string user_name { get; set; }
    }
}
