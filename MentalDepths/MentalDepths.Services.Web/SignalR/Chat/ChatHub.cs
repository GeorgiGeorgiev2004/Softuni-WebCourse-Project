namespace MentalDepths.Services.Web.SignalR.Chat
{
    using MentalDepths.Services.Web.Interfaces;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.VisualBasic;

    public class ChatHub:Hub
    {
        private readonly IMessageService messageService;
        public ChatHub(IMessageService msgs)
        {
            messageService = msgs;
        }
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message,DateTime.Now.ToString());
        }
        public async Task SaveMessage(string userId, string message,string conversationId)
        {
           await messageService.SaveMessage(Guid.Parse(userId), message, Guid.Parse(conversationId));
        }
    }
}
