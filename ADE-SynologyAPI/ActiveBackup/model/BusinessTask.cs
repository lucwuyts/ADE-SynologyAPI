using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTask
    {
        public string agentless_backup_path { get; set; }
        public Int64 agentless_backup_policy { get; set; }
        public bool agentless_enable_block_transfer { get; set; }
        public bool agentless_enable_dedup { get; set; }
        public bool agentless_enable_windows_vss { get; set; }
        public bool allow_manual_backup { get; set; }
        public bool backup_external { get; set; }
        public Int64 backup_type { get; set; }
        public Int64 bandwidth { get; set; }
        public Int64 block_reason { get; set; }
        public object block_tasks { get; set; }         // unknown type ???
        public Int64 cbt_enable_mode { get; set; }
        public Int64 connection_timeout { get; set; }
        public List<object> custom_volume { get; set; }
        public Int64 datastore_reserved_percentage { get; set; }
        public string dedup_path { get; set; }
        public Int64 device_count { get; set; }
        public List<BusinessDevice> devices { get; set; }
        public bool enable_app_aware_bkp { get; set; }
        public bool enable_compress_transfer { get; set; }
        public bool enable_datastore_aware { get; set; }
        public bool enable_dedup { get; set; }
        public bool enable_encrypt_transfer { get; set; }
        public bool enable_notify { get; set; }
        public bool enable_verification { get; set; }
        public BusinessTaskLastResult last_result { get; set; }
        public Int64 max_concurrent_devices { get; set; }
        public Int64 next_trigger_time { get; set; }
        public string repo_dir { get; set; }
        public BusinessTaskRetentionPolicy retention_policy { get; set; }
        public BusinessTaskSchedContent sched_content { get; set; }
        public Int64 sched_id { get; set; }
        public string share_name { get; set; }
        public Int64 source_type { get; set; }
        public Int64 storage_id { get; set; }
        public string target_dir { get; set; }
        public Int64 task_id { get; set; }
        public string task_name { get; set; }
        public string unikey { get; set; }
        public Int64 verification_policy { get; set; }
        public Int64 version_count { get; set; }
        public List<BusinessTaskVersion> versions { get; set; } 
    }
}
