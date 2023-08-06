using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MentalDepths.Common.Enums.PatientOrSpecialist;

namespace MentalDepths.Data.Configurations
{
    public class MessageEntityConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasOne(m=>m.Conversation)
                .WithMany(c=>c.Messages)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(Conversation());
        }
        public ICollection<Message> Conversation() 
        {
            return new List<Message>()
            {
                new Message()
                {
                    Id = 1,
                    ConversationId = Guid.Parse("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"),
                    TimeOfSend = new DateTime(2023,8,10,12,25,12),
                    TypeOfUser= Common.Enums.PatientOrSpecialist.Patient,
                    Text="Hello doctor Ivanov! I have had seizures for quite some time now. I don't think that talking to a shrink will work but I'm left with no alternative.It all started when one day i was watching the ducks."
                },
                new Message()
                {
                    Id = 2,
                    ConversationId = Guid.Parse("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"),
                    TimeOfSend = new DateTime(2023,8,10,12,45,17),
                    TypeOfUser= Common.Enums.PatientOrSpecialist.Specialist,
                    Text="Good day to you Tony(hope it is ok for me to use your first name). I would love to help but for this to work we need to arrange a meeting and I would need you to come to my office"
                },
                new Message()
                {
                    Id = 3,
                    ConversationId = Guid.Parse("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"),
                    TimeOfSend = new DateTime(2023,8,10,12,58,55),
                    TypeOfUser= Common.Enums.PatientOrSpecialist.Patient,
                    Text="Doc I can come by tomorrow around 9 40."
                },
                new Message()
                {
                    Id = 4,
                    ConversationId = Guid.Parse("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"),
                    TimeOfSend = new DateTime(2023,8,10,12,58,55),
                    TypeOfUser= Common.Enums.PatientOrSpecialist.Specialist,
                    Text="Check your apointments page It should say that we have a session arranged for tomorrow at 9:40"
                },
            };
        }
    }
}
