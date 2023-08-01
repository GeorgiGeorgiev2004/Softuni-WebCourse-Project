using MentalDepths.Data.Models;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IJobApplicatipnService
    {
        public Task<AplicantVM> CreateAnAplicant(CreateASpecialistVM model);
        public Task SaveJobApplication(JobApplicationVM javm);
        public Task SaveAplicant(AplicantVM aplicant, Guid JobAplicationId);
        public Task<ICollection<JobApplicationVM>> GetAllJobApplications();
        public Task<JobApplicationVM> GetJobApplication(Guid JobAplicationId);
        public Task<JobApplicationVM> GetJobApplicationByAplicantId(Guid AplicantId);
        public Task DeleteJobApplication(Guid JobAplicationId);
        public Task<JobApplicationVM> CreateAJobApplication(AplicantVM aplicant, IFormFile CV, IFormFile Diploma, IFormFile CertificationFiles);
    }
}
