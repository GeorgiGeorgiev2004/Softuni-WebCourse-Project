using MentalDepths.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Data.Models
{
    public class Conversation
    {
        public Conversation()
        {
            Id= Guid.NewGuid();
            Messages = new HashSet<Message>();
        }
        [Key]
        public Guid Id { get; set; }
        public Guid SpecialistId { get; set; }
        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
        public Guid NoteId { get; set; }
        public Note Note { get; set; }
        public ICollection<Message> Messages { get; set; }

        public bool IsClosed { get; set; }
    }
}
