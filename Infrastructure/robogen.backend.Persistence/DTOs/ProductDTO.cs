using robogen.backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ThemeName { get; set; }
        public string? SerieName { get; set; }
        public string? AgeGroup { get; set; }
        public string? Gender { get; set; }
        public int? ThemeId { get; set; }
        public int? SerieId { get; set; }
        public int? AgeGroupId { get; set; }
        public int? GenderId { get; set; }
        public int BoxHeight { get; set; }
        public int BoxWidth { get; set; }
        public int BoxDiameter { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public string? ImageName { get; set; }
    }
}
