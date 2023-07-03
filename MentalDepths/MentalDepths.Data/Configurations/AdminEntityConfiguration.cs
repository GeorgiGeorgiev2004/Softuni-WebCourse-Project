using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentalDepths.Data.Configurations
{
    public class AdminEntityConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasMany(a => a.JobApplications)
                .WithOne(ja => ja.Admin)
                .HasForeignKey(a=>a.JobApplicationId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(GenerateAdmin());
        }
        public Admin GenerateAdmin()
        {
            return new Admin
            {
                Id = Guid.NewGuid(),
                Username = "Big Boss",
                UserId = Guid.Parse(""),
            };
        }
    }
}