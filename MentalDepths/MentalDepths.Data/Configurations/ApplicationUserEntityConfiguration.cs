
namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using MentalDepths.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.AspNet.Identity;

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(GenerateApplicationUsers().Result);
        }

        public async Task<ICollection<ApplicationUser>> GenerateApplicationUsers()
        { 
            PasswordHasher hasher = new PasswordHasher();
            List<ApplicationUser> users = new List<ApplicationUser>();
            ApplicationUser user = new ApplicationUser()
            {
                Id = Guid.Parse("f957a45a-d8df-439e-a50a-b1c0f87a69f2"),
                FirstName = "Georgi",
                SecondName = "Lyubenov",
                LastName = "Georgiev",
                CityId = 2,
                Email = "gogo_5a@abv.bg",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword("ZA(dPFvU"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled=false
            };
            user.UserName = user.FirstName + "_" + user.LastName;
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail=user.Email.ToUpper();
            users.Add(user);
            user = new ApplicationUser()
            {
                Id = Guid.Parse("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                FirstName = "Iliq",
                SecondName = string.Empty,
                LastName = "Steliov",
                CityId = 5,
                Email = "ScaryHaxer@gmail.com",
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword("Ya9zMTWsW"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.UserName = user.FirstName + "_" + user.LastName;
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = Guid.Parse("308508b8-ce9e-470b-a122-8a77f576532e"),
                FirstName = "Ivan",
                SecondName = "Sirov",
                LastName = "Ivanov",
                CityId = 27,
                Email = "Ivan.Ivanov234@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword("uw^Nn(Yf"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.UserName = user.FirstName + "_" + user.LastName;
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = Guid.Parse("9953dce8-25f6-45f2-bf8c-816b92bb0e28"),
                FirstName = "Lilial",
                SecondName = "Sabiev",
                LastName = "Izbrannikov",
                CityId = 13,
                Email = "Lilial_Izbora@abv.bg",
                EmailConfirmed = false,
                PasswordHash = new PasswordHasher().HashPassword("#jzhsrSh#K"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.UserName = user.FirstName + "_" + user.LastName;
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = Guid.Parse("59a88704-3ae3-4554-ad39-81b1f0304069"),
                FirstName = "Nikola",
                SecondName = string.Empty,
                LastName = "Zemelyarski",
                CityId = 22,
                Email = "Kolio_Zemev@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword("nNNygMc"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.UserName = user.FirstName + " " + user.LastName;
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = Guid.Parse("a63c570e-8c25-449f-b89c-3df89bc0d17c"),
                FirstName = "Dembe",
                SecondName = "Nisantimetarottebe",
                LastName = "Redglade",
                CityId = 17,
                Email = "Sasunionios_loliolios@abv.bg",
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword("!cJ@yvJ"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.UserName = user.FirstName + "_" + user.LastName;
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            users.Add(user);

            return users;
        }
    }
}
