namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
    public class PrescriptionEntityConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder
                .HasOne(p => p.Specialist)
                .WithMany(s => s.Prescriptions)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(p => p.ApplicationUser)
               .WithMany(s => s.Prescriptions)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
