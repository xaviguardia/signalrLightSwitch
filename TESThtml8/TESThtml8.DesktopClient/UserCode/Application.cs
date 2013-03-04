using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
namespace LightSwitchApplication
{
    public partial class Application
    {
        public IHubProxy HubProxy { get; set; }
        partial void Application_Initialize()
        {
            HubConnection hubConnection;
            http://localhost:49499
            hubConnection = new HubConnection("http://localhost:49499"); //make sure it matches your port in development

          //  HubProxy = hubConnection.CreateProxy("MyHub");
            HubProxy = hubConnection.CreateHubProxy("Chat");
            HubProxy.On<string, string>("CustomersInserted", (r, user) =>
            {
                this.ActiveScreens.First().Screen.Details.Dispatcher.BeginInvoke(delegate() {
                    this.ActiveScreens.First().Screen.ShowMessageBox("han creat un client");
                });
              //  this.Details.Dispatcher.BeginInvoke(() =>
              //  {
              //      this.ActiveScreens.First().Screen.ShowMessageBox("han creat un client");
              ////      Console.WriteLine("Han creat un client");
              //  });
            });


            HubProxy.On<string>("addMessage", (missatge) =>
            {
                this.ActiveScreens.First().Screen.Details.Dispatcher.BeginInvoke(delegate()
                {
                    this.ActiveScreens.First().Screen.ShowMessageBox("has rebut un "+missatge);
                });
                //  this.Details.Dispatcher.BeginInvoke(() =>
                //  {
                //      this.ActiveScreens.First().Screen.ShowMessageBox("han creat un client");
                ////      Console.WriteLine("Han creat un client");
                //  });
            });
            hubConnection.Start().Wait();
        }
    }
}
