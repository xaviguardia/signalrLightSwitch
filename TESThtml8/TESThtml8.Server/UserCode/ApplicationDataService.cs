using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
using Microsoft.AspNet.SignalR;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void InformesSet_Inserted(Informes entity)
        {
            var myHub = GlobalHost.ConnectionManager.GetHubContext<Chat>();

            var result = myHub.Clients.All.CustomersInserted("AAA","NNNNNN");
        }
    }
}

