﻿using MentalDepths.Services.Web;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : BaseController
    {
        private IAdminService adminService;
        private IJobApplicatipnService jobApplicatipnService;
        public AdminController(IAdminService admin,IJobApplicatipnService jbs)
        {
            jobApplicatipnService = jbs;
            adminService = admin;
        }

        public async Task<IActionResult> JobApplications()
        {
            var AllJobApplications = jobApplicatipnService.GetAllJobApplications().Result;
            return View(AllJobApplications);
        }
        public async Task<IActionResult> ShowCV(Guid id) 
        {
            var jobapplication = jobApplicatipnService.GetJobApplication(id).Result;
            return File(jobapplication.CV, "image/jpg");
        }
        public async Task<IActionResult> ShowDiploma(Guid id)
        {
            var jobapplication = jobApplicatipnService.GetJobApplication(id).Result;
            return File(jobapplication.ScannedDiploma, "image/jpg");
        }
        public async Task<IActionResult> ShowCertification(Guid id)
        {
            var jobapplication = jobApplicatipnService.GetJobApplication(id).Result;
            return File(jobapplication.Certification, "image/jpg");
        }
    }
}
