using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSignalR.Hubs
{
    public class chatHub : Hub
    {
        public void send (string name, string message)
        {
            Clients.All.addNewMessage(name, message);
        }
    }
}