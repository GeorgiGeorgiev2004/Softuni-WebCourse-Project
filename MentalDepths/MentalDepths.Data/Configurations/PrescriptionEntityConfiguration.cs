using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentalDepths.Data.Configurations
{
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
