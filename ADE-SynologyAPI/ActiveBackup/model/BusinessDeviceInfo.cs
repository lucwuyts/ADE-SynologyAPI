using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class BusinessDeviceInfo
    {
        public Int64 agentless_count { get; set; }
        public Int64 agentless_size { get; set; }
        public Int64 pc_count { get; set; }
        public long pc_size { get; set; }
        public Int64 server_count { get; set; }
        public Int64 server_size { get; set; }
        public Int64 vm_count { get; set; }
        public Int64 vm_size { get; set; }
    }
}
