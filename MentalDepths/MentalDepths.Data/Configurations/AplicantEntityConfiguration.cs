using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Data.Configurations
{
    public class AplicantEntityConfiguration : IEntityTypeConfiguration<Aplicant>
    {
        public void Configure(EntityTypeBuilder<Aplicant> builder)
        {
            builder.HasData(GenerateAplicants());
        }
        public HashSet<Aplicant> GenerateAplicants()
        {
            HashSet<Aplicant> aplicants = new HashSet<Aplicant>
        {
            new Aplicant()
            {
                Id = Guid.Parse("7bca8717-bead-4eff-934f-0eeb611c214b"),
                ImageURL="https://i.pinimg.com/474x/66/f4/e3/66f4e3deac6cac5fc4741af828bacc23.jpg",
                Description = "I have around 15 years of experiance in the work space that involves direct contact to the human psyce. Many of years were spent on refining my talentss and developing my skillset. One of the nicest compliments that i have recived came from my previous employer which stated : \"You are  as responsive and ambitious as the day I met you\"",
                Age=45,
                Specialisations="Addiction management, Marriage counselor",
                Address="ul. Zagorska, vh.32",
                JobApplicationId=Guid.Parse("2503c6c8-c74d-45e0-8f6a-ab475628445f"),
                UserId = Guid.Parse("010d67b6-964d-4248-9c9a-ad83215eaa4a")
            },
             new Aplicant()
            {
                Id = Guid.Parse("b4e811e8-305e-405c-a758-cefdf2d2fb4e"),
                ImageURL="https://health.sunnybrook.ca/wp-content/uploads/2017/12/180104-teen-810x424.jpg",
                Description = "Young and ambitious, currently studying in the University of Pleven. No prior experiance.",
                Age=21,
                Specialisations="Listened to one of my friends's problems my advice helped",
                Address="ul. Lilav Ziumbiul, vh.2",
                JobApplicationId=Guid.Parse("6a9170ff-59af-47f3-ba1e-f1d5ffaeb0ab"),
                UserId = Guid.Parse("a63c570e-8c25-449f-b89c-3df89bc0d17c")
            },
        };
            return aplicants;
        }
    }

}
