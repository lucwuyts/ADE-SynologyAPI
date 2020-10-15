using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTaskData2
    {
        public bool has_devices { get; set; }
        public bool has_hyperv_inventories { get; set; }
        public bool has_vmware_inventories { get; set; }
        public List<BusinessTask> tasks { get; set; }
        public Int64 total { get; set; }
    }
}
