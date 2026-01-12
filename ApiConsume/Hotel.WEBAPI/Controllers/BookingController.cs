
using AutoMapper;
using Hotel.Business.Abstract;
using Hotel.DTO.DTOs.BookingDtos;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
       
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public IActionResult AddBooking(CreateBookingDto bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Booking>(bookingDto);
            _bookingService.TInsert(values);
            return Ok("Başarıyla eklendi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Booking>(bookingDto);
            _bookingService.TUpdate(values);
            return Ok("Başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok();
        }

        [HttpPut("IsApprove")]
        public IActionResult UpdateBookingStatus(BookingStatusDto bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Booking>(bookingDto);
            _bookingService.TBookingStatusApprove(values);
            return Ok("Başarıyla güncellendi");
        }
    }
}
