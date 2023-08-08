using AutoMapper;
using MentalDepths.Data;
using MentalDepths.Data.Models;
using Services.Test.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    public class UnitTestBase
    {
        protected MentalDepthsDbContext context;

        [OneTimeSetUp]
        public void SetUpBase() 
        {
            context = DatabaseMock.Instance;
            SeedDatabase();
        }
        public Aplicant Aplicant { get; set; }
        private void SeedDatabase()
        {
            Aplicant = new Aplicant()
            {
                Id = Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"),
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006.jpg",
                Age = 22,
                Address = "Lihtenstein 12 2135",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sed lorem laoreet, tempus lacus eu, auctor dui. Ut aliquet dictum porttitor. Nunc lobortis arcu sed tellus consequat scelerisque quis ut metus. Vestibulum quis metus malesuada, vestibulum enim et, feugiat felis. Cras imperdiet posuere nisi, quis luctus risus imperdiet semper. Pellentesque nulla est, aliquet a accumsan vitae, maximus sit amet justo. Nulla tempor, mi et placerat gravida, massa lorem rutrum odio, tristique sollicitudin lorem tellus sit amet sem. Cras vulputate nisl at enim efficitur facilisis. Etiam finibus pretium aliquam. Proin condimentum cursus purus ut euismod.",
                UserId = Guid.Parse("19f57060-46bb-422a-a6fe-fcad66933f25"),
                Specialisations = "specialisation 1, specialisation 2"
            };
            context.Aplicants.Add(Aplicant);
            context.SaveChanges();
        }

        [OneTimeTearDown]
        public void TearDownBase() 
        {
            context.Dispose();
        }
    }
}
