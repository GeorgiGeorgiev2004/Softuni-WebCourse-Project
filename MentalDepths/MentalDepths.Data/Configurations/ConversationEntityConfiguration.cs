using Microsoft.EntityFrameworkCore;
using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentalDepths.Data.Configurations
{
    internal class ConversationEntityConfiguration : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder.HasOne(c => c.Specialist)
                .WithMany(s => s.Conversations)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateConversation());
        }
        public Conversation GenerateConversation() 
        {
            return new Conversation() 
            {
                Id = Guid.Parse("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"),
                IsClosed = false,
                UserId = Guid.Parse("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                SpecialistId= Guid.Parse("550184af-0284-4a1c-bc3e-223cb9198e62"),
                NoteId = Guid.Parse("276a7ff5-9204-4453-bd33-d84ba198c921"),
            };
        }
    }
}
