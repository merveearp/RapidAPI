using Hotel.Entity.Concrete;
using Hotel.WEBUI.Dtos.UserDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Hotel.WEBUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginDto)
        {
            if(!ModelState.IsValid)
            {
                return View(loginDto);

            }
            var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, false, false);
            if(!result.Succeeded)
            {
                TempData["LoginError"] = "Kullanıcı adı veya şifre hatalı";
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index", "Home", new { area = "Admin" });

        }


    }
}
