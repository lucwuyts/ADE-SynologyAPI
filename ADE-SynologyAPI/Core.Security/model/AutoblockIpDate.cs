using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.Core.Security.model
{
    public class AutoblockIpDate
    {
        public List<AutoblockIp_info> ip_info { get; set; }
        public Int64 offset { get; set; }
        public Int64 total { get; set; }

    }
}
