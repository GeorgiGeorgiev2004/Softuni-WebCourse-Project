using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IConversationService
    {
        public Task<ICollection<ConversationVM>> GetAllConversationsForUser(Guid userId);

        public Task<ConversationVM> GenerateNewConversation(Guid IdSpecialist, Guid IdUser);
        public Task SaveConversation(ConversationVM conversation);
    }
}
