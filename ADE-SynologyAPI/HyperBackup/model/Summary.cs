using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.HyperBackup.model
{
    public class Summary
    {
        public App app { get; set; }
        public Ea ea { get; set; }
        public Share share { get; set; }
    }
}
