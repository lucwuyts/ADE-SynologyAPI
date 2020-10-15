using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class Statistics
    {
        public double compress_ratio { get; set; }
        public object dedup_size { get; set; }
        public Summary summary { get; set; }
        public long target_increase_size { get; set; }
    }
}
