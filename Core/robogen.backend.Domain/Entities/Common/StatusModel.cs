using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Domain.Entities.Common
{
    public class StatusModel
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string Action { get; set; }
    }
}
