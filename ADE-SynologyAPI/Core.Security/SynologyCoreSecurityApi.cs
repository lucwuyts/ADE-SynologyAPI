using ADE_SynologyAPI.Core.Security.model;
using SynologyClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADE_SynologyAPI.Core.Security
{
    /// <summary>
    /// Did not use SynologyBaseApi as base since i didn't want to change visibility of _session
    /// </summary>
    public class SynologyCoreSecurityApi
    {
        private readonly ISynologySession _session;

        public SynologyCoreSecurityApi(ISynologySession session)
        {
            if (session == null)
                throw new ArgumentNullException("session");
            _session = session;

            if (string.IsNullOrEmpty(_session.sid))
                throw new SynologyClientException("Session Id is empty");
        }


        /// <summary>
        /// Get list with blocked IP addresses
        /// </summary>
        /// <param name="_limit"></param>
        /// <returns></returns>
        public  GetResponse<AutoblockIpDate> GetBlockedList( Int64 _limit = 250 )
        {
            var proc = new FuncProcessor<GetResponse<AutoblockIpDate>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.Core.Security.AutoBlock.Rules",
                version = 1,
                method = "list",
                limit = _limit,
                type = "deny"
            });
            return proc.Run();            
        }


        public bool AddDenyIp( List<string> ipList)
        {
            if (ipList.Count == 0)
                return false;

            var iptoblock = new StringBuilder();
            var komma = "";
            foreach( var ip in ipList)
            {
                iptoblock.Append($"{komma}\"{ip}\"");
                komma = ",";
            }
            var proc = new FuncProcessor<GetResponse<AutoblockIpDate>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.Core.Security.AutoBlock.Rules",
                version = 1,
                block_days = 0,
                overwrite = "true",
                ip = $"[ {iptoblock} ]",
                method = "create",                
                type = "deny"                
            }); 
            var retval = proc.Run();
            return retval.success;
        }

        public bool RemoveDenyIp(List<string> ipList)
        {
            if (ipList.Count == 0)
                return false;

            var iptoblock = new StringBuilder();
            var komma = "";
            foreach (var ip in ipList)
            {
                iptoblock.Append($"{komma}\"{ip}\"");
                komma = ",";
            }
            var proc = new FuncProcessor<GetResponse<AutoblockIpDate>>("/entry.cgi", _session.sid, new
            {
                api = "SYNO.Core.Security.AutoBlock.Rules",
                version = 1,
                block_days = 0,
                overwrite = "true",
                ip = $"[ {iptoblock} ]",
                method = "delete",
                type = "deny"
            });
            var retval = proc.Run();
            return retval.success;
        }

    }
}
