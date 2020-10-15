using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{

    public class Office365ActiveBackupTask
    {
        public Int64 archive_mail_used_storage { get; set; }
        public Int64 backup_policy { get; set; }
        public Int64 calendar_used_storage { get; set; }
        public Int64 contact_used_storage { get; set; }
        public Int64 drive_used_storage { get; set; }
        public Int64 duration { get; set; }
        public Int64 enable_archive_mail { get; set; }
        public Int64 enable_calendar { get; set; }
        public Int64 enable_contact { get; set; }
        public Int64 enable_drive { get; set; }
        public Int64 enable_mail { get; set; }
        public bool enable_schedule { get; set; }
        public Int64 enable_site { get; set; }
        public Int64 error_archive_mail { get; set; }
        public Int64 error_calendar { get; set; }
        public Int64 error_contact { get; set; }
        public Int64 error_drive { get; set; }
        public Int64 error_mail { get; set; }
        public Int64 error_site { get; set; }
        public Int64 job_id { get; set; }
        public Int64 last_execution_time { get; set; }
        public long mail_used_storage { get; set; }
        public Int64 processed_archive_mail { get; set; }
        public Int64 processed_calendar { get; set; }
        public Int64 processed_contact { get; set; }
        public Int64 processed_drive { get; set; }
        public Int64 processed_mail { get; set; }
        public Int64 processed_site { get; set; }
        public List<object> progress_list { get; set; }
        public Int64 region { get; set; }
        public Schedule schedule { get; set; }
        public Int64 schedule_id { get; set; }
        public Int64 site_used_storage { get; set; }
        public Int64 status { get; set; }
        public Int64 status_archive_mail { get; set; }
        public Int64 status_calendar { get; set; }
        public Int64 status_contact { get; set; }
        public Int64 status_drive { get; set; }
        public Int64 status_mail { get; set; }
        public Int64 status_site { get; set; }
        public Int64 task_id { get; set; }
        public string task_name { get; set; }
        public Int64 task_status { get; set; }
        public Int64 transferred_size_archive_mail { get; set; }
        public Int64 transferred_size_calendar { get; set; }
        public Int64 transferred_size_contact { get; set; }
        public Int64 transferred_size_drive { get; set; }
        public Int64 transferred_size_mail { get; set; }
        public Int64 transferred_size_site { get; set; }
        public Int64 union_enable_mail { get; set; }
        public Int64 warning_archive_mail { get; set; }
        public Int64 warning_calendar { get; set; }
        public Int64 warning_contact { get; set; }
        public Int64 warning_drive { get; set; }
        public Int64 warning_mail { get; set; }
        public Int64 warning_site { get; set; }
    }
}
