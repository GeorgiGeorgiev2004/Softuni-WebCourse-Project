using MentalDepths.Services.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class ApointmentController : Controller
    {
        private IApointmentService apservice;
        public ApointmentController(IApointmentService apservice)
        {
            this.apservice = apservice;
        }
        public IActionResult Book(Guid SpecialistId,Guid UserId)
        {
            var apointment = apservice.GenerateNewApointement(SpecialistId, UserId).Result;
            return View(apointment);
        }
    }
}
