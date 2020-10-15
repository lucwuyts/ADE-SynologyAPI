using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class Office365EventLog
    {
        public string description { get; set; }
        public Int64 error_code { get; set; }
        public Int64 last_execution_time { get; set; }
        public Int64 log_type { get; set; }
        public Int64 task_execution_id { get; set; }
        public Int64 task_id { get; set; }
        public Int64 timestamp { get; set; }        
    }

}
