using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class NotificationHub : Hub
    {

        public override Task OnConnectedAsync()
        {
            Debug.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

    }
}
