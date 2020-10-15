using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class DataTaskList
    {
        public bool is_data_restoring { get; set; }
        public bool is_downloading { get; set; }
        public bool is_lun_restoring { get; set; }
        public bool is_restoring { get; set; }
        public bool is_snapshot_restoring { get; set; }
        public List<TaskList> task_list { get; set; }
        public Int64 total { get; set; }
    }
}
