using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO.DTOs.ServiceDtos
{
    public class ResultServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceIcon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
