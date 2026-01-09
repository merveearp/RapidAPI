using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.WEBUI.Dtos.RoomDtos
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Oda numarası alanı doldurmak zorunludur")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public int IsStar { get; set; }
        public bool Wifi { get; set; }
        public string Description { get; set; }
    }
}
