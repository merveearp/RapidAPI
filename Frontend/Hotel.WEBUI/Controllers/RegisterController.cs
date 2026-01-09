using Hotel.Entity.Concrete;
using Hotel.WEBUI.Dtos.UserDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WEBUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterUserDto userDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = userDto.Name,
                Email = userDto.Mail,
                Surname = userDto.Surname,
                UserName = userDto.Username
            };
            var result = await _userManager.CreateAsync(appUser, userDto.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
               
            return View();
        }
    }
}
