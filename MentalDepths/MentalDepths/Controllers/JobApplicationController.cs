using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace MentalDepths.Controllers
{
    public class JobApplicationController : Controller
    {
        private IJobApplicatipnService jobApplicatipnService;
        public JobApplicationController(IJobApplicatipnService jas)
        {
            jobApplicatipnService = jas;
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Apply(CreateASpecialistVM model)
        {
            var spec = jobApplicatipnService.CreateASpecialist(model).Result;
            return RedirectToAction("JobAppliaction", new {spec});
        }
        [HttpGet]
        public IActionResult JobAppliaction() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult JobAppliaction(SpecialistVM specialist,JobApplicationFileVM model)
        {
            var jobapplication = jobApplicatipnService.CreateAJobApplication(specialist, model).Result;
            return View();
        }
    }
}
