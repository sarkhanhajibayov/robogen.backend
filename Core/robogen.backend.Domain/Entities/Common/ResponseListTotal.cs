using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Domain.Entities.Common
{
    public class ResponseListTotal<T>
    {
        public StatusModel Status { get; set; }
        public ResponseTotal<T> Response { get; set; }
        public string TraceID { get; set; }
    }
}
