using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Strike_Showdown_Back_End.Models
{
    public class MessageModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string? ChatRoom { get; set; }
        public string? Message { get; set; }
        public string? PublisherName { get; set; }
        public MessageModel(){

        }
    }
}