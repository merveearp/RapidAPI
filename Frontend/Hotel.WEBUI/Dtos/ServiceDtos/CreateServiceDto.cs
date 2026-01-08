using System.ComponentModel.DataAnnotations;

namespace Hotel.WEBUI.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Servis İkon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmeet başlığı giriniz")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
