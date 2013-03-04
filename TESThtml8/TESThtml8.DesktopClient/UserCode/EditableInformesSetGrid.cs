using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class EditableInformesSetGrid
    {
        partial void enviarMissatge_Execute()
        {
            Application.HubProxy.Invoke<string>("Send", new string[] { "A" });
            //Application.HubProxy.Invoke<>("MyCommand",
            //  new RequestParams { RequestParam1 = "request 1", RequestParam2 = "request 2" }).ContinueWith((task) =>
            //  {
            //      var responseparam2 = task.Result.ResponseParam2;
            //      this.Details.Dispatcher.BeginInvoke(() =>
            //      {
            //          this.ShowMessageBox("Thanks for " + responseparam2);
            //      });

            //  });
        }
    }
}
