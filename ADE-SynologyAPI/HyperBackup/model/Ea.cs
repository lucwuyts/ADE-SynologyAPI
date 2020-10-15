using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class Ea
    {
        public Int64 del_cnt { get; set; }
        public Int64 del_size { get; set; }
        public Int64 mod_cnt { get; set; }
        public Int64 mod_size { get; set; }
        public Int64 new_cnt { get; set; }
        public Int64 new_size { get; set; }
        public Int64 total_cnt { get; set; }
        public Int64 total_size { get; set; }
        public Int64 unch_cnt { get; set; }
        public Int64 unch_size { get; set; }
    }
}
