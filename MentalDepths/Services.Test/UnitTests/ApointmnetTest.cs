using MentalDepths.Services.Web;
using MentalDepths.Web.ViewModels.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    [TestFixture]
    public class ApointmnetTest:UnitTestBase
    {
        private ApointmentService apointmentService;
        [SetUp]
        public void SetUp()
        {
            apointmentService = new ApointmentService(context);
        }

        [Test]
        public void GetApointmentById_Works()
        {
            var apointmentId = Guid.Parse("ab65ae1f-cef0-4f16-a02d-18cc33d34134");
            var apointment = context.Apointments.FirstOrDefault(a => a.Id == apointmentId);
            var bm = new BookApointementVM()
            {
                Id = apointment.Id,
                SpecialistId = apointment.SpecialistId,
                UserId = apointment.ApplicationUserId,
                Address = apointment.Address,
                Date = apointment.DateAndTime,
                HasOccured = apointment.HasPassed
            };
            var MethodApointment = apointmentService.GetApointmentById(apointmentId).Result;
            Assert.That(bm.UserId, Is.EqualTo(MethodApointment.UserId));
            Assert.That(bm.SpecialistId, Is.EqualTo(MethodApointment.SpecialistId));
        }
        [Test]
        public void GenerateNewAppointment_Works() 
        {
            var specialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var patientId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");

            var BookApointmentVM = apointmentService.GenerateNewApointement(specialistId, patientId).Result;

            Assert.That(BookApointmentVM.SpecialistId, Is.EqualTo(specialistId));
            Assert.That(BookApointmentVM.UserId, Is.EqualTo(patientId));
            Assert.That(BookApointmentVM.HasOccured, Is.EqualTo(false));
            Assert.That(BookApointmentVM.Address, Is.EqualTo(MentalDepths.Common.Constatnts.Office.OfficeAddress));
        }
        [Test]
        public void GetAllApointmentsForUser_Works()
        {
            var specialistId = Guid.Parse("b7c79b57-ff1f-42fb-ab13-15e730e42957");
            var apointmentId = Guid.Parse("ab65ae1f-cef0-4f16-a02d-18cc33d34134");

            var apointment = context.Apointments.FirstOrDefault(a=>a.Id==apointmentId);

            var BookApointmentVMList = apointmentService.GetAllApointementsForUser(specialistId).Result.ToList();

            Assert.That(BookApointmentVMList[0].Id, Is.EqualTo(apointment.Id));
        }
        [Test]
        public void SaveAppointment_Works()
        {
            var specialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var patientId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");
            BookApointementVM bavm = new BookApointementVM() 
            {
                Id = Guid.Parse("b0a1c8ad-c84a-4c43-b358-c77a6de5743a"),
                SpecialistId = specialistId,
                Address = MentalDepths.Common.Constatnts.Office.OfficeAddress,
                Date = DateTime.Now,
                HasOccured = false,
                UserId=patientId
            };

            apointmentService.SaveApointment(bavm);
            Assert.That(context.Apointments.Count(),Is.EqualTo(2));
        }
        [Test]
        public void ConfirmApointmentOccured_Works()
        {
            var apointmentId = Guid.Parse("ab65ae1f-cef0-4f16-a02d-18cc33d34134");
            apointmentService.ConfirmApointmentOccured(apointmentId);
            var apointment = apointmentService.GetApointmentById(apointmentId);
            Assert.That(apointment.IsCompleted, Is.EqualTo(true));
        }
    }
}
