using MentalDepths.Services.Web.Interfaces;
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
        public async Task<IActionResult> All()
        {
            var list = await specialistService.GetAllSpecialist();
            return View(list);
        }
    }
}
