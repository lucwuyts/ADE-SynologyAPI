using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.ActiveBackup.model
{
    public class BusinessTaskResult
    {
        public string api { get; set; }
        public BusinessTaskData2 data { get; set; }
        public string method { get; set; }
        public bool success { get; set; }
        public Int64 version { get; set; }
    }
}
