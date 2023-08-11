using MentalDepths.Data.Models;
using MentalDepths.Services.Web;
using MentalDepths.Services.Web.Repositories;
using MentalDepths.Services.Web.Repositories.Interfaces;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    public class UserTest : UnitTestBase
    {
        private UserService userService;
        private IUserManagerRepository userManagerRepository;

        [SetUp]
        public void SetUp()
        {
            userManagerRepository = new UserManagerRepository();
            userService = new UserService(context, userManagerRepository);
        }
        [Test]
        public void GetAllCities_Works()
        {
            var cities = userService.GetAllCities().Result;

            Assert.That(cities.Count(), Is.EqualTo(1));
        }
        [Test]
        public void GenerateConfiramtionCode_Works()
        {
            var code = userService.GenerateConfiramtionCode();

            Assert.IsNotNull(code);
            Assert.That(code, Does.Match(MentalDepths.Common.ModelRegulations.CodeSender.Regex));
        }
        [Test]
        public void AddConfiramtionCodeToDic_Works()
        {
            var code = "666BBA";

            userService.AddConfiramtionCodeToDic("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f", code);

            Assert.That(userManagerRepository.Dictionary.Count(), Is.EqualTo(1));
            Assert.That(userManagerRepository.Dictionary.ContainsKey("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"), Is.EqualTo(true));
        }
        [Test]
        public void GetConfiramtionCodeFromId_Works()
        {
            var ExpectedCode = "666BBA";

            var id = "2b7ff5f6-3216-49e5-8ec8-8dc4e221615f";

            userService.AddConfiramtionCodeToDic("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f", ExpectedCode);

            var dic = userManagerRepository.Dictionary;
            var code = userService.GetConfiramtionCodeFromId(id);

            Assert.IsNotNull(code);
            Assert.That(ExpectedCode, Is.EqualTo(code));
        }
        [Test]
        public void SetEmailConfirmationToTrue_Works()
        {
            var ap = new ApplicationUser()
            {
                Id = Guid.Parse("00000000-3216-49e5-8ec8-8dc4e221615f"),
                CreatedOn = DateTime.Now,
                CityId = 1,
                Email = "example_example@example.exmp",
                FirstName = "Example",
                SecondName = "Example",
                LastName = "Example",
                PhoneNumber = "3333333335",
                EmailConfirmed = false,
                UserName = "Example_Example",
                NormalizedEmail = "EXAMPLE_EXAMPLE@EXAMPLE.EXMP",
                NormalizedUserName = "EXAMPLE_EXAMPLE",
                PhoneNumberConfirmed = true,
                ConcurrencyStamp = "00000000-4440-486a-b05b-8f780aee182f",
            };
            ap.PasswordHash = new PasswordHasher().HashPassword("AAAAAAA");
            context.ApplicationUsers.Add(ap);
            context.SaveChanges();
            userService.SetEmailConfirmationToTrue("00000000-3216-49e5-8ec8-8dc4e221615f");
            ap = context.ApplicationUsers.First(a => a.Id == Guid.Parse("00000000-3216-49e5-8ec8-8dc4e221615f"));
            Assert.That(ap.EmailConfirmed, Is.EqualTo(true));
        }
        [Test]
        public void DisposeOfConfirmationCodes_Works()
        {
            var code = "666BBA";

            userService.AddConfiramtionCodeToDic("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f", code);

            userService.DisposeOfConfirmedCodes("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");
            Assert.That(userManagerRepository.Dictionary.Count(), Is.EqualTo(0));
            Assert.That(userManagerRepository.Dictionary.ContainsKey("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"), Is.EqualTo(false));
        }
        [Test]
        public void EmailIsConfirmed_Works()
        {
            Assert.That(userService.EmailIsConfirmed("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"), Is.EqualTo(true));
        }
    }
}
