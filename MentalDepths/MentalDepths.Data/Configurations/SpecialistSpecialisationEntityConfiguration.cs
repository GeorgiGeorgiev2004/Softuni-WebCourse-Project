namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
    public class SpecialistSpecialisationEntityConfiguration : IEntityTypeConfiguration<SpecialistSpecialisation>
    {
        public void Configure(EntityTypeBuilder<SpecialistSpecialisation> builder)
        {
            builder
                .HasKey(ss => new { ss.SpecialistId, ss.SpecialisationId });
        }
    }
}
