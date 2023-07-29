﻿namespace MentalDepths.Services.Web
{
    using MentalDepths.Data;
    using MentalDepths.Data.Models;
    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.Infrastructure.Extensions;
    using MentalDepths.Web.ViewModels.Web;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class JobApplicatipnService : IJobApplicatipnService
    {
        private MentalDepthsDbContext context;
        public JobApplicatipnService(MentalDepthsDbContext context)
        {
            this.context = context;
        }

        public async Task<JobApplicationVM> CreateAJobApplication(AplicantVM model, IFormFile CV, IFormFile Diploma, IFormFile Certification)
        {
            var fm = new FileReaderAndWriter();
            var javm = new JobApplicationVM()
            {
                Id = Guid.NewGuid(),
                Aplicant = new Aplicant
                {
                    ImageURL = model.ImageURL,
                    Address = model.Address,
                    Specialisations = model.Specialisations,
                    Age = model.Age,
                    ApplicationUser = model.ApplicationUser,
                    UserId = model.UserId,
                    Description = model.Description
                }
            };
            javm.AplicantId = javm.Aplicant.Id;
            if (CV.Length > 0)
            {
                javm.CV = fm.TurnFileToByteArray(CV);
            }
            if (Diploma.Length > 0)
            {
                javm.ScannedDiploma = fm.TurnFileToByteArray(Diploma);
            }
            if (Certification.Length > 0)
            {
                javm.Certification = (fm.TurnFileToByteArray(Certification));
            }

            return javm;
        }

        public async Task<AplicantVM> CreateAnAplicant(CreateASpecialistVM model)
        {
            AplicantVM aplicant = new AplicantVM()
            {
                Id = Guid.NewGuid(),
                ApplicationUser = context.ApplicationUsers.FirstAsync(s => s.Id == model.UserId).Result,
                UserId = model.UserId,
                ImageURL = model.ImageURL,
                Age = model.Age,
                Address = model.Address,
                Description = model.Description,
                Specialisations = model.Specialisations,
            };
            aplicant.ApplicationUser.PhoneNumber = model.PhoneNumber;
            return aplicant;

        }

        public async Task SaveAplicant(AplicantVM aplicant, Guid JobAplicationId)
        {
            var ap = new Aplicant()
            {
                Id = Guid.NewGuid(),
                ApplicationUser = context.ApplicationUsers.FirstAsync(s => s.Id == aplicant.UserId).Result,
                UserId = aplicant.UserId,
                ImageURL = aplicant.ImageURL,
                Age = aplicant.Age,
                Address = aplicant.Address,
                Description = aplicant.Description,
                Specialisations = aplicant.Specialisations,
                JobApplicationId = JobAplicationId,
            };
            await context.Aplicants.AddAsync(ap);
            await context.SaveChangesAsync();
        }

        public async Task SaveJobApplication(JobApplicationVM javm)
        {
            JobApplicationForm jaf = new JobApplicationForm()
            {
                Id = javm.Id,
                AplicantId = javm.AplicantId,
                CV = javm.CV,
                ScannedDiploma = javm.ScannedDiploma,
                Certification = javm.Certification,
            };
            await context.JobApplicationForms.AddAsync(jaf);
            await context.SaveChangesAsync();
        }
    }
}
