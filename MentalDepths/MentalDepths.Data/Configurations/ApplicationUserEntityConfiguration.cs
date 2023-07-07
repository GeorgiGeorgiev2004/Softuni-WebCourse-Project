
namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using MentalDepths.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using MentalDepths.Services.Data.Interfaces;
    using Microsoft.AspNet.Identity;

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {   
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(GenerateApplicationUsers());
        }

        public ICollection<ApplicationUser> GenerateApplicationUsers()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            ApplicationUser user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "Georgi",
                SecondName = "Lyubenov",
                LastName = "Georgiev",
                CityId = 2,
                Email = "gogo_5a@abv.bg",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher().HashPassword("ZA(dPFvU"),
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
                Id = Guid.NewGuid(),
                FirstName = "Iliq",
                SecondName = string.Empty,
                LastName = "Steliov",
                CityId = 5,
                Email = "ScaryHaxer@yahoo.com",
                EmailConfirmed = false,
                PasswordHash = new PasswordHasher().HashPassword("Ya9zMTWsW"),
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
                Id = Guid.NewGuid(),
                FirstName = "Ivan",
                SecondName = "Sirov",
                LastName = "Ivanov",
                CityId = 27,
                Email = "Ivan.Ivanov234@gmail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher().HashPassword("uw^Nn(Yf"),
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
                Id = Guid.NewGuid(),
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
                Id = Guid.NewGuid(),
                FirstName = "Nikola",
                SecondName = string.Empty,
                LastName = "Zemelyarski",
                CityId = 22,
                Email = "Kolio_Zemev@gmail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher().HashPassword("nNNygMc"),
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
                Id = Guid.NewGuid(),
                FirstName = "Dembe",
                SecondName = "Nisantimetarottebe",
                LastName = "Redglade",
                CityId = 17,
                Email = "DembeRed@alo.net",
                EmailConfirmed = false,
                PasswordHash = new PasswordHasher().HashPassword("!cJ@yvJ"),
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
