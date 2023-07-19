using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class SpecialistController : Controller
    {
        private ISpecialistService specialistService;
        private IApointmentService apointmentService;
        private INoteService noteService;
        public SpecialistController(ISpecialistService sp, IApointmentService apointmentService, INoteService noteService)
        {
            specialistService = sp;
            this.apointmentService = apointmentService;
            this.noteService = noteService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var list = await specialistService.GetAllSpecialist();
            return View(list);
        }
        [HttpGet]
		public async Task<IActionResult> More(Guid id)
		{
			var spec = await specialistService.FindSpecialistById(id);
			return View(spec);
		}
        [HttpGet]
        public async Task<IActionResult> MyChats(Guid id)
        {
            var apointments = await apointmentService.GetAllApointementsForSpecialist(id);
            return View(apointments);
        }
        [HttpGet]
        public async Task<IActionResult> Note(Guid BookApointmentVMId)
        {
            var note = noteService.GetNoteFromApointment(BookApointmentVMId).Result;
            return View(note);
        }
        [HttpPost]
        public async Task<IActionResult> Note(Guid BookApointmentVMId,NoteVm model)
        { 
            await noteService.SaveChangesToNote(BookApointmentVMId, model);
            return RedirectToAction("Index","Home");
        }
    }
}
