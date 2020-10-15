using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessDevice
    {
        public string agent_status { get; set; }
        public string agent_token { get; set; }
        public Int64 agentless_auth_policy { get; set; }
        public Int64 backup_type { get; set; }
        public Int64 create_time { get; set; }
        public Int64 device_id { get; set; }
        public string device_uuid { get; set; }
        public string host_ip { get; set; }
        public string host_name { get; set; }
        public Int64 host_port { get; set; }
        public string hypervisor_id { get; set; }
        public Int64 inventory_id { get; set; }
        public string login_password { get; set; }
        public Int64 login_time { get; set; }
        public string login_user { get; set; }
        public Int64 login_user_id { get; set; }
        public string os_name { get; set; }
        public Int64 task_count { get; set; }
        public string vm_moid_path { get; set; }
    }
}
