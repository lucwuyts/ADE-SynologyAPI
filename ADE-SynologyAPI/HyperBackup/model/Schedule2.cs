using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class Schedule2
    {
        public string date { get; set; }
        public Int64 date_type { get; set; }
        public Int64 hour { get; set; }
        public Int64 last_work_hour { get; set; }
        public Int64 min { get; set; }
        public string next_trigger_time { get; set; }
        public Int64 repeat { get; set; }
        public Int64 repeat_hour { get; set; }
        public List<Int64> repeat_hour_store_config { get; set; }
        public Int64 repeat_min { get; set; }
        public List<object> repeat_min_store_config { get; set; }
        public string week_name { get; set; }
    }
}
