﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace LightSwitchApplication
{
    public class Chat : Hub
    {
        public void Send(string message)
        {
            // Call the addMessage method on all clients            
            Clients.All.addMessage(message);
        }

        public void ClientCreat(string message)
        {
            Clients.All.CustomersInserted("SLSLSLSL", "IIEIEI");
        }
    }
}