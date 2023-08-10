using MentalDepths.Services.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    public class SpecialisationTest:UnitTestBase
    {
        private SpecialisationService spc;

        [SetUp]
        public void SetUp() 
        {
            spc = new SpecialisationService(context);
        }
        [Test]
        public void GetAllSpecialisations_Works() 
        {
            var specialisations = spc.GetAllSpecialisations().Result;

            Assert.That(specialisations.Count, Is.EqualTo(1));
        }
        [Test]
        public void Delete_Works()
        {
            var specialisations = spc.GetAllSpecialisations().Result;
            spc.Delete("Test Specialisation");
            specialisations = spc.GetAllSpecialisations().Result;

            Assert.That(specialisations.Count, Is.EqualTo(0));
            spc.AddSpecialisationToDB(new MentalDepths.Web.ViewModels.Web.SpecialisationVM()
            {
                Id = 1,
                Name = "Test Specialisation",
            });
        }
        [Test]
        public void AddSpecialisationToDB_Works()
        {
            spc.AddSpecialisationToDB(new MentalDepths.Web.ViewModels.Web.SpecialisationVM() 
            {
                Id = 2,
                Name = "Added Specialisation",
            });
            var specialisations = spc.GetAllSpecialisations().Result;

            Assert.That(specialisations.Count, Is.EqualTo(2));

            spc.Delete("Added Specialisation");
        }
    }
}
