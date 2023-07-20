using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web.Repositories
{
    public class ChatLogs : IChatLogs
    {
        private MentalDepthsDbContext _context;
        private Dictionary<Conversation, ICollection<Message>> dictionary = new Dictionary<Conversation, ICollection<Message>>();
        public ChatLogs(MentalDepthsDbContext ctx)
        {
            _context = ctx;
        }
        public Dictionary<Conversation, ICollection<Message>> Dictionary => dictionary;

        public async Task LogAMessage(Guid ConversationId, Message msg)
        {
            if (!dictionary.ContainsKey(_context.Conversations.FirstAsync(c=>c.Id==ConversationId).Result))
            {
               // dictionary.Add()
            }
        }
    }
}
