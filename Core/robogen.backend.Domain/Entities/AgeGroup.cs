using robogen.backend.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Domain.Entities
{
    public class AgeGroup: BaseEntity
    {
        public string Name { get; set; }
        public string Key { get; set; }
    }
}
