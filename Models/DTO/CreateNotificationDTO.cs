using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strike_Showdown_Back_End.Models.DTO
{
    public class CreateNotificationDTO
    {
        public int SenderID { get; set; }
        public int RecieverID { get; set; }
        public int PostID { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}