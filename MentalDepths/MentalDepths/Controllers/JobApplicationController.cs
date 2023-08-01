using MentalDepths.Services.Web;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MentalDepths.Common.ModelRegulations;

namespace MentalDepths.Controllers
{
    public class JobApplicationController : BaseController
    {
        private IJobApplicatipnService jobApplicationService;
        private IAdminService adminService;
        public JobApplicationController(IJobApplicatipnService jas, IAdminService adminService)
        {
            jobApplicationService = jas;
            this.adminService = adminService;
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Apply(CreateASpecialistVM model)
        {
            AplicantVM ap = jobApplicationService.CreateAnAplicant(model).Result;
            if (!ModelState.IsValid)
            {
                return View();
            }
            return RedirectToAction("JobAppliaction", ap);
        }
        [HttpGet]
        public IActionResult JobAppliaction()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> JobAppliaction(AplicantVM aplicant,IFormFile CV, IFormFile Diploma,IFormFile Certification)
        {
            var jobapplication = jobApplicationService.CreateAJobApplication(aplicant, CV, Diploma, Certification).Result;
            await jobApplicationService.SaveJobApplication(jobapplication);
            await jobApplicationService.SaveAplicant(aplicant,jobapplication.Id);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Hire(Guid id) 
        {
            var aplicant = adminService.FindAplicantById(id).Result;
            EmailSender es = new EmailSender();
            var email = es.GeneratePossitiveOutcome(aplicant.ApplicationUser.Email).Result;
            return View(email);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Hire(Guid id,EmailVM mail)
        {
            var aplicant = adminService.FindAplicantById(id).Result;
            EmailSender es = new EmailSender();
            await es.SendEmailAsync(mail.Email, mail.Subject, mail.Message);
            return RedirectToAction("register", "specialist", new { aplicant });
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Dismiss(Guid id)
        {
            var aplicant = adminService.FindAplicantById(id).Result;
            EmailSender es = new EmailSender();
            var email = es.GenerateNegativeOutcome(aplicant.ApplicationUser.Email).Result;
            return View(email);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Dismiss(Guid id,EmailVM mail)
        {
            var aplicant = adminService.FindAplicantById(id).Result;
            EmailSender es = new EmailSender();
            await es.SendEmailAsync(mail.Email, mail.Subject, mail.Message);
            var jobapplication = jobApplicationService.GetJobApplicationByAplicantId(aplicant.Id).Result;
            await jobApplicationService.DeleteJobApplication(jobapplication.Id);
            return RedirectToAction("jobapplications", "admin");
        }
    }
}
