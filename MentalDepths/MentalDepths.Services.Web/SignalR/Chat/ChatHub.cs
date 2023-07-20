
namespace MentalDepths.Services.Web.SignalR.Chat
{
    using Microsoft.AspNetCore.SignalR;
    public class ChatHub:Hub
    {
        public async Task SendMessage(Guid userId, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);

        }
    }
}
