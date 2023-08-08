namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using MentalDepths.Data.Models;
    public class AdminEntityConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {

        }
        public Admin GenerateAdmin()
        {
             Admin admin = new Admin
            {
                Id = Guid.Parse("d947f5ab-75ae-4ebe-9f26-9af2671d77ac"),
                Username = "Big Boss",
                UserId = Guid.Parse("f957a45a-d8df-439e-a50a-b1c0f87a69f2")
            };
            return admin;
            
        }
    }
}