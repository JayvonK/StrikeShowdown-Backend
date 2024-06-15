using Microsoft.AspNetCore.SignalR;
using Strike_Showdown_Back_End.Models.Hub;
using Strike_Showdown_Back_End.Services.Context;

namespace Strike_Showdown_Back_End.Hubs
{
    public sealed class ChatHub : Hub
    {
      private readonly SharedDB _shared;

        public ChatHub(SharedDB db){
            _shared = db;
        }

        public async Task JoinChat(UserConnection con){
            await Clients.All.SendAsync("ReceiveMessage", con.Username, $"{con.Username} has entered the chat. Say hi!");
        }

        public async Task JoinSpecificChat(UserConnection con){
            await Groups.AddToGroupAsync(Context.ConnectionId, con.Chatroom);

            _shared.connections[Context.ConnectionId] = con;

            await Clients.Group(con.Chatroom).SendAsync("JoinSpecificChat", con.Username, $"{con.Username} has entered the chat. Say hi!");
        }

        public async Task SendMessage(string msg){
            if(_shared.connections.TryGetValue(Context.ConnectionId, out UserConnection conn)){
                await Clients.Group(conn.Chatroom).SendAsync("ReceiveSpecificMessage", conn.Username, msg);
            }
        }
    }
}