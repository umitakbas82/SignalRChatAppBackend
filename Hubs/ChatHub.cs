﻿using Microsoft.AspNetCore.SignalR;
using SignarRChatAppBackend.Services;
using System;
using System.Threading.Tasks;

namespace SignarRChatAppBackend.Hubs
{
    public class ChatHub:Hub
    {
        private readonly ChatService _chatService;
        public ChatHub(ChatService chatService) 
        {
            _chatService = chatService;
        }

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "Come2Chat");
            await Clients.Caller.SendAsync("UserConnected");
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "Come2");
            await base.OnDisconnectedAsync(exception);
        }
    }

   

}
