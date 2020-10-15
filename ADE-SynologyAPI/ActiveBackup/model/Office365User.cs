using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{

    public class Office365User
    {
        public string display_name { get; set; }
        public string task_name { get; set; }
        public double usage_percentage { get; set; }
        public object usage_total { get; set; }
    }
}
