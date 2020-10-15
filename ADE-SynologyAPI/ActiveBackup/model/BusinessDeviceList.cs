using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class BusinessDeviceList
    {
        public Int64 device_id { get; set; }
        public string device_name { get; set; }
        public string task_name { get; set; }
        public Int64 time_end { get; set; }
    }
}
