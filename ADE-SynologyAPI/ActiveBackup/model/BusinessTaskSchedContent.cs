using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTaskSchedContent
    {
        public string backup_window { get; set; }
        public bool enable_backup_window { get; set; }
        public bool is_continuous_paused { get; set; }
        public bool log_off { get; set; }
        public string period_base { get; set; }
        public Int64 period_length { get; set; }
        public Int64 repeat_hour { get; set; }
        public string repeat_type { get; set; }
        public Int64 run_hour { get; set; }
        public Int64 run_min { get; set; }
        public List<Int64> run_weekday { get; set; }
        public Int64 schedule_setting_type { get; set; }
        public bool screen_lock { get; set; }
        public Int64 start_day { get; set; }
        public Int64 start_month { get; set; }
        public Int64 start_year { get; set; }
        public bool startup { get; set; }
    }
}
