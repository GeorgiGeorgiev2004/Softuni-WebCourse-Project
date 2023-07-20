using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Data.Models
{
    public class Note
    {
        public Note()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string? Message { get; set; }

        [ForeignKey(nameof(Conversation))]
        public Guid ConversationtId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
