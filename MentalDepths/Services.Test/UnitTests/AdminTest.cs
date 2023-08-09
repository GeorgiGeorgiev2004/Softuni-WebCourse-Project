using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore;

namespace Services.Test.UnitTests
{
    public class AdminTest : UnitTestBase
    {
        private AdminService adminService;
        private SpecialisationService sps;
        [SetUp]
        public void SetUp()
        {
            sps = new SpecialisationService(context);
            adminService = new AdminService(context, sps);
        }
        [Test]
        public void TurningAplicantIntoSpeciaist_Works()
        {
            //Act
            AplicantVM aplicantVM = new AplicantVM()
            {
                Id = Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"),
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006.jpg",
                Age = 22,
                Address = "Lihtenstein 12 2135",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sed lorem laoreet, tempus lacus eu, auctor dui. Ut aliquet dictum porttitor. Nunc lobortis arcu sed tellus consequat scelerisque quis ut metus. Vestibulum quis metus malesuada, vestibulum enim et, feugiat felis. Cras imperdiet posuere nisi, quis luctus risus imperdiet semper. Pellentesque nulla est, aliquet a accumsan vitae, maximus sit amet justo. Nulla tempor, mi et placerat gravida, massa lorem rutrum odio, tristique sollicitudin lorem tellus sit amet sem. Cras vulputate nisl at enim efficitur facilisis. Etiam finibus pretium aliquam. Proin condimentum cursus purus ut euismod.",
                UserId = Guid.Parse("19f57060-46bb-422a-a6fe-fcad66933f25")
            };
            RegisterASpecicalistVM specialistvm = new RegisterASpecicalistVM()
            {
                Id = Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"),
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006.jpg",
                Age = 22,
                Address = "Lihtenstein 12 2135",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sed lorem laoreet, tempus lacus eu, auctor dui. Ut aliquet dictum porttitor. Nunc lobortis arcu sed tellus consequat scelerisque quis ut metus. Vestibulum quis metus malesuada, vestibulum enim et, feugiat felis. Cras imperdiet posuere nisi, quis luctus risus imperdiet semper. Pellentesque nulla est, aliquet a accumsan vitae, maximus sit amet justo. Nulla tempor, mi et placerat gravida, massa lorem rutrum odio, tristique sollicitudin lorem tellus sit amet sem. Cras vulputate nisl at enim efficitur facilisis. Etiam finibus pretium aliquam. Proin condimentum cursus purus ut euismod.",
                UserId = Guid.Parse("19f57060-46bb-422a-a6fe-fcad66933f25")
            };
            var specialistTRANSFORMED = adminService.TurnAplicantToSpecialist(aplicantVM).Result;
            //Assert
            Assert.That(specialistvm.Address, Is.EqualTo(specialistTRANSFORMED.Address));
            Assert.That(specialistvm.Age, Is.EqualTo(specialistTRANSFORMED.Age));
            Assert.That(specialistvm.Description, Is.EqualTo(specialistTRANSFORMED.Description));
            Assert.That(specialistvm.UserId, Is.EqualTo(specialistTRANSFORMED.UserId));
            Assert.That(aplicantVM.Id, Is.Not.EqualTo(specialistTRANSFORMED.Id));
        }

        [Test]
        public void FindAplicantById_Works()
        {
            var aplicant = adminService.FindAplicantById(Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174")).Result;

            Assert.That(Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"), Is.EqualTo(aplicant.Id));
        }

    }
}
