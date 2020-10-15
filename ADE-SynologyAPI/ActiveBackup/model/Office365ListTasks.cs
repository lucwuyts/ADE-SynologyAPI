using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{

    public class Office365ListTasks
    {
        public List<Office365EventLog> event_log { get; set; }
        public List<ServiceUsage> service_usage { get; set; }
        public List<Office365ActiveBackupTask> tasks { get; set; }
        public List<Office365User> users { get; set; }
    }
}
