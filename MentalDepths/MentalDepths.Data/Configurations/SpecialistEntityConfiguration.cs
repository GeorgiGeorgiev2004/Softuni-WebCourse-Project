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

           builder.HasData(GenerateSpecialists());
        }
        public List<Specialist> GenerateSpecialists() 
        {
            List<Specialist> specialists = new List<Specialist>();
            Specialist specialist = new Specialist()
            {
                Id = Guid.Parse("550184af-0284-4a1c-bc3e-223cb9198e62"),
                ImageURL = "https://images.pexels.com/photos/3538028/pexels-photo-3538028.jpeg?cs=srgb&dl=pexels-jeys-tubianosa-3538028.jpg&fm=jpg",
                Age = 23,
                Address = "AlenMak bl.14 vh.6",
                Description = "Talanted, young and abnormaly ambitious she will obliterate your expectations!",
                UserId = Guid.Parse("308508b8-ce9e-470b-a122-8a77f576532e")
                
            };
            specialists.Add(specialist);

            specialist = new Specialist()
            {
                Id = Guid.Parse("33713803-661e-4fad-a041-cf526fbc83e4"),
                ImageURL = "https://images.pexels.com/photos/1936854/pexels-photo-1936854.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                Age = 56,
                Address = "ul.\"Sergei Kirov\" vh.34",
                Description = "Talanted, young and abnormaly ambitious he will obliterate your expectations!",
                UserId = Guid.Parse("59a88704-3ae3-4554-ad39-81b1f0304069")
            };
            
            specialists.Add(specialist);

            return specialists;
        }
    }
}
