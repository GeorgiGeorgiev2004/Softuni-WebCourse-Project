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
        public List<Specialist> GenerateSpecialists() 
        {
            List<Specialist> specialists = new List<Specialist>();
            Specialist specialist = new Specialist()
            {
                Id = Guid.NewGuid(),
                ImageURL = "https://www.facebook.com/friends/requests/?profile_id=100066523184519",
                Age = 23,
                Address = "AlenMak bl.14 vh.6",
                Description = "Talanted, young and abnormaly ambitious she will obliterate your expectations!",

            };
            specialists.Add(specialist);

            return specialists;
        }
    }
}
