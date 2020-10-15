using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class TaskList
    {
        public bool data_enc { get; set; }
        public string data_type { get; set; }
        public List<object> ext3ShareList { get; set; }
        public string name { get; set; }
        public Int64 repo_id { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public string target_id { get; set; }
        public string target_type { get; set; }
        public Int64 task_id { get; set; }
        public string transfer_type { get; set; }
        public string type { get; set; }
    }
}
