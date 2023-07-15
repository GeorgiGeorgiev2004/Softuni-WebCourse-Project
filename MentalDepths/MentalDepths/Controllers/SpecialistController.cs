using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class SpecialistController : Controller
    {
        private readonly ISpecialistService specialistService;
        public SpecialistController(ISpecialistService sp)
        {
            specialistService = sp;
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
