namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Data.Models;
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasMany(c=>c.ApplicationUsers)
                .WithOne(au => au.City)
                .HasForeignKey(c=>c.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    } 
}
