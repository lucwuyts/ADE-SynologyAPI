using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTaskLastResult
    {
        public Int64 backup_type { get; set; }
        public string detail_path { get; set; }
        public Int64 error_count { get; set; }
        public Int64 job_action { get; set; }
        public Int64 none_count { get; set; }
        public Int64 result_id { get; set; }
        public Int64 status { get; set; }
        public Int64 success_count { get; set; }
        public BusinessTaskConfig task_config { get; set; }
        public Int64 task_id { get; set; }
        public string task_name { get; set; }
        public Int64 time_end { get; set; }
        public Int64 time_start { get; set; }
        public Int64 transfered_bytes { get; set; }
        public Int64 warning_count { get; set; }
    }
}
