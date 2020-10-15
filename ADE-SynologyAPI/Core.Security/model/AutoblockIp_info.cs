using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.Core.Security.model
{
    public class AutoblockIp_info
    {
        public string country { get; set; }
        public Int64 expire_date { get; set; }
        public string expire_formated_date { get; set; }
        public string ip { get; set; }
        public Int64 record_date { get; set; }
        public string record_formated_date { get; set; }

    }
}
