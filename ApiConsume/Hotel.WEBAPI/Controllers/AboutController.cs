using Hotel.Business.Abstract;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddAbout(About About)
        {
            _aboutService.TInsert(About);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            _aboutService.TUpdate(About);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok();
        }
    }
}
