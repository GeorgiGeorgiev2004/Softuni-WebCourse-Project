namespace MentalDepths.Services.Web.SignalR.Chat
{
    using MentalDepths.Services.Web.Interfaces;
    using Microsoft.AspNetCore.SignalR;
    public class ChatHub:Hub
    {
        private readonly IMessageService messageService;
        public ChatHub(IMessageService msgs)
        {
            messageService = msgs;
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
