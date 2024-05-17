using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence.FilterModels
{
    public class ProductFilterVM 
    {
        public string? Name { get; set; }
        public int? SerieId { get; set; }
        public int? ThemeId { get; set; }
        public int? GenderId { get; set; }
        public int? AgeGroupId { get; set; }
    }
}
