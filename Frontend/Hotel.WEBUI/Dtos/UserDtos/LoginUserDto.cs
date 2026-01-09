using System.ComponentModel.DataAnnotations;

namespace Hotel.WEBUI.Dtos.UserDtos
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
