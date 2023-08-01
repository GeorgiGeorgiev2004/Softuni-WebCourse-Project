namespace MentalDepths.Services.Web
{
    using MentalDepths.Data;
    using MentalDepths.Data.Models;
    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.Infrastructure.Extensions;
    using MentalDepths.Web.ViewModels.Web;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public class JobApplicationService : IJobApplicatipnService
    {
        private MentalDepthsDbContext context;
        public JobApplicationService(MentalDepthsDbContext context)
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

        public async Task DeleteJobApplication(Guid JobAplicationId)
        {
            var jobapplication = context.JobApplicationForms.FirstOrDefaultAsync(a=>a.Id== JobAplicationId).Result;
            context.JobApplicationForms.Remove(jobapplication);
            await context.SaveChangesAsync();
        }

        public async Task<ICollection<JobApplicationVM>> GetAllJobApplications()
        {
            var jobApplications =  await context.JobApplicationForms.Select(f => new JobApplicationVM()
            {
                Id = f.Id,
                AplicantId = f.AplicantId,
                Aplicant = context.Aplicants.First(a => a.Id == f.AplicantId),
                CV = f.CV,
                ScannedDiploma = f.ScannedDiploma,
                Certification = f.Certification,
            }).ToListAsync();
            return jobApplications;
        }

        public async Task<JobApplicationVM> GetJobApplication(Guid JobAplicationId)
        {
            var jap = context.JobApplicationForms.FirstOrDefaultAsync(j => j.Id == JobAplicationId).Result;
            return new JobApplicationVM()
            {
                Id=jap.Id,
                CV=jap.CV,
                ScannedDiploma=jap.ScannedDiploma,
                Certification = jap.Certification,
                AplicantId=jap.AplicantId,
                Aplicant=context.Aplicants.First(A=>A.Id==jap.AplicantId)
            };
        }

        public async Task<JobApplicationVM> GetJobApplicationByAplicantId(Guid AplicantId)
        {
            var jobapplication = await context.JobApplicationForms.FirstOrDefaultAsync(ja => ja.AplicantId == AplicantId);
            return new JobApplicationVM()
            {
                Id = jobapplication.Id,
                AplicantId = jobapplication.AplicantId,
                Aplicant = context.Aplicants.First(a => a.Id == jobapplication.AplicantId),
                CV = jobapplication.CV,
                ScannedDiploma = jobapplication.ScannedDiploma,
                Certification = jobapplication.Certification,
            };
        }

        public async Task SaveAplicant(AplicantVM aplicant, Guid JobAplicationId)
        {
            var jobapplication = await context.JobApplicationForms.FirstOrDefaultAsync(a => a.Id == JobAplicationId);
            var ap = new Aplicant()
            {
                Id = jobapplication.AplicantId,
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
