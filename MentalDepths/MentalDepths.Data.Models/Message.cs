using MentalDepths.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentalDepths.Data.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public PatientOrSpecialist TypeOfUser { get; set; }
        public DateTime TimeOfSend { get; set; }

        public string? Text { get; set; }

        public Guid ConversationId { get; set; }
        [ForeignKey(nameof(ConversationId))]
        public Conversation Conversation { get; set; }
    }
}
