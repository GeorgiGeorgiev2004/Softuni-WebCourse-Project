using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentalDepths.Data.Configurations
{
    public class SpecialisationEntityConfiguration : IEntityTypeConfiguration<Specialisation>
    {
        public void Configure(EntityTypeBuilder<Specialisation> builder)
        {
            builder
                .HasMany(s => s.Specialists)
                .WithOne(s => s.Specialisation)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
