using System.ComponentModel.DataAnnotations;

namespace Hotel.WEBUI.Dtos.SubscribeDtos
{

    public class CreateSubscribeDto
    {
        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }
    }

    
}
