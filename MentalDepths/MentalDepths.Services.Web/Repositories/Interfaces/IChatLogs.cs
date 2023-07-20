using MentalDepths.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web.Repositories.Interfaces
{
    public interface IChatLogs
    {
        Dictionary<Conversation, ICollection<Message>>Dictionary {get;}
        public Task LogAMessage(Guid ConversationId,Message msg);

    }
}
