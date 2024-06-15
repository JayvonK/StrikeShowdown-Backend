using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Strike_Showdown_Back_End.Models;
using Strike_Showdown_Back_End.Models.DTO;
using Strike_Showdown_Back_End.Services;
using Microsoft.AspNetCore.Mvc;

namespace Strike_Showdown_Back_End.Controllers
{
    [ApiController]
    [Route("MessageController")]
    public class MessageController
    {
        private readonly ChatroomService _service;

        public MessageController(ChatroomService s){
            _service = s;
        }

        [HttpPost]
        [Route("SendMessage")]
        public bool SendMessage(MessageDTO message){
            return _service.AddMessage(message);
        }

        [HttpPost]
        [Route("CreateChatroom/{yourID}/{userID}/{name}")]
        public bool CreateChatroom(int yourID, int userID, string name){
            return _service.AddChatroom(yourID, userID, name);
        }

        [HttpGet]
        [Route("JoinChatroom/{yourID}/{userID}")]
        public ChatRoomNameDTO JoinChatroom(int yourID, int userID){
            return _service.JoinChatRoom(yourID, userID);
        }

        [HttpGet]
        [Route("GetMessagesFromChatroom/{name}")]
        public IEnumerable<MessageModel> GetMessages(string name){
            return _service.GetChatroomMessagesFrom(name);
        }

        [HttpDelete]
        [Route("DeleteChatroom/{name}")]
        public bool Delete(string name){
            return _service.DeleteChatroom(name);
        }

        [HttpDelete]
        [Route("DeleteMessage/{messageID}/{chat}")]
        public bool DeleteMessage(int messageID, string chat){
            return _service.DeleteMessageFrom(messageID, chat);
        }
    }
}