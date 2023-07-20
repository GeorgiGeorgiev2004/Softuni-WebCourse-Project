using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class SpecialistController : Controller
    {
        private ISpecialistService specialistService;
        private IApointmentService apointmentService;
        
        public SpecialistController(ISpecialistService sp, IApointmentService apointmentService)
        {
            specialistService = sp;
            this.apointmentService = apointmentService;
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
    }
}
