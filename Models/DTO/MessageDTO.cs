using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strike_Showdown_Back_End.Models.DTO
{
    public class MessageDTO
    {
        public int UserID { get; set; }
        public string? Message { get; set; }
        public string ChatRoomName { get; set; }
    }
}