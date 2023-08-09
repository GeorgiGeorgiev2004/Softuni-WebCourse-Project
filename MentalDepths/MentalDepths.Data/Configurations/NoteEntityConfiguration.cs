using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentalDepths.Data.Configurations
{
    public class NoteEntityConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
        }

        public Note GenerateNote() 
        {
            return new Note 
            {
                Id = Guid.Parse("276a7ff5-9204-4453-bd33-d84ba198c921"),
                ConversationtId = Guid.Parse("a14b7ac6-7feb-4c32-8e5c-813c9b45b559"),
                Message="Patient is busy with work on mondays and fridays! Meetings are usually in friday."
            };
        }
    }
}
