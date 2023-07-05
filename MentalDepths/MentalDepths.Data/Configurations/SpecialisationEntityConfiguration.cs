namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
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
