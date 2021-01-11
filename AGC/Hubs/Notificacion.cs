using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGC.Hubs
{
    public class Notificacion : Hub
    {
        public override Task OnConnectedAsync()
        {
            //this.Context.ConnectionId
            return base.OnConnectedAsync();
        }
        public Task Notifica(string msg)
        {
            return Clients.Client("").SendAsync("aprobarcoti", msg);
        }
    }
}
