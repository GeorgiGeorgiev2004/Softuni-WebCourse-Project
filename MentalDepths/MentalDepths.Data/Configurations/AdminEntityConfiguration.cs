namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using MentalDepths.Data.Models;
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
                Id = Guid.Parse("d947f5ab-75ae-4ebe-9f26-9af2671d77ac"),
                Username = "Big Boss",
                UserId = Guid.Parse("e84a2911-5c9c-4014-86ee-9e171362c65c"),
            };
        }
    }
}