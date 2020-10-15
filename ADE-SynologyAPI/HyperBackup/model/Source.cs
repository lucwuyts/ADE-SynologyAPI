using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class Source
    {
        public List<object> backup_apps { get; set; }
        public List<string> backup_shares { get; set; }
        public List<object> exclude_list { get; set; }
        public List<object> whitelist { get; set; }
    }
}
