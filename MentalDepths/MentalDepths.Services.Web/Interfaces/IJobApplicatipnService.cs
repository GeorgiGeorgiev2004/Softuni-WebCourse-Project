using MentalDepths.Data.Models;
using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IJobApplicatipnService
    {
        public Task<SpecialistVM> CreateASpecialist(CreateASpecialistVM model);
        public Task<JobApplicationVM> CreateAJobApplication(SpecialistVM specialist, JobApplicationFileVM model);
    }
}
