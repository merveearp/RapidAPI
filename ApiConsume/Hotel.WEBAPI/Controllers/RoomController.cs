using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }
    }
}
