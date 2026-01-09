using AutoMapper;
using Hotel.DTO.DTOs.AboutDtos;
using Hotel.DTO.DTOs.RoomDtos;
using Hotel.DTO.DTOs.ServiceDtos;
using Hotel.DTO.DTOs.StaffDtos;
using Hotel.DTO.DTOs.SubscribeDtos;
using Hotel.DTO.DTOs.TestimonialDtos;
using Hotel.Entity.Concrete;

namespace Hotel.WEBAPI.Mapping
{
    public class AutoMapperConfig :Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<CreateRoomDto, Room>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            CreateMap<CreateStaffDto, Staff>().ReverseMap();

            CreateMap<ResultServiceDto , Service>().ReverseMap();
            CreateMap<UpdateServiceDto , Service>().ReverseMap();
            CreateMap<CreateServiceDto , Service>().ReverseMap();

            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();

        }
    }
}
