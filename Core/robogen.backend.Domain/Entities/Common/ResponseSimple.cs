﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Domain.Entities.Common

{
    public class ResponseSimple
    {
        public StatusModel Status { get; set; }
        public string TraceID { get; set; }
    }
}
