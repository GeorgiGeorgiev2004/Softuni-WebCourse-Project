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
        }
        //public Admin GenerateAdmin()
        //{
        //    return new Admin
        //    {
        //        Id = Guid.NewGuid(),
        //        Username = "Big Boss",
        //        UserId = Guid.Parse(""),
        //    };
        //}
    }
}