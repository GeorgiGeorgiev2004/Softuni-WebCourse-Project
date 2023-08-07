using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class SpecialistController : BaseController
    {
        private ISpecialistService specialistService;
        private IAdminService adminService;
        public SpecialistController(ISpecialistService sp, IAdminService adminService)
        {
            specialistService = sp;
            this.adminService = adminService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var list = await specialistService.GetAllSpecialist();
            return View(list);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> More(Guid id)
        {
            var spec = await specialistService.FindSpecialistById(id);
            return View(spec);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register(Guid aplicantId)
        {
            var aplicant = adminService.FindAplicantById(aplicantId).Result;
            var specialist = adminService.TurnAplicantToSpecialist(aplicant).Result;
            return View(specialist);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register(RegisterASpecicalistVM spcialist)
        {
            if (!ModelState.IsValid) 
            {
                View();
            }
            await specialistService.SaveASpecialistToTheDb(spcialist);
            return RedirectToAction("All");
        }
    }
}
