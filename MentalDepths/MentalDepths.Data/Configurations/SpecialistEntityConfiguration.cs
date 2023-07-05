namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders; 
    
    using MentalDepths.Data.Models;
    public class SpecialistEntityConfiguration : IEntityTypeConfiguration<Specialist>
    {
        public void Configure(EntityTypeBuilder<Specialist> builder)
        {
            builder
                .HasMany(s => s.Specialisations)
                .WithOne(s => s.Specialist)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
