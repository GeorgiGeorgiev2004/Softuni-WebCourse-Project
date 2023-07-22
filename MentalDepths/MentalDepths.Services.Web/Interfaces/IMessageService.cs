using MentalDepths.Common.Enums;
using MentalDepths.Data.Models;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IMessageService
    {
        public Task SaveMessage(Guid userId,string message,Guid conversationId);

        public Task<Message> CreateMessage(string message, PatientOrSpecialist typeOfUser,Guid conversationId);
    }
}
