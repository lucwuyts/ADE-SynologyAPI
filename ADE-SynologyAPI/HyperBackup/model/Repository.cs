using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class Repository
    {
        public string account { get; set; }
        public string dest { get; set; }
        public string name { get; set; }
        public Int64 port { get; set; }
        public string pwd { get; set; }
        public Int64 repo_id { get; set; }
        public string share { get; set; }
        public string target_type { get; set; }
        public string transfer_type { get; set; }
        public bool verify_cert { get; set; }
    }
}
