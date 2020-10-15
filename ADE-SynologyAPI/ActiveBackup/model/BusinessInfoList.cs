using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class BusinessInfoList
    {
        public Int64 count { get; set; }
        public Int64 status { get; set; }
        public Int64 time_end { get; set; }
        public Int64 time_start { get; set; }
    }
}
