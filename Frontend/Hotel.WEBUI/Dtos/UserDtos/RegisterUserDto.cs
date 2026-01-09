using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Hotel.WEBUI.Dtos.UserDtos
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "Ad alanı girilmesi zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı girilmesi zorunludur")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı girilmesi zorunludur")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail alanı girilmesi zorunludur")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı girilmesi zorunludur")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı girilmesi zorunludur")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
