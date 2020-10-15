using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTaskRetentionPolicy
    {
        public string gfs_days { get; set; }
        public string gfs_months { get; set; }
        public string gfs_weeks { get; set; }
        public string gfs_years { get; set; }
        public bool keep_all { get; set; }
        public string keep_days { get; set; }
        public string keep_versions { get; set; }
    }
}
