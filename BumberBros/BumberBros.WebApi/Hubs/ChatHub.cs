using Microsoft.AspNetCore.SignalR;

namespace BumberBros.WebApi.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string content)
        {
            await Clients.All.SendAsync("ReceiveMessage", content);
        }
    }
}
