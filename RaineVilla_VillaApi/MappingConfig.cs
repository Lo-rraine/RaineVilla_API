using AutoMapper;
using RaineVilla_VillaApi.Models;
using RaineVilla_VillaApi.Models.Dto;

namespace RaineVilla_VillaApi
{
    public class MappingConfig : Profile 
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();
        }
    }
}
