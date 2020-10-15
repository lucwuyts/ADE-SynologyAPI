using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class VersionInfoList
    {
        public Int64 complete_time { get; set; }
        public bool has_history { get; set; }
        public bool locked { get; set; }
        public string modify { get; set; }
        public string name { get; set; }
        public bool permit_delete { get; set; }
        public Source source { get; set; }
        public Statistics statistics { get; set; }
        public string status { get; set; }
        public Int64 timestamp { get; set; }
        public string version_id { get; set; }
    }
}
