using Hotel.Business.Abstract;
using Hotel.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetById(id);
            _serviceService.TDelete(value);
            return Ok();
        }
    }
}
