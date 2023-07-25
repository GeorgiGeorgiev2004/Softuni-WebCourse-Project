using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        [HttpGet]
        public IActionResult Book(Guid SpecialistId, Guid UserId)
        {
            var apointment = apservice.GenerateNewApointement(SpecialistId, UserId).Result;
            return View(apointment);
        }
        [HttpPost]
        public IActionResult Book(BookApointementVM bavm)
        {
            apservice.SaveApointment(bavm);
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("MyConversations", "Conversation", new { id });
        }
        public IActionResult MyApointments(Guid id)
        {
            var apointments = apservice.GetAllApointementsForUser(id).Result;
            return View(apointments);
        }
        public IActionResult MyPastApointments(Guid id)
        {
            var apointments = apservice.GetAllApointementsForUser(id).Result;
            return View(apointments);
        }
        [HttpGet]
        public IActionResult MarkAsCompleted(Guid id)
        {
            var apointment = apservice.GetApointmentById(id).Result;
            return View(apointment);
        }
        [HttpPost]
        public IActionResult MarkAsCompleted(Guid id,BookApointementVM model)
        {
            apservice.ConfirmApointmentOccured(id);
            var ID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("MyApointments", "Apointment", new { ID });
        }
    }
}
