using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient.ActiveBackup.model
{
    public class ServiceUsage
    {
        public Int64 service_type { get; set; }
        public long storage_usage { get; set; }
        public Int64? archive_mail_used_storage { get; set; }
        public long? mail_used_storage { get; set; }
    }
}
