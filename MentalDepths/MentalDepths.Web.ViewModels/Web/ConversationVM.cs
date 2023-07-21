using MentalDepths.Data.Models;

namespace MentalDepths.Web.ViewModels.Web
{
    public class ConversationVM
    {
        public Guid Id { get; set; }
        public Guid SpecialistId { get; set; }
        public Specialist Specialist { get; set; }

        public string SpecialistName { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }

        public NoteVm? Note { get; set; }
    }
}
