using MentalDepths.Services.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class ApointmentController : Controller
    {
        private IApointmentService apservice;
        private ISpecialistService specialistService;
        public ApointmentController(IApointmentService apservice, ISpecialistService specialistService)
        {
            this.apservice = apservice;
            this.specialistService = specialistService;
        }
        public IActionResult Book(Guid SpecialistId,Guid UserId)
        {
            var apointment = apservice.GenerateNewApointement(SpecialistId, UserId).Result;
            specialistService.SendTheAppointmentToTheSpecialist(apointment);
            return View(apointment);
        }
    }
}
