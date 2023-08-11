using MentalDepths.Services.Web;
using MentalDepths.Web.Infrastructure.Extensions;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Http;

namespace Services.Test.UnitTests
{
    public class JobApplicationTest:UnitTestBase
    {
        private JobApplicationService jas;

        [SetUp]
        public void SetUp() 
        {
            jas = new JobApplicationService(context);
        }
        [Test]
        public void CreateAnAplicant_Works() 
        {
            CreateASpecialistVM vm = new CreateASpecialistVM()
            {
                Address="Example adress",
                Age=22,
                Description="Example Description",
                Specialisations = "example, example ,example",
                ImageURL = "https://www.greenlawnfertilizing.com/wp-content/uploads/2017/01/oak-tree-540x540.jpg.webp",
                PhoneNumber="0000000000",
                Id = Guid.NewGuid(),
            };
            var ap = jas.CreateAnAplicant(vm);
            Assert.IsNotNull(ap);
        }
        [Test]
        public void ASaveJobApplication_Works()
        {
            JobApplicationVM javm = new JobApplicationVM()
            {
                Id = Guid.Parse("6856ad87-2fec-4a9d-a420-acb85b3b5c48"), 
                AplicantId= Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"),
                CV = new byte[224],
                Certification = new byte[224],
                ScannedDiploma = new byte[224],
            };
            jas.SaveJobApplication(javm);

            Assert.That(jas.GetAllJobApplications().Result.Count(), Is.EqualTo(2));
        }
        //[Test]
        //public void SaveAplicant_Works()
        //{
        //    AplicantVM avm = new AplicantVM()
        //    {
        //        Id = Guid.NewGuid(),
        //        Address = "Example Address",
        //        Age = 22,
        //        JobApplicationId = Guid.Parse("6856ad87-2fec-4a9d-a420-acb85b3b5c48"),
        //        Description = "Example Description",
        //        Specialisations = "example, example",
        //        ImageURL = "https://www.greenlawnfertilizing.com/wp-content/uploads/2017/01/oak-tree-540x540.jpg.webp",
        //        UserId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"),
        //    };
        //    jas.SaveAplicant(avm, Guid.Parse("6856ad87-2fec-4a9d-a420-acb85b3b5c48"));
        //    var idk = context.Aplicants.ToList();
        //    Assert.That(context.Aplicants.Count(), Is.EqualTo(2));
        //}
        [Test]
        public void GetJobAppligation_Works()
        {
            var Id = Guid.Parse("6856ad87-2fec-4a9d-a420-acb85b3b5c48");
            var ap = jas.GetJobApplication(Id).Result;
            Assert.IsNotNull(ap);
        }
        [Test]
        public void GetJobAppligationByAplicantId_Works()
        {
            var Id = Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174");
            var ap = jas.GetJobApplicationByAplicantId(Id).Result;
            Assert.IsNotNull(ap);
        }
        [Test]
        public void Delete_Works()
        {
            var Id = Guid.Parse("c66c791a-3ce2-4347-a9a8-482589035906");
            jas.DeleteJobApplication(Id);
            Assert.That(context.JobApplicationForms.Count(), Is.EqualTo(1));
        }
        [Test]
        public void CreateAJobApplication_Works()
        {
            AplicantVM avm = new AplicantVM()
            {
                Id = Guid.NewGuid(),
                Address = "Example Address",
                Age = 22,
                JobApplicationId = Guid.Parse("6856ad87-2fec-4a9d-a420-acb85b3b5c48"),
                Description = "Example Description",
                Specialisations = "example, example",
                ImageURL = "https://www.greenlawnfertilizing.com/wp-content/uploads/2017/01/oak-tree-540x540.jpg.webp",
                UserId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"),
            };
            var CV = File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\catCV.jpg");
            var ScannedDiploma = File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\HillDiploma.jpg");
            var Certification = File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\catCertifications.jpg");
            IFormFile formFile = this.TurnByeArrayToFile(CV);
            IFormFile formFile1 = this.TurnByeArrayToFile(ScannedDiploma);
            IFormFile formFile2 = this.TurnByeArrayToFile(Certification);
            var javm = jas.CreateAJobApplication(avm, formFile, formFile1, formFile2);
            Assert.IsNotNull(javm);
        }
        public IFormFile TurnByeArrayToFile(byte[] bt)
        {
            using (MemoryStream ms = new MemoryStream(bt))
            {
                return new FormFile(ms, 0, bt.Length, "name", "fileName");
            }
        }
    }
}
