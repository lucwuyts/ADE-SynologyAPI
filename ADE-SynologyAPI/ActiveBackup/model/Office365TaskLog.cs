using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class Office365TaskLog
    {
        public Int64 backup_policy { get; set; }
        public Int64 error_code { get; set; }
        public Int64 last_execution_time { get; set; }
        public Int64 start_run_time { get; set; }
        public Int64 status { get; set; }
        public Int64 task_execution_id { get; set; }
        public Int64 task_id { get; set; }
        public string task_name { get; set; }
        public Int64 task_type { get; set; }
        public Int64 total_archive_mail_count { get; set; }
        public Int64 total_calendar_count { get; set; }
        public Int64 total_contact_count { get; set; }
        public Int64 total_drive_count { get; set; }
        public Int64 total_mail_count { get; set; }
        public Int64 total_site_count { get; set; }
        public Int64 transfered_amount { get; set; }
        public string user_id { get; set; }
    }
}
