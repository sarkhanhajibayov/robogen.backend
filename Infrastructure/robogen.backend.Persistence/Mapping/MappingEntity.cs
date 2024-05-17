using AutoMapper;
using robogen.backend.Domain.Entities;
using robogen.backend.Persistence.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robogen.backend.Persistence.Mapping
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.ThemeName, opt => opt.MapFrom(src => src.Theme.Name))
                .ForMember(dest => dest.SerieName, opt => opt.MapFrom(src => src.Serie.Name))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.Name))
                .ForMember(dest => dest.AgeGroup, opt => opt.MapFrom(src => src.AgeGroup.Name))
                .ReverseMap();
            CreateMap<Product, ProductWriteDTO>().ReverseMap(); ;
        }
    }
}
