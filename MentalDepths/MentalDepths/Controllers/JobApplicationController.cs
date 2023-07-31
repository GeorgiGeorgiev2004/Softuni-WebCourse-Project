﻿using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;
namespace MentalDepths.Controllers
{
    public class JobApplicationController : BaseController
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
            AplicantVM ap = jobApplicatipnService.CreateAnAplicant(model).Result;
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
            var jobapplication = jobApplicatipnService.CreateAJobApplication(aplicant, CV, Diploma, Certification).Result;
            await jobApplicatipnService.SaveJobApplication(jobapplication);
            await jobApplicatipnService.SaveAplicant(aplicant,jobapplication.Id);
            return RedirectToAction("Index", "Home");
        }
    }
}
