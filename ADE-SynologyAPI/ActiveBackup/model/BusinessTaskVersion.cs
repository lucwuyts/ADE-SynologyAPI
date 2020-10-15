using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTaskVersion
    {
        public Int64 data_format { get; set; }
        public string folder_name { get; set; }
        public bool locked { get; set; }
        public Int64 removable { get; set; }
        public Int64 status { get; set; }
        public Int64 time_end { get; set; }
        public Int64 time_start { get; set; }
        public Int64 used_size { get; set; }
        public Int64 version_id { get; set; }
    }
}
