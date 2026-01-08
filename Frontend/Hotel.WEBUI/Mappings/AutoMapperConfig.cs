using AutoMapper;
using Hotel.Entity.Concrete;
using Hotel.WEBUI.Dtos.ServiceDtos;

namespace Hotel.WEBUI.Mappings
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
        }
    }
}
