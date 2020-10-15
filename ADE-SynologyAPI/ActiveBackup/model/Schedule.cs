using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class Schedule
    {
        public string date { get; set; }
        public Int64 date_type { get; set; }
        public Int64 hour { get; set; }
        public Int64 last_work_hour { get; set; }
        public Int64 minute { get; set; }
        public Int64 repeat_date { get; set; }
        public Int64 repeat_hour { get; set; }
        public object repeat_hour_store_config { get; set; }
        public Int64 repeat_min { get; set; }
        public object repeat_min_store_config { get; set; }
        public string week_day { get; set; }
    }
}
