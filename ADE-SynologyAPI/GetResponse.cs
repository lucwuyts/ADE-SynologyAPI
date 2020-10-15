using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynologyClient
{
    public class GetResponse<T> : BaseSynologyResponse
    {
        public T data { get; set; }
    }
}
