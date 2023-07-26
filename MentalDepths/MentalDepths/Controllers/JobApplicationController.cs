using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class JobApplicationController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(SpecialistVM model)
        {

            return View();
        }
        [HttpGet]
        public IActionResult SecondStepInApplying() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult SecondStepInApplying(JobApplicationVM model)
        {
            return View();
        }
    }
}
