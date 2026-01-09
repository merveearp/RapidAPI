using AutoMapper;
using Hotel.Entity.Concrete;
using Hotel.WEBUI.Dtos.AboutDtos;
using Hotel.WEBUI.Dtos.RoomDtos;
using Hotel.WEBUI.Dtos.ServiceDtos;
using Hotel.WEBUI.Dtos.SubscribeDtos;
using Hotel.WEBUI.Dtos.UserDtos;

namespace Hotel.WEBUI.Mappings
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<RegisterUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
           
        }
    }
}
