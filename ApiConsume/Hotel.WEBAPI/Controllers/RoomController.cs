using AutoMapper;
using Hotel.Business.Abstract;
using Hotel.DTO.DTOs.RoomDtos;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult AddRoom(CreateRoomDto roomDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomDto);
            _roomService.TInsert(values);
            return Ok("Başarıyla eklendi");
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto roomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomDto);
            _roomService.TUpdate(values);
            return Ok("Başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
           var value = _roomService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetById(id);
            _roomService.TDelete(value);
            return Ok();
        }

    }
}
