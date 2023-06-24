using FrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Threading.Tasks;

namespace FrontToBack.Hubs
{
    public class ChatHub : Hub
    {
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(UserManager<AppUser> usermanager)
        {
            _userManager = usermanager;
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                var user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId=Context.ConnectionId;
               var result= _userManager.UpdateAsync(user).Result;
                Clients.All.SendAsync("userConnect", user.Id, result);
            }
            return base.OnConnectedAsync(); 
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                var user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId = null;
                var result = _userManager.UpdateAsync(user).Result;
                Clients.All.SendAsync("userDisconnect", user.Id, result);

            }
            return base.OnDisconnectedAsync(exception); 
        }
    }
}
