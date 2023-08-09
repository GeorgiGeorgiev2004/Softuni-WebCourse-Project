using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IConversationService
    {
        public Task<ICollection<ConversationVM>> GetAllConversationsForUser(Guid userId);

        public Task<ConversationVM> GenerateNewConversation(Guid IdSpecialist, Guid IdUser);

        public Task SaveConversation(ConversationVM conversation);

        public Task<ConversationVM> GetConversationById(Guid id);

        public Task MarkChatAsDeleted(Guid id);
        
        public Task MarkChatAsReturned(Guid Id);
        
        public Task<bool> IsThereAConversationBetween(Guid SpecialistId, Guid userId);
        
        public Task<ConversationVM> GetConversationByParticipants(Guid SpecialistId, Guid userId);
    }
}
