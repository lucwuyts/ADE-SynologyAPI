using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class BackupFilter
    {
        public List<object> exclude_list { get; set; }
        public List<object> whitelist { get; set; }
    }
}
