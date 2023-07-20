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
        }
    }
}
